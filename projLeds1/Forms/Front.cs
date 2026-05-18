
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projLeds1.Forms
{
    internal class Front
    {
        public void Arredondar(Control controle, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddArc(new Rectangle(controle.Width - raio, 0, raio, raio), 270, 90);
            path.AddArc(new Rectangle(controle.Width - raio, controle.Height - raio, raio, raio), 0, 90);
            path.AddArc(new Rectangle(0, controle.Height - raio, raio, raio), 90, 90);

            path.CloseFigure();

            controle.Region = new Region(path);
        }
    }
}
