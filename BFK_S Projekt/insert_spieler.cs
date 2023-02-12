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
        prop spieler = new prop("Spieler");

        public insert_spieler()
        {
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            spieler.setData($"NULL, '{tb_vorname.Text}', '{tb_nachname.Text}', '{tb_sperren.Text}', '{tb_karten.Text}'");
            this.Close();
        }
    }
}
