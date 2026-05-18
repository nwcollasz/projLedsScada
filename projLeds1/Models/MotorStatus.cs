namespace projLeds1.Models
{
    public class MotorStatus
    {
        public string Status { get; set; } = "DESLIGADO";
        public double RPM { get; set; } = 0;
        public double FrequenciaHz { get; set; } = 0;
        public double Corrente { get; set; } = 0;
        public double Temperatura { get; set; } = 25.0; 
        public double TorqueCarga { get; set; } = 0;
    }
}