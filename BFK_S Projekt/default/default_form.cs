using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BFK_S_Projekt
{
    public partial class default_form : Form
    {
        //Initialisierung aller Klassen
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
                //Laden aller Daten in die DataGridView
                dgv_spieler.DataSource = spieler.getDataToDt();
                dgv_club.DataSource = club.getData();
                dgv_trainer.DataSource = trainer.getDataToDt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_insert_spieler_Click(object sender, EventArgs e)
        {
            //Öffnen der Form durch einen Button Klick
            insert_spieler form = new insert_spieler();
            form.Show();
        }

        private void bt_insert_trainer_Click(object sender, EventArgs e)
        {
            //Öffnen der Form durch einen Button Klick
            insert_trainer form = new insert_trainer();
            form.Show();
        }

        private void bt_insert_club_Click(object sender, EventArgs e)
        {
            //Öffnen der Form durch einen Button Klick
            insert_club form = new insert_club();
            form.Show();
        }

        private void bt_update_spieler_Click(object sender, EventArgs e)
        {
            try
            {
                //Speicher der in der DataGridView Ausgewählten daten an das Form
                string[] data = new string[4];
                for (int i = 0; i < 4 ; i++)
                {
                    data[i] = dgv_spieler.SelectedRows[0].Cells[i].Value.ToString();
                }

                //Senden der Daten
                update_spieler form = new update_spieler(data, dgv_spieler.SelectedRows[0].Index);
                form.Show();
            }
            catch (Exception ex) 
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("You need to select one whole table row");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void bt_delete_spieler_Click(object sender, EventArgs e)
        {
            try
            {
                //Speichern der in der DataGridView Ausgewählten daten an das Form
                string[] data = new string[4];
                for (int i = 0; i < 3; i++)
                {
                    data[i] = dgv_spieler.SelectedRows[0].Cells[i].Value.ToString();
                }

                //Löschung der Daten durch die methode
                spieler.deleteData(data[0] + ' ' + data[1], dgv_spieler.SelectedRows[0].Index);
                default_form_Activated(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("Select the entire row you want to edit");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void bt_update_trainer_Click(object sender, EventArgs e)
        {
            try
            {
                //Speichern der in der DataGridView Ausgewählten daten an das Form
                string[] data = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    data[i] = dgv_trainer.SelectedRows[0].Cells[i].Value.ToString();
                }

                //Senden der Daten
                update_trainer form = new update_trainer(data, dgv_trainer.SelectedRows[0].Index);
                form.Show();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("Select the entire row you want to edit");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_delete_trainer_Click(object sender, EventArgs e)
        {
            try
            {
                //Senden der in der DataGridView Ausgewählten daten an das Form
                string[] data = new string[4];
                for (int i = 0; i < 3; i++)
                {
                    data[i] = dgv_trainer.SelectedRows[0].Cells[i].Value.ToString();
                }

                //Löschung der Daten durch die methode
                trainer.deleteData(data[0] + ' ' + data[1], dgv_trainer.SelectedRows[0].Index);
                default_form_Activated(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("Select the entire row you want to edit");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_update_club_Click(object sender, EventArgs e)
        {
            try
            {
                //Speichern der in der DataGridView Ausgewählten daten an das Form
                string[] data = new string[2];
                for (int i = 0; i < 2; i++)
                {
                    data[i] = dgv_club.SelectedRows[0].Cells[i].Value.ToString();
                }

                //Senden der Daten
                update_club form = new update_club(data, dgv_club.SelectedRows[0].Index);
                form.Show();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("Select the entire row you want to edit");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_delete_club_Click(object sender, EventArgs e)
        {
            try
            {
                //Senden der in der DataGridView Ausgewählten daten an das Form
                string[] data = new string[2];
                for (int i = 0; i < 2; i++)
                {
                    data[i] = dgv_club.SelectedRows[0].Cells[i].Value.ToString();
                }

                //Löschung der Daten durch die methode
                club.deleteData(data[0], dgv_club.SelectedRows[0].Index);
                default_form_Activated(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show("Select the entire row you want to edit");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}