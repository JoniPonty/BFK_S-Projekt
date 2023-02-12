using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BFK_S_Projekt
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        MySqlDataAdapter Dta = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet ds = new DataSet();

        String server = "localhost";
        String username = "root";
        String database = "championsleague";

        public Form1()
        {
            InitializeComponent();
        }

        private void uploadData(string Data, DataGridView dgv)
        {
            conn.ConnectionString = "server=" + server + ";" +
                "username=" + username + ";" + 
                "database=" + database;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = Data;
            sqlRd = cmd.ExecuteReader();
            dt.Load(sqlRd);
            sqlRd.Close();
            conn.Close();
            dgv.DataSource = dt;
            dt = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                uploadData("select * from championsleague.spieler", dgv_spieler);
                uploadData("select * from championsleague.club", dgv_club);
                uploadData("select * from championsleague.trainer", dgv_trainer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}