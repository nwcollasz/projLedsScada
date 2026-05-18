using System;
using System.Drawing;
using System.Windows.Forms;

namespace projLeds1.UI
{
    public class MotorSemaforo
    {
        public void AtualizarSemaforo(
            Panel verde,
            Panel amarelo,
            Panel vermelho,
            string status)
        {
            verde.BackColor =
                Color.FromArgb(40, 40, 40);

            amarelo.BackColor =
                Color.FromArgb(40, 40, 40);

            vermelho.BackColor =
                Color.FromArgb(40, 40, 40);

            switch (status)
            {
                case "ONLINE":

                    verde.BackColor =
                        Color.Lime;

                    break;

                case "ALERTA":

                    amarelo.BackColor =
                        Color.Yellow;

                    break;

                default:

                    vermelho.BackColor =
                        Color.Red;

                    break;
            }
        }
    }
    
}
