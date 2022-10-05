using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prelab
{
    public partial class Admin_paneli : Form
    {
        HashPass hash = new HashPass();
        public Admin_paneli()
        {
            InitializeComponent();
        }
 
        private void admin_exit_Click(object sender, EventArgs e) { this.Hide(); }

        private void usernameTextBox_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void nameTextBox_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void lastNameTextBox_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void cityTextBox_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void countryTextBox_keypress(object sender, KeyPressEventArgs e)    // Sadece harf girişi için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void admin_listele_Click(object sender, EventArgs e)
        {
            Database database = Database.CreateSingle();
            database.GetConnection();
            
            SqlCommand cmd = new SqlCommand("Select * from [User]", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            userDataGridView.DataSource = dt;
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void admin_ekleme_Click(object sender, EventArgs e)
        {    
            string password = passwordTextBox.Text;
            string hashedData = hash.ComputeSha256Hash(password);
            Database database = Database.CreateSingle();
            database.GetConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Username,Password,Name,lastName,Phone,Adress,City,Country,Mail,UserType) VALUES(@Username,@Password,@Name,@lastName,@Phone,@Adress,@City,@Country,@Mail,@UserType)", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", hashedData);

            cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", phone_maskedTextBox.Text);
            cmd.Parameters.AddWithValue("@Adress", adressTextBox.Text);
            cmd.Parameters.AddWithValue("@City", cityTextBox.Text);
            cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@Mail", mailTextBox.Text);
            cmd.Parameters.AddWithValue("@UserType", userTypeTextBox.Text);

            cmd.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            MessageBox.Show("User Successfully Added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Update a user's information except for the username */
        private void admin_guncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = passwordTextBox.Text;
                string hashed = hash.ComputeSha256Hash(pass);
                Database database = Database.CreateSingle();
                database.GetConnection();
                SqlCommand cmd = new SqlCommand("Update [User] set Password=@Password,Name=@Name,lastName=@lastName,Phone=@Phone,Adress=@Adress,City=@City,Country=@Country,Mail=@Mail,UserType=@UserType where ID=@ID ", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                cmd.Parameters.AddWithValue("@ID", int.Parse(iDTextBox.Text));
                cmd.Parameters.AddWithValue("@Password", hashed);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Phone", phone_maskedTextBox.Text);
                cmd.Parameters.AddWithValue("@Adress", adressTextBox.Text);
                cmd.Parameters.AddWithValue("@City", cityTextBox.Text);
                cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
                cmd.Parameters.AddWithValue("@Mail", mailTextBox.Text);
                cmd.Parameters.AddWithValue("@UserType", userTypeTextBox.Text);

                cmd.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
                MessageBox.Show("Update Successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update a user's information except for the username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* Delete USER */
        private void admin_silme_Click(object sender, EventArgs e)
        {
            // Yes No Buttons with MessageBox
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                  
            if (dialogResult.ToString()== "Yes")
            {
                try
                {
                    Database database = Database.CreateSingle();
                    database.GetConnection();
                    SqlCommand cmd = new SqlCommand("Delete [User] where ID=@ID", Database.CreateSingle().Sqlconnection);
                    Database.CreateSingle().Sqlconnection.Open();
                    cmd.Parameters.AddWithValue("@ID", int.Parse(iDTextBox.Text));

                    cmd.ExecuteNonQuery();
                    Database.CreateSingle().Sqlconnection.Close();
                    MessageBox.Show("Delete Successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plese enter ID number to delete user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Delete Canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.Enabled = false;
            Database database = Database.CreateSingle();
            database.GetConnection();
            if (iDTextBox.Text != "") {
                SqlCommand cmd = new SqlCommand("Select * FROM [User] where ID=@ID", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                cmd.Parameters.AddWithValue("@ID", int.Parse(iDTextBox.Text));
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    usernameTextBox.Text = da.GetValue(1).ToString();
                    passwordTextBox.Text = da.GetValue(2).ToString(); ;
                    nameTextBox.Text = da.GetValue(3).ToString();
                    lastNameTextBox.Text = da.GetValue(4).ToString();
                    phone_maskedTextBox.Text = da.GetValue(5).ToString();
                    adressTextBox.Text = da.GetValue(6).ToString();
                    cityTextBox.Text = da.GetValue(7).ToString();
                    countryTextBox.Text = da.GetValue(8).ToString();
                    mailTextBox.Text = da.GetValue(9).ToString();
                    userTypeTextBox.Text = da.GetValue(10).ToString();
                }
                Database.CreateSingle().Sqlconnection.Close();
            }
            else if (iDTextBox.Text == "")
            {
                usernameTextBox.Enabled = true;
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                nameTextBox.Text = "";
                lastNameTextBox.Text = "";
                phone_maskedTextBox.Text = "";
                adressTextBox.Text = "";
                cityTextBox.Text = "";
                countryTextBox.Text = "";
                mailTextBox.Text = "";
                userTypeTextBox.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }
        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display data in TextBox when clict datagrid
            iDTextBox.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString();
        }
    }
}