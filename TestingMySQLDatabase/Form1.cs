using MySql.Data.MySqlClient;

namespace TestingMySQLDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string ConnectionString = "sever=localhost;user=root;database=world;port=3306;password=DREADhead2638!";
            MySqlConnection con = new MySqlConnection(ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Name FROM country;", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetString(0));
            }
            reader.Close();
            cmd.Dispose();
            con.Close();
        }
    }
}