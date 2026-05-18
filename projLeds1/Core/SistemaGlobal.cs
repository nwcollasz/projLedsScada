using projLeds1.Services;

namespace projLeds1.Core
{
    public static class SistemaGlobal
    {
        public static double TemperaturaLEDs = 25;

        public static int LEDsAtivos = 0;

        public static string StatusLEDs = "OFFLINE";

        public static string StatusMotor = "OFFLINE";

        public static double RPM = 0;

        public static double Corrente = 0;

        public static double TemperaturaMotor = 25;
        public static HistoricoService Historico =
            new HistoricoService();
    }
}