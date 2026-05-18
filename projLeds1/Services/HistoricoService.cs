using System.Collections.Generic;

using projLeds1.Models;

namespace projLeds1.Services
{
    public class HistoricoService
    {
        private List<RegistroHistorico> registros;

        public HistoricoService()
        {
            registros = new List<RegistroHistorico>();
        }

        public void Adicionar(
            RegistroHistorico registro)
        {
            registros.Add(registro);
        }

        public List<RegistroHistorico> GetTodos()
        {
            return registros;
        }

        //========================
        // MOTOR
        //========================

        public RegistroHistorico RegistrarMotor(
            MotorStatus dados,
            string evento)
        {
            RegistroHistorico registro =
                new RegistroHistorico();

            registro.DataHora =
                System.DateTime.Now;

            registro.RPM =
                dados.RPM;

            registro.Corrente =
                dados.Corrente;

            registro.Temperatura =
                dados.Temperatura;

            registro.Evento =
                evento;

            registro.Equipamento =
                "Motor";

            registros.Add(registro);

            return registro;
        }
    }
}