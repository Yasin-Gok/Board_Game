using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prelab
{
    public partial class Register : Form
    {
        static int ID = 4;
        public int MyID
        {
            get => ID;
            set => ID = value;
        }
        
        public Register()
        {
            InitializeComponent();
        }

        private void kayit_signin_Click(object sender, EventArgs e)
        {
            string userType = "User";

            Database database = Database.CreateSingle();
            database.GetConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Username,Password,Name,lastName,Phone,Adress,City,Country,Mail,UserType) VALUES(@Username,@Password,@Name,@lastName,@Phone,@Adress,@City,@Country,@Mail,@UserType)", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            HashPass hash = new HashPass();
            string password = passwordTextBox.Text;
            string hashpass= hash.ComputeSha256Hash(password);

            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", hashpass);

            cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", kayit_phone.Text);
            cmd.Parameters.AddWithValue("@Adress", adressTextBox.Text);
            cmd.Parameters.AddWithValue("@City", cityTextBox.Text);
            cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@Mail", mailTextBox.Text);
            cmd.Parameters.AddWithValue("@UserType", userType);

            cmd.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            MessageBox.Show("User Successfully Added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kayit_exit_Click(object sender, EventArgs e) { this.Hide(); }

        private void kayit_sifre_goster_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                kayit_sifre_goster.Image = register_image.Images[1];
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                kayit_sifre_goster.Image = register_image.Images[0];
            }
        }

        private void kayit_name_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void kayit_surname_keypress(object sender, KeyPressEventArgs e)     // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void kayit_city_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void kayit_country_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void usernameTextBox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        public bool Text_kontrol(TextBox t)
        {
            if (t.Text == "")       // Boş mu diye kontrol ediyoruz.
            {
                MessageBox.Show("Fill in the blank fields!", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else { return false; }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }
    }
}