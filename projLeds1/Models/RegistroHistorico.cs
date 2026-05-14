using System;

namespace projLeds1.Models
{
    public class RegistroHistorico
    {
        public DateTime DataHora { get; set; }

        public double Temperatura { get; set; }

        public int LEDs { get; set; }

        public override string ToString()
        {
            return $"{DataHora:HH:mm:ss} | Temp: {Temperatura:F1} | LEDs: {LEDs}";
        }
    }
}