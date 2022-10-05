using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prelab
{
    public partial class Profil_sayfasi : Form 
    {
        HashPass hash = new HashPass();
   
        public User user = User.LoginedUser();
      
        public Profil_sayfasi()
        {
            InitializeComponent();            
        }

        private void profil_Load(object sender, EventArgs e)
        {
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand cmd = new SqlCommand("Select ID,Username,Name,lastName,Phone,Adress,City,Country,Mail FROM [User] where Username=@Username ", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            profil_username.Text = user.Username1;
            cmd.Parameters.AddWithValue("@Username", profil_username.Text);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                IDtextbox.Text = da.GetValue(0).ToString();
                profil_username.Text = da.GetValue(1).ToString();

                profil_name.Text = da.GetValue(2).ToString();
                profil_lastname.Text = da.GetValue(3).ToString();
                profil_phone.Text = da.GetValue(4).ToString();
                profil_adres.Text = da.GetValue(5).ToString();
                profil_city.Text = da.GetValue(6).ToString();
                profil_country.Text = da.GetValue(7).ToString();
                profil_mail.Text = da.GetValue(8).ToString();
                profil_username.Enabled = false;
                IDtextbox.Enabled = false;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void profil_save_butonu_Click(object sender, EventArgs e)
        {            
            if (profil_password.Text!="")
            {
                try
                {
                    string pass = profil_password.Text;
                    string hashed = hash.ComputeSha256Hash(pass);
                    Database database = Database.CreateSingle();
                    database.GetConnection();
                    SqlCommand cmd = new SqlCommand("Update [User] set Password=@Password,Name=@Name,lastName=@lastName,Phone=@Phone,Adress=@Adress,City=@City,Country=@Country,Mail=@Mail where ID=@ID ", Database.CreateSingle().Sqlconnection );
                    Database.CreateSingle().Sqlconnection.Open();
                    cmd.Parameters.AddWithValue("@ID", int.Parse(IDtextbox.Text));
                    cmd.Parameters.AddWithValue("@Password", hashed);
                    cmd.Parameters.AddWithValue("@Name", profil_name.Text);
                    cmd.Parameters.AddWithValue("@lastName", profil_lastname.Text);
                    cmd.Parameters.AddWithValue("@Phone", profil_phone.Text);
                    cmd.Parameters.AddWithValue("@Adress", profil_adres.Text);
                    cmd.Parameters.AddWithValue("@City", profil_city.Text);
                    cmd.Parameters.AddWithValue("@Country", profil_country.Text);
                    cmd.Parameters.AddWithValue("@Mail", profil_mail.Text);

                    cmd.ExecuteNonQuery();
                    Database.CreateSingle().Sqlconnection.Close();

                    MessageBox.Show("Update Successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Update a user's information except for the username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Enter your password to Confirm changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void profil_exit_butonu_Click(object sender, EventArgs e) { this.Hide(); }

        private void profil_name_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void profil_lastName_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void profil_city_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void profil_country_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void profil_show_butonu_Click(object sender, EventArgs e)
        {
            if (profil_password.UseSystemPasswordChar == true)
            {
                profil_password.UseSystemPasswordChar = false;
                profil_show_butonu.Image = profil_image.Images[1];
            }
            else
            {
                profil_password.UseSystemPasswordChar = true;
                profil_show_butonu.Image = profil_image.Images[0];
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }
    }
}