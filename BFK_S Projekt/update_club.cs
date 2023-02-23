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
    public partial class update_club : Form
    {
        club_class club = new club_class();
        private string data;
        public update_club(string _data)
        {
            data = _data;
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            club.updateData($"club_name='{tb_name.Text}'", cb_trainer.Text, cb_trainer.SelectedIndex, )
        }

        private void update_club_Load(object sender, EventArgs e)
        {
            tb_name.Text = data;
            string[] trainer = club.getTrainer();
            foreach (string s in trainer)
            {
                cb_trainer.Items.Add(s);
            }
        }
    }
}
