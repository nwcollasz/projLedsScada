using System.Drawing;
using System.Windows.Forms;
using projLeds1.Models;

namespace projLeds1.UI
{
    public class GridHistorico
    {
        private DataGridView grid;

        public GridHistorico(DataGridView dgv)
        {
            grid = dgv;
        }

        public void Configurar()
        {
            grid.BackgroundColor = Color.FromArgb(255, 255, 192);

            grid.ForeColor = Color.Black;

            grid.GridColor = Color.Gray;

            grid.BorderStyle = BorderStyle.Fixed3D;

            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(255, 255, 192);

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            grid.DefaultCellStyle.BackColor =
                Color.FromArgb(255, 255, 192);

            grid.DefaultCellStyle.ForeColor =
                Color.Black;

            grid.DefaultCellStyle.SelectionBackColor =
                Color.DarkRed;

            grid.DefaultCellStyle.SelectionForeColor =
                Color.Black;

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