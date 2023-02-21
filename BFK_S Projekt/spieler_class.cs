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
            dt = new DataTable();
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT spieler_vorname, spieler_nachname, spieler_sperre, spieler_karten FROM mydb.spieler";
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
        }

        public void transferDataToTb(string[] data, TextBox vorname, TextBox nachname, ComboBox sperre, TextBox karten)
        {
            vorname.Text = data[0];
            nachname.Text = data[1];
            sperre.Text = data[2];
            karten.Text = data[3];
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

        public void updateData(string data, int index, string name)
        {
            int id = getId(name, index);
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE Spieler SET {data} WHERE idSpieler={id}";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteData(string name, int index)
        {
            int id = getId(name, index);
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM Spieler WHERE idSpieler={id}";
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
            cmd.CommandText = $"SELECT idSpieler FROM mydb.spieler WHERE concat(spieler_vorname, ' ', spieler_nachname)='{name}'";
            sqlRd = cmd.ExecuteReader();
            for (int i = 0; i < times + 1; i++)
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
