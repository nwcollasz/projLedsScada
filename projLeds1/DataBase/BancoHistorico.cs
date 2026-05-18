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

                string sqlMotor = @"
CREATE TABLE IF NOT EXISTS HistoricoMotor (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Data TEXT,
    Hora TEXT,
    Temperatura REAL,
    RPM INTEGER,
    Corrente INTEGER,
    Evento TEXT
)";

                SQLiteCommand cmdMotor =
                    new SQLiteCommand(sqlMotor, conexao);

                cmdMotor.ExecuteNonQuery();
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

        public void SalvarMotor(
    string data,
    string hora,
    double temperatura,
    int rpm,
    int corrente,
    string evento)
        {
            using (SQLiteConnection conexao =
                   new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
        INSERT INTO HistoricoMotor
        (Data, Hora, Temperatura, RPM, Corrente, Evento)
        VALUES
        (@data, @hora, @temp, @rpm, @corrente, @evento)";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@rpm", rpm);
                cmd.Parameters.AddWithValue("@corrente", corrente);
                cmd.Parameters.AddWithValue("@evento", evento);

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

        public bool RegistroMotorExiste(
    string data,
    string hora,
    double temperatura,
    int rpm)
        {
            using (SQLiteConnection conexao =
                   new SQLiteConnection(banco))
            {
                conexao.Open();

                string sql = @"
        SELECT COUNT(*)
        FROM HistoricoMotor
        WHERE
        Data = @data AND
        Hora = @hora AND
        Temperatura = @temp AND
        RPM = @rpm";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@rpm", rpm);

                int count =
                    Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }
    }
}
