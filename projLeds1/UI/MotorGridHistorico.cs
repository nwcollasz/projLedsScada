using projLeds1.Models;
using System.Drawing;
using System.Windows.Forms;

namespace projLeds1.UI
{
    public class MotorGridHistorico
    {
         private DataGridView dgv;

        public void Configurar(
            DataGridView dgv)
        {
            this.dgv = dgv;

            dgv.ColumnCount = 5;

            dgv.Columns[0].Name = "Hora";
            dgv.Columns[1].Name = "RPM";
            dgv.Columns[2].Name = "Temperatura";
            dgv.Columns[3].Name = "Corrente";
            dgv.Columns[4].Name = "Evento";

            dgv.RowHeadersVisible = false;

            dgv.AllowUserToAddRows = false;

            dgv.AllowUserToResizeRows = false;

            dgv.BackgroundColor =
                Color.Gainsboro;

            dgv.GridColor =
                Color.Black;

            dgv.BorderStyle =
                BorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(40, 40, 40);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.LightSkyBlue;

            dgv.DefaultCellStyle.BackColor =
                Color.Gainsboro;

            dgv.DefaultCellStyle.ForeColor =
                Color.White;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.DarkCyan;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void AdicionarRegistro(
            RegistroHistorico registro)
        {
            dgv.Rows.Add(

                registro.DataHora
                    .ToString("HH:mm:ss"),

                registro.RPM
                    .ToString("F0"),

                registro.Temperatura
                    .ToString("F2") + " °C",

                registro.Corrente
                    .ToString("F2") + " A",

                registro.Evento
            );
        }
    }
}