namespace Prelab
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.kayit_signin = new System.Windows.Forms.Button();
            this.kayit_exit = new System.Windows.Forms.Button();
            this.kayit_sifre_goster = new System.Windows.Forms.Button();
            this.register_image = new System.Windows.Forms.ImageList(this.components);
            this.userDataSet = new Prelab.UserDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Prelab.UserDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new Prelab.UserDataSetTableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kayit_phone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            usernameLabel.Location = new System.Drawing.Point(361, 140);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(91, 20);
            usernameLabel.TabIndex = 26;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            passwordLabel.Location = new System.Drawing.Point(361, 172);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(88, 20);
            passwordLabel.TabIndex = 28;
            passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            nameLabel.Location = new System.Drawing.Point(72, 140);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(58, 20);
            nameLabel.TabIndex = 30;
            nameLabel.Text = "Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lastNameLabel.Location = new System.Drawing.Point(72, 172);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(96, 20);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            phoneLabel.Location = new System.Drawing.Point(72, 204);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(61, 20);
            phoneLabel.TabIndex = 34;
            phoneLabel.Text = "Phone:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adressLabel.Location = new System.Drawing.Point(72, 236);
            adressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(76, 20);
            adressLabel.TabIndex = 36;
            adressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cityLabel.Location = new System.Drawing.Point(72, 268);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(43, 20);
            cityLabel.TabIndex = 38;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            countryLabel.Location = new System.Drawing.Point(72, 300);
            countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(72, 20);
            countryLabel.TabIndex = 40;
            countryLabel.Text = "Country:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            mailLabel.Location = new System.Drawing.Point(72, 332);
            mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(45, 20);
            mailLabel.TabIndex = 42;
            mailLabel.Text = "Mail:";
            // 
            // kayit_signin
            // 
            this.kayit_signin.BackColor = System.Drawing.Color.Gold;
            this.kayit_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_signin.Location = new System.Drawing.Point(493, 316);
            this.kayit_signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayit_signin.Name = "kayit_signin";
            this.kayit_signin.Size = new System.Drawing.Size(108, 36);
            this.kayit_signin.TabIndex = 19;
            this.kayit_signin.Text = "Sign in";
            this.kayit_signin.UseVisualStyleBackColor = false;
            this.kayit_signin.Click += new System.EventHandler(this.kayit_signin_Click);
            // 
            // kayit_exit
            // 
            this.kayit_exit.BackColor = System.Drawing.Color.Gold;
            this.kayit_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.kayit_exit.Location = new System.Drawing.Point(607, 316);
            this.kayit_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayit_exit.Name = "kayit_exit";
            this.kayit_exit.Size = new System.Drawing.Size(76, 36);
            this.kayit_exit.TabIndex = 20;
            this.kayit_exit.Text = "Exit";
            this.kayit_exit.UseVisualStyleBackColor = false;
            this.kayit_exit.Click += new System.EventHandler(this.kayit_exit_Click);
            // 
            // kayit_sifre_goster
            // 
            this.kayit_sifre_goster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_sifre_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_sifre_goster.ImageKey = "show.png";
            this.kayit_sifre_goster.ImageList = this.register_image;
            this.kayit_sifre_goster.Location = new System.Drawing.Point(620, 169);
            this.kayit_sifre_goster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayit_sifre_goster.Name = "kayit_sifre_goster";
            this.kayit_sifre_goster.Size = new System.Drawing.Size(61, 27);
            this.kayit_sifre_goster.TabIndex = 24;
            this.kayit_sifre_goster.UseVisualStyleBackColor = true;
            this.kayit_sifre_goster.Click += new System.EventHandler(this.kayit_sifre_goster_Click);
            // 
            // register_image
            // 
            this.register_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("register_image.ImageStream")));
            this.register_image.TransparentColor = System.Drawing.Color.Transparent;
            this.register_image.Images.SetKeyName(0, "show.png");
            this.register_image.Images.SetKeyName(1, "hide.png");
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Prelab.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextBox.Location = new System.Drawing.Point(468, 137);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 26);
            this.usernameTextBox.TabIndex = 27;
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTextBox_keypress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(468, 169);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(132, 26);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.Location = new System.Drawing.Point(176, 137);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 26);
            this.nameTextBox.TabIndex = 31;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayit_name_keypress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastNameTextBox.Location = new System.Drawing.Point(176, 169);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(132, 26);
            this.lastNameTextBox.TabIndex = 33;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayit_surname_keypress);
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Adress", true));
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adressTextBox.Location = new System.Drawing.Point(176, 233);
            this.adressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(132, 26);
            this.adressTextBox.TabIndex = 37;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityTextBox.Location = new System.Drawing.Point(176, 265);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(132, 26);
            this.cityTextBox.TabIndex = 39;
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayit_city_keypress);
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Country", true));
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countryTextBox.Location = new System.Drawing.Point(176, 297);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(132, 26);
            this.countryTextBox.TabIndex = 41;
            this.countryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kayit_country_keypress);
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Mail", true));
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTextBox.Location = new System.Drawing.Point(176, 329);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(132, 26);
            this.mailTextBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(257, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 60);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sign Up";
            // 
            // kayit_phone
            // 
            this.kayit_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_phone.Location = new System.Drawing.Point(176, 202);
            this.kayit_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayit_phone.Mask = "(999) 000-0000";
            this.kayit_phone.Name = "kayit_phone";
            this.kayit_phone.Size = new System.Drawing.Size(133, 28);
            this.kayit_phone.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "About";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(741, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kayit_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.kayit_sifre_goster);
            this.Controls.Add(this.kayit_exit);
            this.Controls.Add(this.kayit_signin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayit_signin;
        private System.Windows.Forms.Button kayit_exit;
        private System.Windows.Forms.Button kayit_sifre_goster;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private UserDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox kayit_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList register_image;
    }
}