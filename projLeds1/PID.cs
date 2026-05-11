using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLeds1
{
    internal class PID
    {
        // CONTROLADOR PID SIMPLES
        public class PIDController 
        {
            // ganhos do controlador
            public double Kp { get; set; }
            public double Ki { get; set; }
            public double Kd { get; set; }

            private double erroAnterior = 0;
            private double integral = 0;

            // construtor do controlador
            public PIDController(double kp, double ki, double kd)
            {
                Kp = kp;
                Ki = ki;
                Kd = kd;
            }

            // método para calcular a saída do controlador
            public double Calcular(double setpoint, double medida)
            {
                double erro = setpoint - medida;

                integral += erro;
                double derivada = erro - erroAnterior;

                erroAnterior = erro;

                return (Kp * erro) + (Ki * integral) + (Kd * derivada);
            }
        }
    }
}
