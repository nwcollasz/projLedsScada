using System;

namespace projLeds1.Services
{
    public class MotorLogService
    {
        public string GerarLog(
            double rpm,
            double temp)
        {
            return
                $"[{DateTime.Now:HH:mm:ss}] RPM: {rpm:F0} | TEMP: {temp:F1}°C";
        }
    }
}
