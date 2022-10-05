namespace Prelab
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.sifre_butonu = new System.Windows.Forms.TextBox();
            this.giris_butonu = new System.Windows.Forms.Button();
            this.login_image = new System.Windows.Forms.ImageList(this.components);
            this.login_kayitbasligi = new System.Windows.Forms.Label();
            this.login_goster = new System.Windows.Forms.Button();
            this.label_SignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTxtbox.Location = new System.Drawing.Point(211, 69);
            this.usernameTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(159, 30);
            this.usernameTxtbox.TabIndex = 0;
            this.usernameTxtbox.Text = "Username";
            this.usernameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_username_keypress);
            // 
            // sifre_butonu
            // 
            this.sifre_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_butonu.Location = new System.Drawing.Point(211, 123);
            this.sifre_butonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_butonu.Name = "sifre_butonu";
            this.sifre_butonu.Size = new System.Drawing.Size(159, 30);
            this.sifre_butonu.TabIndex = 1;
            this.sifre_butonu.Text = "Password";
            this.sifre_butonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifre_butonu.UseSystemPasswordChar = true;
            // 
            // giris_butonu
            // 
            this.giris_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(203)))));
            this.giris_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_butonu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_butonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giris_butonu.ImageKey = "login.png";
            this.giris_butonu.ImageList = this.login_image;
            this.giris_butonu.Location = new System.Drawing.Point(211, 187);
            this.giris_butonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giris_butonu.Name = "giris_butonu";
            this.giris_butonu.Size = new System.Drawing.Size(157, 34);
            this.giris_butonu.TabIndex = 2;
            this.giris_butonu.Text = "Login";
            this.giris_butonu.UseVisualStyleBackColor = false;
            this.giris_butonu.Click += new System.EventHandler(this.giris_butonu_Click);
            // 
            // login_image
            // 
            this.login_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("login_image.ImageStream")));
            this.login_image.TransparentColor = System.Drawing.Color.Transparent;
            this.login_image.Images.SetKeyName(0, "login.png");
            this.login_image.Images.SetKeyName(1, "show.png");
            this.login_image.Images.SetKeyName(2, "hide.png");
            // 
            // login_kayitbasligi
            // 
            this.login_kayitbasligi.AutoSize = true;
            this.login_kayitbasligi.BackColor = System.Drawing.Color.Transparent;
            this.login_kayitbasligi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_kayitbasligi.Location = new System.Drawing.Point(147, 329);
            this.login_kayitbasligi.Name = "login_kayitbasligi";
            this.login_kayitbasligi.Size = new System.Drawing.Size(247, 19);
            this.login_kayitbasligi.TabIndex = 4;
            this.login_kayitbasligi.Text = "Don\'t you have an account? \r\n";
            // 
            // login_goster
            // 
            this.login_goster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(203)))));
            this.login_goster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_goster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_goster.ImageKey = "show.png";
            this.login_goster.ImageList = this.login_image;
            this.login_goster.Location = new System.Drawing.Point(395, 123);
            this.login_goster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_goster.Name = "login_goster";
            this.login_goster.Size = new System.Drawing.Size(111, 42);
            this.login_goster.TabIndex = 6;
            this.login_goster.Text = "Show";
            this.login_goster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_goster.UseVisualStyleBackColor = false;
            this.login_goster.Click += new System.EventHandler(this.login_goster_Click);
            // 
            // label_SignUp
            // 
            this.label_SignUp.AutoSize = true;
            this.label_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.label_SignUp.Font = new System.Drawing.Font("Century Gothic", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label_SignUp.Location = new System.Drawing.Point(409, 327);
            this.label_SignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SignUp.Name = "label_SignUp";
            this.label_SignUp.Size = new System.Drawing.Size(75, 22);
            this.label_SignUp.TabIndex = 8;
            this.label_SignUp.Text = "Sign Up";
            this.label_SignUp.Click += new System.EventHandler(this.label_SignUp_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.giris_butonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(617, 382);
            this.Controls.Add(this.label_SignUp);
            this.Controls.Add(this.login_goster);
            this.Controls.Add(this.login_kayitbasligi);
            this.Controls.Add(this.giris_butonu);
            this.Controls.Add(this.sifre_butonu);
            this.Controls.Add(this.usernameTxtbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.TextBox sifre_butonu;
        private System.Windows.Forms.Button giris_butonu;
        private System.Windows.Forms.Label login_kayitbasligi;
        private System.Windows.Forms.Button login_goster;
        private System.Windows.Forms.Label label_SignUp;
        private System.Windows.Forms.ImageList login_image;
    }
}