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
    public partial class insert_trainer : Form
    {
        prop trainer = new prop("Trainer");

        public insert_trainer()
        {
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            trainer.setData($"NULL, '{tb_vorname.Text}', '{tb_nachname.Text}', {cb_sperre.SelectedItem}, '{tb_alter.Text}'");
            this.Close();
        }
    }
}
