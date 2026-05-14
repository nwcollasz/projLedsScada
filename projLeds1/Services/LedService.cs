using projLeds1.Core;

namespace projLeds1.Services
{
    public class LedService
    {
         private Leds leds;

    public LedService()
    {
        leds = new Leds();
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
}
    }