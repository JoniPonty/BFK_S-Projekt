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
            cmd.CommandText = "SELECT spieler.spieler_vorname, spieler.spieler_nachname, spieler.spieler_sperre, spieler.spieler_karten, club.club_name FROM mydb.spieler  INNER JOIN mydb.club_has_spieler  ON spieler.idSpieler=club_has_spieler.Spieler_idSpieler INNER JOIN mydb.club ON club_has_spieler.club_idClub = club.idClub;";
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            return dt;
        }

        //Daten werden an insert_spieler.cs Textboxen/comboboxen verteilt
        public void transferDataToTb(string[] data, TextBox vorname, TextBox nachname, ComboBox sperre, TextBox karten)
        {
            vorname.Text = data[0];
            nachname.Text = data[1];
            sperre.Text = data[2];
            karten.Text = data[3];
        }

        //Hiermit wird ein neuer Spieler auf dem MySql Server erstellt
        public void setData(string spielerData, string clubData, string name, int times)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO `mydb`.`Spieler` (`idSpieler`, `spieler_vorname`, `spieler_nachname`, `spieler_sperre`, `spieler_karten`) VALUES ({spielerData});";
                cmd.ExecuteNonQuery();
                conn.Close();

                int id = getId(name, times);
                conn.Open();
                cmd.CommandText = $"SELECT idClub FROM mydb.club WHERE club_name='{clubData}';";
                sqlRd = cmd.ExecuteReader();
                sqlRd.Read();
                int clubId = sqlRd.GetInt32(0);
                sqlRd.Close();
                cmd.CommandText = $"INSERT INTO `mydb`.`Club_has_Spieler` (`idChs`, `Club_idClub`, `Spieler_idSpieler`) VALUES(NULL, {clubId}, {id});";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Updatet bisherigen spieler
        public void updateData(string dataSpieler, string dataClub, int index, string name)
        {
            int id = getId(name, index);
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if(dataClub != "")
                {
                    cmd.CommandText = $"SELECT idClub FROM mydb.club WHERE club_name='{dataClub}';";
                    sqlRd = cmd.ExecuteReader();
                    sqlRd.Read();
                    int clubId = sqlRd.GetInt32(0);
                    sqlRd.Close();
                    cmd.CommandText = $"UPDATE Spieler SET {dataSpieler} WHERE idSpieler={id}; UPDATE Club_has_Spieler SET Club_idClub={clubId} WHERE Spieler_idSpieler={id};";
                }
                else
                {
                    cmd.CommandText = $"UPDATE Spieler SET {dataSpieler} WHERE idSpieler={id};";
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

        //Löscht spieler
        public void deleteData(string name, int index)
        {
            int id = getId(name, index);
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM club_has_spieler WHERE Spieler_idSpieler={id};";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"DELETE FROM Spieler WHERE idSpieler={id};";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Id für bestimmten Spieler namen wird abgefragt. Wird benötigt um spieler zu Updaten und zu löschen.
        public int getId(string name, int times)
        {
            int r = 0;
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT idSpieler FROM mydb.spieler WHERE concat(spieler_vorname, ' ', spieler_nachname)='{name}';";
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

        //Clubname wird abgefragt
        public string[] getClub()
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" +
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT club_name FROM mydb.club;";
            sqlRd = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (sqlRd.Read())
            {
                list.Add(sqlRd.GetTextReader(0).ReadLine().ToString());
            }
            sqlRd.Close();
            conn.Close();
            return list.ToArray();
        }
    }
}
