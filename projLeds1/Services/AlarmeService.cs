using System.Drawing;

namespace projLeds1.Services
{
    public class AlarmeService
    {
        public string GetMensagem(
            double temperatura,
            int ativos)
        {
            if (temperatura > 100)
                return "🔥 ALERTA CRÍTICO";
            if (temperatura > 50)
                return "⚠️ ATENÇÃO";
            if (ativos > 0)
                return "SISTEMA EM OPERAÇÃO";

            return "SISTEMA STANDBY";
        }

        public Color GetCor(
            double temperatura,
            int ativos)
        {
            if (temperatura > 100)
                return Color.Red;
            
            if (temperatura > 50)
                return Color.Orange;

            if (ativos > 0)
                return Color.Yellow;

            return Color.Lime;
        }
    }
}
