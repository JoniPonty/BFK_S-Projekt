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
    internal class prop
    {
        private string type;
        private string server = "localhost";
        private string username = "root";
        private string database = "mydb";
        public prop(string _type)
        {
            this.type = _type;
        }

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
            cmd.CommandText = "select * from mydb." + type.ToLower();
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
            dt = new DataTable();
        }

        public void setData(string data)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            if(type == "Spieler")
            {
                cmd.CommandText = $"INSERT INTO `mydb`.`{type}` (`id{type}`, `{type.ToLower()}_vorname`, `{type.ToLower()}_nachname`, `{type.ToLower()}_sperre`, `{type.ToLower()}_karten`) VALUES ({data});";
            }
            else if(type == "Trainer")
            {
                cmd.CommandText = $"INSERT INTO `mydb`.`{type}` (`id{type}`, `{type.ToLower()}_vorname`, `{type.ToLower()}_nachname`, `{type.ToLower()}_sperre`, `{type.ToLower()}_alter`) VALUES ({data});";
            }
            else if(type == "Club")
            {
                cmd.CommandText = $"INSERT INTO `mydb`.`{type}` (`id{type}`, `{type.ToLower()}_name`, `Trainer_idTrainer`) VALUES ({data});";
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
