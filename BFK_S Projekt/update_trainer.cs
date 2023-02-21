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
    public partial class update_trainer : Form
    {
        trainer_class trainer = new trainer_class();
        private string[] data;
        private int index;

        public update_trainer(string[] _data, int _index)
        {
            data = _data;
            index = _index;
            InitializeComponent();
        }

        private void update_trainer_Load(object sender, EventArgs e)
        {
            trainer.transferDataToTb(data, tb_vorname, tb_nachname, cb_sperre, tb_alter);
        }

        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            trainer.updateData($"trainer_vorname='{tb_vorname.Text}', trainer_nachname='{tb_nachname.Text}', trainer_sperre={cb_sperre.Text}, trainer_alter='{tb_alter.Text}'", index, data[0] + ' ' + data[1]);
            this.Close();
        }
    }
}
