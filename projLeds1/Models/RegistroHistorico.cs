using System;
using System.Diagnostics;

namespace projLeds1.Models
{
    public class RegistroHistorico
    {
        public DateTime DataHora { get; set; }

        public double Temperatura { get; set; }

        public int LEDs { get; set; }

        public double RPM { get; set; }

        public double Corrente { get; set; }

        public string Equipamento { get; set; }

        public string Evento { get; set; }


        public override string ToString()
        {
            if (Equipamento == "Motor")
            {
                return
                    $"{DataHora:HH:mm:ss} | " +
                    $"RPM: {RPM:F0} | " +
                    $"Temp: {Temperatura:F1} | " +
                    $"Corrente: {Corrente:F1}A | " +
                    $"{Evento}";
            }

            return
                $"{DataHora:HH:mm:ss} | " +
                $"Temp: {Temperatura:F1} | " +
                $"LEDs: {LEDs}";
        }
    }
}