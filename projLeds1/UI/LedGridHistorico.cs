using System.Drawing;
using System.Windows.Forms;
using projLeds1.Models;

namespace projLeds1.UI
{
    public class LedGridHistorico
    {
        private DataGridView grid;

        public LedGridHistorico(DataGridView dgv)
        {
            grid = dgv;
        }

        public void Configurar()
        {
            grid.RowHeadersVisible = false;

            grid.AllowUserToResizeRows = false;

            grid.BackgroundColor =
                Color.Gainsboro;

            grid.GridColor =
                Color.Black;

            grid.BorderStyle =
                BorderStyle.None;

            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(40, 40, 40);

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.LightSkyBlue;

            grid.DefaultCellStyle.BackColor =
                Color.FromArgb(30, 30, 30);

            grid.DefaultCellStyle.ForeColor =
                Color.White;

            grid.DefaultCellStyle.SelectionBackColor =
                Color.DarkCyan;

            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.RowHeadersVisible = false;

            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.AllowUserToAddRows = false;

            grid.ReadOnly = true;

            grid.Columns.Clear();

            grid.Columns.Add("Hora", "Hora");

            grid.Columns.Add("Temperatura", "Temperatura");

            grid.Columns.Add("LEDs", "LEDs");
        }

        public void AdicionarRegistro(
            RegistroHistorico registro)
        {
            grid.Rows.Add(
                registro.DataHora.ToString("HH:mm:ss"),
                $"{registro.Temperatura:F1} °C",
                registro.LEDs);
        }
    }
}