using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prelab
{
    public partial class Login : Form
    {
        public User user = User.LoginedUser();
         
        public Login()
        {
            InitializeComponent();
        }             

        public void giris_butonu_Click(object sender, EventArgs e)
        {
            user.Username1 = usernameTxtbox.Text;

            HashPass hash = new HashPass();
            string password = sifre_butonu.Text;
            string hashedData = hash.ComputeSha256Hash(password);

            Database database = Database.CreateSingle();
            database.GetConnection();
            
            SqlCommand cmd = new SqlCommand("SELECT UserType FROM [User] WHERE Username='" + usernameTxtbox.Text + "' AND Password='" + hashedData + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            SqlDataReader da = cmd.ExecuteReader();

                if (dt.Rows.Count == 1)
                {
                Properties.Settings.Default.User = usernameTxtbox.Text;
                Properties.Settings.Default.Save();

                switch (dt.Rows[0]["UserType"] as string)         // Girilen kullanıcı tipine göre sayfa açıyor
                      {
                        case "Admin":
                            AdminMainMenu yeniform = new AdminMainMenu();
                            yeniform.Show();
                            this.Hide();
                            break;

                        case "User":
                            MainMenu userform = new MainMenu();
                            userform.Show();
                            this.Hide();
                            break;

                        default:
                        MainMenu userform1 = new MainMenu();
                        userform1.Show();
                        this.Hide();
                        break;
                       }
                }
                else { MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void login_kayit_butonu_Click(object sender, EventArgs e)
        {
            Register yeni = new Register();
            yeni.Show();
        }

        private void login_goster_Click(object sender, EventArgs e)
        {
            if (sifre_butonu.UseSystemPasswordChar == true)
            {
                sifre_butonu.UseSystemPasswordChar = false;
                login_goster.Text = "Hide";
                login_goster.Image = login_image.Images[2];
            }
            else
            {
                sifre_butonu.UseSystemPasswordChar = true;
                login_goster.Text = "Show";
                login_goster.Image = login_image.Images[1];
            }
        }

        private void login_username_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Login_Load(object sender, EventArgs e)
        {   
            usernameTxtbox.Text = Properties.Settings.Default.User.ToString();
        }

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            Register yeni = new Register();
            yeni.Show();
        }
    }
}