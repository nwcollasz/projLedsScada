using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using projLeds1.Models;

namespace projLeds1.Services
{
    public class LedExportacaoService
    {
        public void ExportarCSV(
            List<RegistroHistorico> registros)
        {
            SaveFileDialog salvar =
                new SaveFileDialog();

            salvar.Filter =
                "Arquivo CSV (*.csv)|*.csv";

            salvar.Title =
                "Salvar histórico";

            salvar.FileName =
                "historico.csv";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(salvar.FileName))
                {
                    sw.WriteLine(
                        "Hora;Equipamento;Temperatura;LEDs;RPM;Corrente;Evento");

                    foreach (RegistroHistorico registro in registros)
                    {
                        sw.WriteLine(

                            $"{registro.DataHora:HH:mm:ss};" +

                            $"{registro.Equipamento};" +

                            $"{registro.Temperatura:F1};" +

                            $"{registro.LEDs};" +

                            $"{registro.RPM:F0};" +

                            $"{registro.Corrente:F1};" +

                            $"{registro.Evento}"
                        );
                    }
                }

                MessageBox.Show(
                    "Histórico exportado!");
            }
        }
    }
}