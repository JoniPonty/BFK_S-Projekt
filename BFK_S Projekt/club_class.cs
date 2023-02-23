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
        private string server = "localhost";
        private string username = "root";
        private string database = "mydb";

        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        MySqlDataAdapter Dta = new MySqlDataAdapter();
        MySqlDataReader sqlRd = null;

        DataSet ds = new DataSet();

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

        public string[] getTrainer()
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select trainer_vorname, trainer_nachname from mydb.trainer";
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

        public void updateData(string dataClub, string dataTrainer, int index, string name)
        {
            int id = getId(name, index);
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if (dataClub != "")
                {
                    cmd.CommandText = $"SELECT idClub FROM mydb.club WHERE club_name='{dataClub}'";
                    sqlRd = cmd.ExecuteReader();
                    sqlRd.Read();
                    int clubId = sqlRd.GetInt32(0);
                    sqlRd.Close();
                    cmd.CommandText = $"UPDATE Spieler SET {dataTrainer} WHERE idSpieler={id}; UPDATE Club_has_Spieler SET Club_idClub={clubId} WHERE Spieler_idSpieler={id}";
                }
                else
                {
                    cmd.CommandText = $"UPDATE Spieler SET {dataTrainer} WHERE idSpieler={id}";
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int getId(string name, int times)
        {
            int r = 0;
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT idTrainer FROM mydb.trainer WHERE concat(trainer_vorname, ' ', trainer_nachname)='{name}'";
            sqlRd = cmd.ExecuteReader();
            for(int i = 0; i < times+1; i++)
            {
                sqlRd.Read();
                r = sqlRd.GetInt32(0);
            }
            sqlRd.Close();
            conn.Close();
            return r;
        }
    }
}
