using projLeds1.Core;
using projLeds1.Models;

namespace projLeds1.Services
{
    public class LedService
    {
        private NumeroLed leds;

        public LedStatus Dados
        {
            get; private set;
        }

        public LedService()
        {
            leds = new NumeroLed();

            Dados =
                new LedStatus();
        }

        public void Toggle(int led)
        {
            if (leds.getLed(led))
                leds.apagar(led);
            else
                leds.acender(led);
        }

        public void ApagarTodos()
        {
            for (int i = 1; i <= 8; i++)
            {
                leds.apagar(i);
            }
        }

        public int GetAtivos()
        {
            int ativos = 0;

            for (int i = 1; i <= 8; i++)
            {
                if (leds.getLed(i))
                    ativos++;
            }

            return ativos;
        }

        public bool GetEstado(int led)
        {
            return leds.getLed(led);
        }

        public byte GetDado()
        {
            return leds.getDado();
        }

        public void AtualizarDados(
            double temperatura)
        {
            Dados.LEDsAtivos =
                GetAtivos();

            Dados.Temperatura =
                temperatura;

            Dados.Dados =
                GetDado();

            Dados.Status =
                Dados.LEDsAtivos > 0
                ? "ONLINE"
                : "STANDBY";
        }
    }
}