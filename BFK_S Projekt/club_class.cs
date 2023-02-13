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
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from mydb.club";
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
            dt = new DataTable();
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
