using projLeds1.Models;
using System;

namespace projLeds1.Services
{
    public class MotorService
    {
        public MotorStatus Dados { get; private set; }

        private bool ligado;
        private double hzAlvo;

        private const int NUMERO_POLOS = 4;
        private const double TEMP_AMBIENTE = 25.0;
        private const double RESISTENCIA_ESTATOR = 1.2;
        private const double ATRITO_MECANICO = 0.95;

        public MotorService()
        {
            Dados = new MotorStatus();
            ligado = false;
            hzAlvo = 0;
            Dados.Status = "DESLIGADO";
            Dados.Temperatura = TEMP_AMBIENTE;
        }

        public void Ligar()
        {
            ligado = true;
            Dados.Status = "LIGADO";
        }

        public void Desligar()
        {
            ligado = false;
            hzAlvo = 0;
            Dados.Status = "DESLIGADO";
        }

        public void DefinirFrequencia(double hz)
        {
            hzAlvo = Clamp(hz, 0, 60);
        }

        public void DefinirCarga(double torqueNm)
        {
            Dados.TorqueCarga = Math.Max(0, torqueNm);
        }

        public void Atualizar()
        {
            if (ligado)
                Dados.FrequenciaHz += (hzAlvo - Dados.FrequenciaHz) * 0.1;
            else
                Dados.FrequenciaHz += (0 - Dados.FrequenciaHz) * 0.2;

            if (Dados.FrequenciaHz < 0.1) Dados.FrequenciaHz = 0;

            double rpmSincrono = (120 * Dados.FrequenciaHz) / NUMERO_POLOS;

            double escorregamento = 0.0;
            if (rpmSincrono > 0)
            {
                escorregamento = (Dados.TorqueCarga * 1.5) / rpmSincrono;
                escorregamento = Clamp(escorregamento, 0, 0.9);
            }

            double rpmAlvoFisico = rpmSincrono * (1 - escorregamento);

            if (ligado)
            {
                Dados.RPM += (rpmAlvoFisico - Dados.RPM) * 0.08;
            }
            else
            {
                Dados.RPM *= ATRITO_MECANICO;
            }

            if (Dados.RPM < 1) Dados.RPM = 0;

            if (ligado && Dados.FrequenciaHz > 1)
            {
                double diferencaVelocidade = rpmSincrono - Dados.RPM;

                double correnteNominal = 2.0 + (Dados.TorqueCarga * 0.8);
                double correntePartida = (diferencaVelocidade / 100.0) * 1.5;

                Dados.Corrente = correnteNominal + Math.Max(0, correntePartida);

                if (Dados.Corrente > 45.0) Dados.Corrente = 45.0;
            }
            else
            {
                Dados.Corrente += (0 - Dados.Corrente) * 0.3;
                if (Dados.Corrente < 0.1) Dados.Corrente = 0;
            }

            double calorGerado = Math.Pow(Dados.Corrente, 2) * RESISTENCIA_ESTATOR * 0.002;

            double capacidadeResfriamento = (Dados.RPM / 1800.0) * 0.4 + 0.02;

            Dados.Temperatura += (calorGerado - capacidadeResfriamento);
   
            if (Dados.Temperatura < TEMP_AMBIENTE)
            {
                Dados.Temperatura = TEMP_AMBIENTE;
            }
        }
        private static double Clamp(double value, double min, double max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}