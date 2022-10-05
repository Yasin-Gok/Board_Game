namespace Prelab
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.form2_baslik = new System.Windows.Forms.Label();
            this.form2_play = new System.Windows.Forms.Button();
            this.menu_image = new System.Windows.Forms.ImageList(this.components);
            this.form2_settings = new System.Windows.Forms.Button();
            this.form2_exit = new System.Windows.Forms.Button();
            this.menu_profil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.main_logout = new System.Windows.Forms.Button();
            this.menu_help_butonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form2_baslik
            // 
            this.form2_baslik.AutoSize = true;
            this.form2_baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.form2_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.form2_baslik.Location = new System.Drawing.Point(213, 62);
            this.form2_baslik.Name = "form2_baslik";
            this.form2_baslik.Size = new System.Drawing.Size(246, 46);
            this.form2_baslik.TabIndex = 0;
            this.form2_baslik.Text = "Board Game";
            this.form2_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form2_play
            // 
            this.form2_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2_play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.form2_play.ImageKey = "play.png";
            this.form2_play.ImageList = this.menu_image;
            this.form2_play.Location = new System.Drawing.Point(263, 134);
            this.form2_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form2_play.Name = "form2_play";
            this.form2_play.Size = new System.Drawing.Size(158, 41);
            this.form2_play.TabIndex = 1;
            this.form2_play.Text = "Play";
            this.form2_play.UseVisualStyleBackColor = true;
            this.form2_play.Click += new System.EventHandler(this.form2_play_Click);
            // 
            // menu_image
            // 
            this.menu_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menu_image.ImageStream")));
            this.menu_image.TransparentColor = System.Drawing.Color.Transparent;
            this.menu_image.Images.SetKeyName(0, "play.png");
            this.menu_image.Images.SetKeyName(1, "settings.png");
            this.menu_image.Images.SetKeyName(2, "exit.png");
            this.menu_image.Images.SetKeyName(3, "profile.png");
            this.menu_image.Images.SetKeyName(4, "logout.png");
            this.menu_image.Images.SetKeyName(5, "help.png");
            // 
            // form2_settings
            // 
            this.form2_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.form2_settings.ImageKey = "settings.png";
            this.form2_settings.ImageList = this.menu_image;
            this.form2_settings.Location = new System.Drawing.Point(263, 190);
            this.form2_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form2_settings.Name = "form2_settings";
            this.form2_settings.Size = new System.Drawing.Size(158, 37);
            this.form2_settings.TabIndex = 2;
            this.form2_settings.Text = "Settings";
            this.form2_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.form2_settings.UseVisualStyleBackColor = true;
            this.form2_settings.Click += new System.EventHandler(this.form2_settings_Click);
            // 
            // form2_exit
            // 
            this.form2_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.form2_exit.ImageKey = "exit.png";
            this.form2_exit.ImageList = this.menu_image;
            this.form2_exit.Location = new System.Drawing.Point(263, 242);
            this.form2_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form2_exit.Name = "form2_exit";
            this.form2_exit.Size = new System.Drawing.Size(158, 38);
            this.form2_exit.TabIndex = 3;
            this.form2_exit.Text = "Exit Game";
            this.form2_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.form2_exit.UseVisualStyleBackColor = true;
            this.form2_exit.Click += new System.EventHandler(this.form2_exit_Click);
            // 
            // menu_profil
            // 
            this.menu_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_profil.ImageKey = "profile.png";
            this.menu_profil.ImageList = this.menu_image;
            this.menu_profil.Location = new System.Drawing.Point(551, 11);
            this.menu_profil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu_profil.Name = "menu_profil";
            this.menu_profil.Size = new System.Drawing.Size(100, 97);
            this.menu_profil.TabIndex = 5;
            this.menu_profil.Text = "Profile";
            this.menu_profil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_profil.UseVisualStyleBackColor = true;
            this.menu_profil.Click += new System.EventHandler(this.menu_profil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "About";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_logout
            // 
            this.main_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.main_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_logout.ImageKey = "logout.png";
            this.main_logout.ImageList = this.menu_image;
            this.main_logout.Location = new System.Drawing.Point(531, 345);
            this.main_logout.Name = "main_logout";
            this.main_logout.Size = new System.Drawing.Size(120, 38);
            this.main_logout.TabIndex = 7;
            this.main_logout.Text = "Logout";
            this.main_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.main_logout.UseVisualStyleBackColor = true;
            this.main_logout.Click += new System.EventHandler(this.main_logout_Click);
            // 
            // menu_help_butonu
            // 
            this.menu_help_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_help_butonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_help_butonu.ImageKey = "help.png";
            this.menu_help_butonu.ImageList = this.menu_image;
            this.menu_help_butonu.Location = new System.Drawing.Point(12, 345);
            this.menu_help_butonu.Name = "menu_help_butonu";
            this.menu_help_butonu.Size = new System.Drawing.Size(120, 38);
            this.menu_help_butonu.TabIndex = 8;
            this.menu_help_butonu.Text = "Help";
            this.menu_help_butonu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_help_butonu.UseVisualStyleBackColor = true;
            this.menu_help_butonu.Click += new System.EventHandler(this.menu_help_butonu_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(663, 395);
            this.Controls.Add(this.menu_help_butonu);
            this.Controls.Add(this.main_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_profil);
            this.Controls.Add(this.form2_exit);
            this.Controls.Add(this.form2_settings);
            this.Controls.Add(this.form2_play);
            this.Controls.Add(this.form2_baslik);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form2_baslik;
        private System.Windows.Forms.Button form2_play;
        private System.Windows.Forms.Button form2_settings;
        private System.Windows.Forms.Button form2_exit;
        private System.Windows.Forms.Button menu_profil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button main_logout;
        private System.Windows.Forms.ImageList menu_image;
        private System.Windows.Forms.Button menu_help_butonu;
    }
}