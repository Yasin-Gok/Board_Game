namespace Prelab
{
    partial class Admin_paneli
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label userTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_paneli));
            this.admin_listele = new System.Windows.Forms.Button();
            this.admin_paneli_image = new System.Windows.Forms.ImageList(this.components);
            this.admin_ekleme = new System.Windows.Forms.Button();
            this.admin_guncelleme = new System.Windows.Forms.Button();
            this.admin_silme = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new Prelab.UserDataSet();
            this.userTableAdapter = new Prelab.UserDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new Prelab.UserDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.userTypeTextBox = new System.Windows.Forms.TextBox();
            this.admin_exit = new System.Windows.Forms.Button();
            this.phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            iDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            userTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iDLabel.Location = new System.Drawing.Point(691, 31);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(32, 24);
            iDLabel.TabIndex = 6;
            iDLabel.Text = "ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            usernameLabel.Location = new System.Drawing.Point(407, 118);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(102, 24);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            passwordLabel.Location = new System.Drawing.Point(407, 150);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(97, 24);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            nameLabel.Location = new System.Drawing.Point(407, 182);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(66, 24);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lastNameLabel.Location = new System.Drawing.Point(407, 214);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(104, 24);
            lastNameLabel.TabIndex = 14;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            phoneLabel.Location = new System.Drawing.Point(407, 246);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(71, 24);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Phone:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adressLabel.Location = new System.Drawing.Point(721, 118);
            adressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(74, 24);
            adressLabel.TabIndex = 18;
            adressLabel.Text = "Adress:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cityLabel.Location = new System.Drawing.Point(721, 150);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(45, 24);
            cityLabel.TabIndex = 20;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            countryLabel.Location = new System.Drawing.Point(721, 182);
            countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(80, 24);
            countryLabel.TabIndex = 22;
            countryLabel.Text = "Country:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            mailLabel.Location = new System.Drawing.Point(721, 214);
            mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(49, 24);
            mailLabel.TabIndex = 24;
            mailLabel.Text = "Mail:";
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            userTypeLabel.Location = new System.Drawing.Point(721, 246);
            userTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new System.Drawing.Size(102, 24);
            userTypeLabel.TabIndex = 26;
            userTypeLabel.Text = "User Type:";
            // 
            // admin_listele
            // 
            this.admin_listele.BackColor = System.Drawing.Color.SpringGreen;
            this.admin_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_listele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_listele.ImageIndex = 0;
            this.admin_listele.ImageList = this.admin_paneli_image;
            this.admin_listele.Location = new System.Drawing.Point(268, 324);
            this.admin_listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_listele.Name = "admin_listele";
            this.admin_listele.Size = new System.Drawing.Size(172, 49);
            this.admin_listele.TabIndex = 3;
            this.admin_listele.Text = "List all users";
            this.admin_listele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_listele.UseVisualStyleBackColor = false;
            this.admin_listele.Click += new System.EventHandler(this.admin_listele_Click);
            // 
            // admin_paneli_image
            // 
            this.admin_paneli_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("admin_paneli_image.ImageStream")));
            this.admin_paneli_image.TransparentColor = System.Drawing.Color.Transparent;
            this.admin_paneli_image.Images.SetKeyName(0, "list.png");
            this.admin_paneli_image.Images.SetKeyName(1, "add.png");
            this.admin_paneli_image.Images.SetKeyName(2, "update.png");
            this.admin_paneli_image.Images.SetKeyName(3, "delete.png");
            this.admin_paneli_image.Images.SetKeyName(4, "exit.png");
            // 
            // admin_ekleme
            // 
            this.admin_ekleme.BackColor = System.Drawing.Color.SpringGreen;
            this.admin_ekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_ekleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_ekleme.ImageIndex = 1;
            this.admin_ekleme.ImageList = this.admin_paneli_image;
            this.admin_ekleme.Location = new System.Drawing.Point(455, 324);
            this.admin_ekleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_ekleme.Name = "admin_ekleme";
            this.admin_ekleme.Size = new System.Drawing.Size(181, 49);
            this.admin_ekleme.TabIndex = 4;
            this.admin_ekleme.Text = "Add new user";
            this.admin_ekleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_ekleme.UseVisualStyleBackColor = false;
            this.admin_ekleme.Click += new System.EventHandler(this.admin_ekleme_Click);
            // 
            // admin_guncelleme
            // 
            this.admin_guncelleme.BackColor = System.Drawing.Color.SpringGreen;
            this.admin_guncelleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_guncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_guncelleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_guncelleme.ImageIndex = 2;
            this.admin_guncelleme.ImageList = this.admin_paneli_image;
            this.admin_guncelleme.Location = new System.Drawing.Point(653, 324);
            this.admin_guncelleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_guncelleme.Name = "admin_guncelleme";
            this.admin_guncelleme.Size = new System.Drawing.Size(171, 49);
            this.admin_guncelleme.TabIndex = 5;
            this.admin_guncelleme.Text = "Update user";
            this.admin_guncelleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_guncelleme.UseVisualStyleBackColor = false;
            this.admin_guncelleme.Click += new System.EventHandler(this.admin_guncelleme_Click);
            // 
            // admin_silme
            // 
            this.admin_silme.BackColor = System.Drawing.Color.SpringGreen;
            this.admin_silme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_silme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_silme.ImageIndex = 3;
            this.admin_silme.ImageList = this.admin_paneli_image;
            this.admin_silme.Location = new System.Drawing.Point(840, 324);
            this.admin_silme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_silme.Name = "admin_silme";
            this.admin_silme.Size = new System.Drawing.Size(159, 49);
            this.admin_silme.TabIndex = 6;
            this.admin_silme.Text = "Delete user";
            this.admin_silme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_silme.UseVisualStyleBackColor = false;
            this.admin_silme.Click += new System.EventHandler(this.admin_silme_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userDataSet;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iDTextBox.Location = new System.Drawing.Point(644, 57);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(132, 29);
            this.iDTextBox.TabIndex = 7;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextBox.Location = new System.Drawing.Point(528, 114);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 29);
            this.usernameTextBox.TabIndex = 9;
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTextBox_keypress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(528, 146);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(132, 29);
            this.passwordTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.Location = new System.Drawing.Point(528, 178);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 29);
            this.nameTextBox.TabIndex = 13;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_keypress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastNameTextBox.Location = new System.Drawing.Point(528, 210);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(132, 29);
            this.lastNameTextBox.TabIndex = 15;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_keypress);
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Adress", true));
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adressTextBox.Location = new System.Drawing.Point(840, 114);
            this.adressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(132, 29);
            this.adressTextBox.TabIndex = 19;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityTextBox.Location = new System.Drawing.Point(840, 146);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(132, 29);
            this.cityTextBox.TabIndex = 21;
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityTextBox_keypress);
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Country", true));
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countryTextBox.Location = new System.Drawing.Point(840, 178);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(132, 29);
            this.countryTextBox.TabIndex = 23;
            this.countryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countryTextBox_keypress);
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Mail", true));
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTextBox.Location = new System.Drawing.Point(840, 210);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(132, 29);
            this.mailTextBox.TabIndex = 25;
            // 
            // userTypeTextBox
            // 
            this.userTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserType", true));
            this.userTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userTypeTextBox.Location = new System.Drawing.Point(840, 242);
            this.userTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userTypeTextBox.Name = "userTypeTextBox";
            this.userTypeTextBox.Size = new System.Drawing.Size(132, 29);
            this.userTypeTextBox.TabIndex = 27;
            // 
            // admin_exit
            // 
            this.admin_exit.BackColor = System.Drawing.Color.SpringGreen;
            this.admin_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_exit.ImageKey = "exit.png";
            this.admin_exit.ImageList = this.admin_paneli_image;
            this.admin_exit.Location = new System.Drawing.Point(1019, 324);
            this.admin_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_exit.Name = "admin_exit";
            this.admin_exit.Size = new System.Drawing.Size(93, 49);
            this.admin_exit.TabIndex = 1;
            this.admin_exit.Text = "Exit";
            this.admin_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_exit.UseVisualStyleBackColor = false;
            this.admin_exit.Click += new System.EventHandler(this.admin_exit_Click);
            // 
            // phone_maskedTextBox
            // 
            this.phone_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone_maskedTextBox.Location = new System.Drawing.Point(528, 242);
            this.phone_maskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_maskedTextBox.Mask = "(999) 000-0000";
            this.phone_maskedTextBox.Name = "phone_maskedTextBox";
            this.phone_maskedTextBox.Size = new System.Drawing.Size(132, 28);
            this.phone_maskedTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "About";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(0, 452);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.Size = new System.Drawing.Size(1409, 286);
            this.userDataGridView.TabIndex = 30;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 45F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.FillWeight = 75F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.FillWeight = 75F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn5.FillWeight = 75F;
            this.dataGridViewTextBoxColumn5.HeaderText = "lastName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn7.FillWeight = 130F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn8.FillWeight = 80F;
            this.dataGridViewTextBoxColumn8.HeaderText = "City";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn9.FillWeight = 80F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Country";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "UserType";
            this.dataGridViewTextBoxColumn11.FillWeight = 70F;
            this.dataGridViewTextBoxColumn11.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 70;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Point";
            this.dataGridViewTextBoxColumn12.FillWeight = 50F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Point";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Admin_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1404, 732);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_maskedTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
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
            this.Controls.Add(userTypeLabel);
            this.Controls.Add(this.userTypeTextBox);
            this.Controls.Add(this.admin_silme);
            this.Controls.Add(this.admin_guncelleme);
            this.Controls.Add(this.admin_ekleme);
            this.Controls.Add(this.admin_listele);
            this.Controls.Add(this.admin_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_paneli";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button admin_listele;
        private System.Windows.Forms.Button admin_ekleme;
        private System.Windows.Forms.Button admin_guncelleme;
        private System.Windows.Forms.Button admin_silme;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private UserDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox userTypeTextBox;
        private System.Windows.Forms.Button admin_exit;
        private System.Windows.Forms.MaskedTextBox phone_maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList admin_paneli_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}