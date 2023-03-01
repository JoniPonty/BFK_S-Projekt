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
    public partial class update_spieler : Form
    {
        //Initialisierung der Klasse
        spieler_class spieler = new spieler_class();
        //Definierung der Globalen Variablen
        private string[] data;
        private int index;
        public update_spieler(string[] _data, int _index)
        {
            data = _data;
            index = _index;
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            //Update der Daten durch die methode
            spieler.updateData($"spieler_vorname='{tb_vorname.Text}', spieler_nachname='{tb_nachname.Text}', spieler_sperre={cb_sperre.Text}, spieler_karten='{tb_karten.Text}'",cb_club.Text, index, data[0] + ' ' + data[1]);
            this.Close();
        }

        private void update_spieler_Load(object sender, EventArgs e)
        {
            spieler.transferDataToTb(data, tb_vorname, tb_nachname, cb_sperre, tb_karten);

            string[] club = spieler.getClub();
            foreach (string s in club)
            {
                cb_club.Items.Add(s);
            }
        }
    }
}
