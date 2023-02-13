using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BFK_S_Projekt
{
    public partial class default_form : Form
    {
        spieler_class spieler = new spieler_class();
        club_class club = new club_class();
        trainer_class trainer = new trainer_class();

        public default_form()
        {
            InitializeComponent();
        }

        private void default_form_Activated(object sender, EventArgs e)
        {
            try
            {
                dgv_spieler.DataSource = spieler.getData();
                dgv_club.DataSource = club.getData();
                dgv_trainer.DataSource = trainer.getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_insert_spieler_Click(object sender, EventArgs e)
        {
            insert_spieler form = new insert_spieler();
            form.Show();
            Refresh();
        }

        private void bt_insert_trainer_Click(object sender, EventArgs e)
        {
            insert_trainer form = new insert_trainer();
            form.Show();
            Refresh();
        }

        private void bt_insert_club_Click(object sender, EventArgs e)
        {
            insert_club form = new insert_club();
            form.Show();
            Refresh();
        }
    }
}