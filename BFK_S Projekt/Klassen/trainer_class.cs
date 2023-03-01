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
    internal class trainer_class
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
        public DataTable getDataToDt()
        {
            dt = new DataTable();
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT trainer_vorname, trainer_nachname, trainer_sperre, trainer_alter FROM mydb.trainer;";
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
        }

        //Daten werden an insert_trainer.cs Textboxen/comboboxen verteilt
        public void transferDataToTb(string[] data, TextBox vorname, TextBox nachname, ComboBox sperre, TextBox alter)
        {
            vorname.Text = data[0];
            nachname.Text = data[1];
            sperre.Text = data[2];
            alter.Text = data[3];
        }

        //Hiermit wird ein neuer Trainer auf dem MySql Server erstellt
        public void setData(string data)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO `mydb`.`Trainer` (`idTrainer`, `trainer_vorname`, `trainer_nachname`, `trainer_sperre`, `trainer_alter`) VALUES ({data});";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Updatet bisherigen Trainer
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
                cmd.CommandText = $"UPDATE Trainer SET {data} WHERE idTrainer={id};";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Löschen von Trainern
        public void deleteData(string name, int index)
        {
            int id = getId(name, index);
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM Trainer WHERE idTrainer={id};";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Returnt die Id des Trainers
        public int getId(string name, int times)
        {
            int r = 0;
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
            return r;
        }
    }
}
