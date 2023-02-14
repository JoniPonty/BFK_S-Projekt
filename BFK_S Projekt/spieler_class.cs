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
    internal class spieler_class
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

        public DataTable getDataToDt()
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from mydb.spieler";
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
            dt = new DataTable();
        }

        public void getDataToTb(string[] data, TextBox[] textBoxes)
        {
            for(int i = 0; i < data.Length; i++)
            {
                textBoxes[i].Text = data[i];
            }
        }

        public void setData(string data)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO `mydb`.`Spieler` (`idSpieler`, `spieler_vorname`, `spieler_nachname`, `spieler_sperre`, `spieler_karten`) VALUES ({data});";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateData(string data, int id)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE Spieler SET {data} WHERE idSpieler=";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
