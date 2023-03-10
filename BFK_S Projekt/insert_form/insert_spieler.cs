using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFK_S_Projekt
{
    public partial class insert_spieler : Form
    {
        //Initialisierung der Klasse
        spieler_class spieler = new spieler_class();

        public insert_spieler()
        {
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            //Setzen der Daten durch die methode
            try
            {
                spieler.setData($"NULL, '{tb_vorname.Text}', '{tb_nachname.Text}', {cb_sperre.SelectedItem}, '{tb_karten.Text}'", $"{cb_club.SelectedItem}", $"{tb_vorname.Text} {tb_nachname.Text}", cb_club.SelectedIndex);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void insert_spieler_Load(object sender, EventArgs e)
        {
            //Alle Daten werden in die Form geladen
            string[] club = spieler.getClub();
            foreach (string s in club)
            {
                cb_club.Items.Add(s);
            }
        }
    }
}
