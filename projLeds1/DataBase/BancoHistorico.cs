using System;
using System.Data.SQLite;

namespace projLeds1.Database
{
    public class BancoHistorico
    {
        private string banco = "Data Source=historico.db";

        public BancoHistorico()
        {
            CriarBanco();
        }

        private void CriarBanco()
        {
            using (SQLiteConnection conexao = new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Historico (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Data TEXT,
                    Hora TEXT,
                    Temperatura REAL,
                    LEDs INTEGER
                )";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
        }

        public void Salvar(
            string data,
            string hora,
            double temperatura,
            int leds)
        {
            using (SQLiteConnection conexao =
                   new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
                INSERT INTO Historico
                (Data, Hora, Temperatura, LEDs)
                VALUES
                (@data, @hora, @temp, @leds)";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@leds", leds);

                cmd.ExecuteNonQuery();
            }
        }

        public bool RegistroExiste(
            string data,
            string hora,
            double temperatura,
            int leds)
        {
            using (SQLiteConnection conexao =
                   new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM Historico
                WHERE
                Data = @data AND
                Hora = @hora AND
                Temperatura = @temp AND
                LEDs = @leds";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@leds", leds);

                int count =
                    Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }
    }
}
