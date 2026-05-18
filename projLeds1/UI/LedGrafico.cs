using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace projLeds1.UI
{
    public class LedGrafico
    {
        private Chart chart;

        public LedGrafico(Chart grafico)
        {
            chart = grafico;

            Inicializar();
        }

        private void Inicializar()
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            ChartArea area = new ChartArea("Principal");

            chart.ChartAreas.Add(area);

            area.BackColor = Color.FromArgb(255, 255, 192);

            area.AxisX.LineColor = Color.Transparent;
            area.AxisY.LineColor = Color.Brown;
            area.AxisY2.LineColor = Color.Salmon;

            area.AxisX.LabelStyle.ForeColor = Color.Transparent;
            area.AxisY.LabelStyle.ForeColor = Color.Brown;
            area.AxisY2.LabelStyle.ForeColor = Color.Salmon;

            area.AxisX.MajorGrid.LineColor = Color.Brown;
            area.AxisY.MajorGrid.LineColor = Color.Brown;

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 200;
            area.AxisY.Interval = 50;

            area.AxisY2.Enabled = AxisEnabled.True;

            area.AxisY2.Minimum = 0;
            area.AxisY2.Maximum = 8;
            area.AxisY2.Interval = 4;

            Series leds = new Series("LEDs")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.LightSalmon,
                BorderWidth = 2,
                ChartArea = "Principal",
                YAxisType = AxisType.Secondary
            };

            Series temp = new Series("Temp")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Black,
                BorderWidth = 3,
                ChartArea = "Principal"
            };

            chart.Series.Add(leds);
            chart.Series.Add(temp);

            chart.BackColor = Color.Transparent;

            chart.Legends.Clear();
        }

        public void Atualizar(int ativos, double temperatura)
        {
            chart.Series["LEDs"].Points.AddY(ativos);
            chart.Series["Temp"].Points.AddY(temperatura);

            if (chart.Series["LEDs"].Points.Count > 30)
            {
                chart.Series["LEDs"].Points.RemoveAt(0);
                chart.Series["Temp"].Points.RemoveAt(0);
            }

            chart.Invalidate();
        }
    }
}
