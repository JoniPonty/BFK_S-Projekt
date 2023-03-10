using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BFK_S_Projekt
{
    internal class club_class
    {
        //Variablen für connection string werden global gesetzt
        private string server = "localhost";
        private string username = "root";
        private string database = "mydb";

        //Klassen für SQL Verbindung werden gesetzt
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        MySqlDataAdapter Dta = new MySqlDataAdapter();
        MySqlDataReader sqlRd = null;

        DataSet ds = new DataSet();

        //Daten werden in die DataGridView geladen
        public DataTable getData()
        {
            dt = new DataTable();
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT club.club_name, CONCAT(trainer.trainer_vorname, ' ',trainer.trainer_nachname) AS Trainer FROM mydb.club INNER JOIN mydb.trainer ON club.Trainer_idTrainer = trainer.idTrainer;";
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
        }

        //Returnt einen Array mit allen Trainern
        public string[] getTrainer()
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT trainer_vorname, trainer_nachname FROM mydb.trainer";
            sqlRd = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (sqlRd.Read())
            {
                list.Add(sqlRd.GetTextReader(0).ReadLine() + " " + sqlRd.GetTextReader(1).ReadLine());
            }
            sqlRd.Close();
            conn.Close();
            return list.ToArray();
        }

        //Setzt einen neuen Club in der Datenbank
        public void setData(string data)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO `mydb`.`Club` (`idClub`, `club_name`, `Trainer_idTrainer`) VALUES ({data});";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Updatet Daten in der Datenbank
        public void updateData(string dataClub, string dataTrainer, int indexNew, int indexOld, string trainerName, string clubName)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                int clubId = getClubId(clubName, indexOld);
                if (dataTrainer != "")
                {
                    int idNew = getTrainerId(dataTrainer, indexNew);
                    cmd.CommandText = $"UPDATE Club SET {dataClub}, Trainer_idTrainer='{idNew}' WHERE idClub={clubId};";
                }
                else 
                {
                    int idOld = getTrainerId(trainerName, indexOld);
                    cmd.CommandText = $"UPDATE Club SET {dataClub}, Trainer_idTrainer='{idOld}' WHERE idClub={clubId};";
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Löscht Daten aus der Datenbank
        public void deleteData(string name, int index)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            conn.Open();
            cmd.Connection = conn;
            int id = getClubId(name, index);
            cmd.CommandText = $"DELETE FROM club_has_spieler WHERE Club_idClub={id};";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"DELETE FROM Club WHERE idClub={id};";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Returnt die Trainer Id
        public int getTrainerId(string name, int times)
        {
            int r = 0;
            if (conn.State.ToString() == "Open")
            {
                cmd.CommandText = $"SELECT idTrainer FROM mydb.trainer WHERE concat(trainer_vorname, ' ', trainer_nachname)='{name}';";
                sqlRd = cmd.ExecuteReader();
                for (int i = 0; i < times + 1; i++)
                {
                    sqlRd.Read();
                    r = sqlRd.GetInt32(0);
                }
                sqlRd.Close();
            }
            else
            {
                conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT idTrainer FROM mydb.trainer WHERE concat(trainer_vorname, ' ', trainer_nachname)='{name}';";
                sqlRd = cmd.ExecuteReader();
                for (int i = 0; i < times + 1; i++)
                {
                    sqlRd.Read();
                    r = sqlRd.GetInt32(0);
                }
                sqlRd.Close();
                conn.Close();
            }
            return r;
        }

        //Returnt die Club Id
        public int getClubId(string name, int times)
        {
            int r = 0;
            cmd.CommandText = $"SELECT idClub FROM mydb.club WHERE club_name='{name}';";
            sqlRd = cmd.ExecuteReader();
            for (int i = 0; i < times + 1; i++)
            {
                sqlRd.Read();
                r = sqlRd.GetInt32(0);
            }
            sqlRd.Close();
            return r;
        }
    }
}
