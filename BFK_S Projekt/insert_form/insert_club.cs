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
    public partial class insert_club : Form
    {
        //Initialisierung der Klasse
        club_class club = new club_class();
        public insert_club()
        {
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            //Setzen der Daten durch die methode
            try
            {
                club.setData($"NULL, '{tb_name.Text}', {club.getTrainerId(cb_trainer.SelectedItem.ToString(), cb_trainer.SelectedIndex)}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_club_Load(object sender, EventArgs e)
        {
            //Alle Daten werden in die Form geladen
            string[] trainer = club.getTrainer();
            foreach (string s in trainer)
            {
                cb_trainer.Items.Add(s);
            }
        }
    }
}
