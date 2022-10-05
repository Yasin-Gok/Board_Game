using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prelab
{
    public partial class UserProfilSave : Form
    {
        public UserProfilSave()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashPass hash = new HashPass();
            string password = passwordTextBox.Text;
            string hashedData = hash.ComputeSha256Hash(password);

            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand cmd = new SqlCommand("SELECT UserType FROM [User] WHERE Username='" + usernameTextBox.Text + "' AND Password='" + hashedData + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            SqlDataReader da = cmd.ExecuteReader();

            if (dt.Rows.Count == 1)
            {   
                this.Hide();                                   
            }
            else { MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }
    }
}