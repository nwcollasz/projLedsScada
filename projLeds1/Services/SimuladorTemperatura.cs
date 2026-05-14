using System;
namespace projLeds1.Services
{
    internal class SimuladorTemperatura
    {
        public double Temperatura { get; private set; } = 25;

        public void Atualizar(int ativos)
        {
            if (ativos == 0)
            {
                Temperatura -= 0.8;
            }
            else if (ativos <= 3)
            {
                Temperatura += ativos * 0.2;
            }
            else if (ativos <= 6)
            {
                Temperatura += ativos * 0.5;
            }
            else
            {
                Temperatura += ativos * 1.2;
            }

            Temperatura = Math.Max(25, Math.Min(200, Temperatura));
        }
    }
}
