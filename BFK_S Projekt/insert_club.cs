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
        prop club = new prop("club");
        public insert_club()
        {
            InitializeComponent();
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            
        }

        private void insert_club_Load(object sender, EventArgs e)
        {
            //string[] trainer = club.getTrainer();
            //foreach (string s in trainer)
            {
              //  cb_trainer.Text = s;
            }
        }
    }
}
