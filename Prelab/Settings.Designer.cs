namespace Prelab
{
    partial class Settings
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
            this.easy_butonu = new System.Windows.Forms.RadioButton();
            this.normal_butonu = new System.Windows.Forms.RadioButton();
            this.hard_butonu = new System.Windows.Forms.RadioButton();
            this.custom_butonu = new System.Windows.Forms.RadioButton();
            this.zorluk_grubu = new System.Windows.Forms.GroupBox();
            this.customBox2 = new System.Windows.Forms.TextBox();
            this.customBox = new System.Windows.Forms.TextBox();
            this.kare = new System.Windows.Forms.CheckBox();
            this.ucgen = new System.Windows.Forms.CheckBox();
            this.yuvarlak = new System.Windows.Forms.CheckBox();
            this.sekil_grubu = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.colorGroup = new System.Windows.Forms.GroupBox();
            this.blueBox = new System.Windows.Forms.CheckBox();
            this.redBox = new System.Windows.Forms.CheckBox();
            this.yellowBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zorluk_grubu.SuspendLayout();
            this.sekil_grubu.SuspendLayout();
            this.colorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // easy_butonu
            // 
            this.easy_butonu.AutoSize = true;
            this.easy_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.easy_butonu.Location = new System.Drawing.Point(4, 24);
            this.easy_butonu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.easy_butonu.Name = "easy_butonu";
            this.easy_butonu.Size = new System.Drawing.Size(62, 24);
            this.easy_butonu.TabIndex = 0;
            this.easy_butonu.TabStop = true;
            this.easy_butonu.Text = "Easy";
            this.easy_butonu.UseVisualStyleBackColor = true;
            this.easy_butonu.CheckedChanged += new System.EventHandler(this.easy_butonu_CheckedChanged);
            // 
            // normal_butonu
            // 
            this.normal_butonu.AutoSize = true;
            this.normal_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.normal_butonu.Location = new System.Drawing.Point(4, 53);
            this.normal_butonu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.normal_butonu.Name = "normal_butonu";
            this.normal_butonu.Size = new System.Drawing.Size(77, 24);
            this.normal_butonu.TabIndex = 1;
            this.normal_butonu.TabStop = true;
            this.normal_butonu.Text = "Normal";
            this.normal_butonu.UseVisualStyleBackColor = true;
            this.normal_butonu.CheckedChanged += new System.EventHandler(this.normal_butonu_CheckedChanged);
            // 
            // hard_butonu
            // 
            this.hard_butonu.AutoSize = true;
            this.hard_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hard_butonu.Location = new System.Drawing.Point(4, 81);
            this.hard_butonu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hard_butonu.Name = "hard_butonu";
            this.hard_butonu.Size = new System.Drawing.Size(62, 24);
            this.hard_butonu.TabIndex = 2;
            this.hard_butonu.TabStop = true;
            this.hard_butonu.Text = "Hard";
            this.hard_butonu.UseVisualStyleBackColor = true;
            this.hard_butonu.CheckedChanged += new System.EventHandler(this.hard_butonu_CheckedChanged);
            // 
            // custom_butonu
            // 
            this.custom_butonu.AutoSize = true;
            this.custom_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.custom_butonu.Location = new System.Drawing.Point(4, 110);
            this.custom_butonu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.custom_butonu.Name = "custom_butonu";
            this.custom_butonu.Size = new System.Drawing.Size(82, 24);
            this.custom_butonu.TabIndex = 3;
            this.custom_butonu.TabStop = true;
            this.custom_butonu.Text = "Custom";
            this.custom_butonu.UseVisualStyleBackColor = true;
            this.custom_butonu.CheckedChanged += new System.EventHandler(this.custom_butonu_CheckedChanged);
            // 
            // zorluk_grubu
            // 
            this.zorluk_grubu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.zorluk_grubu.Controls.Add(this.customBox2);
            this.zorluk_grubu.Controls.Add(this.customBox);
            this.zorluk_grubu.Controls.Add(this.custom_butonu);
            this.zorluk_grubu.Controls.Add(this.hard_butonu);
            this.zorluk_grubu.Controls.Add(this.normal_butonu);
            this.zorluk_grubu.Controls.Add(this.easy_butonu);
            this.zorluk_grubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zorluk_grubu.Location = new System.Drawing.Point(75, 75);
            this.zorluk_grubu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zorluk_grubu.Name = "zorluk_grubu";
            this.zorluk_grubu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zorluk_grubu.Size = new System.Drawing.Size(136, 162);
            this.zorluk_grubu.TabIndex = 4;
            this.zorluk_grubu.TabStop = false;
            this.zorluk_grubu.Text = "Difficulty";
            // 
            // customBox2
            // 
            this.customBox2.AcceptsReturn = true;
            this.customBox2.Location = new System.Drawing.Point(53, 132);
            this.customBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customBox2.Name = "customBox2";
            this.customBox2.Size = new System.Drawing.Size(33, 26);
            this.customBox2.TabIndex = 5;
            this.customBox2.Visible = false;
            this.customBox2.TextChanged += new System.EventHandler(this.customBox2_TextChanged);
            // 
            // customBox
            // 
            this.customBox.AcceptsReturn = true;
            this.customBox.Location = new System.Drawing.Point(13, 132);
            this.customBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customBox.Name = "customBox";
            this.customBox.Size = new System.Drawing.Size(33, 26);
            this.customBox.TabIndex = 4;
            this.customBox.Visible = false;
            this.customBox.TextChanged += new System.EventHandler(this.customBox_TextChanged);
            // 
            // kare
            // 
            this.kare.AutoSize = true;
            this.kare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kare.Location = new System.Drawing.Point(35, 47);
            this.kare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(80, 24);
            this.kare.TabIndex = 4;
            this.kare.Text = "Square";
            this.kare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kare.UseVisualStyleBackColor = true;
            this.kare.CheckedChanged += new System.EventHandler(this.kare_CheckedChanged);
            // 
            // ucgen
            // 
            this.ucgen.AutoSize = true;
            this.ucgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucgen.Location = new System.Drawing.Point(35, 76);
            this.ucgen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucgen.Name = "ucgen";
            this.ucgen.Size = new System.Drawing.Size(84, 24);
            this.ucgen.TabIndex = 5;
            this.ucgen.Text = "Triangle";
            this.ucgen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucgen.UseVisualStyleBackColor = true;
            this.ucgen.CheckedChanged += new System.EventHandler(this.ucgen_CheckedChanged);
            // 
            // yuvarlak
            // 
            this.yuvarlak.AutoSize = true;
            this.yuvarlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuvarlak.Location = new System.Drawing.Point(35, 105);
            this.yuvarlak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yuvarlak.Name = "yuvarlak";
            this.yuvarlak.Size = new System.Drawing.Size(76, 24);
            this.yuvarlak.TabIndex = 6;
            this.yuvarlak.Text = "Round";
            this.yuvarlak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yuvarlak.UseVisualStyleBackColor = true;
            this.yuvarlak.CheckedChanged += new System.EventHandler(this.yuvarlak_CheckedChanged);
            // 
            // sekil_grubu
            // 
            this.sekil_grubu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.sekil_grubu.Controls.Add(this.yuvarlak);
            this.sekil_grubu.Controls.Add(this.ucgen);
            this.sekil_grubu.Controls.Add(this.kare);
            this.sekil_grubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekil_grubu.Location = new System.Drawing.Point(268, 75);
            this.sekil_grubu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sekil_grubu.Name = "sekil_grubu";
            this.sekil_grubu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sekil_grubu.Size = new System.Drawing.Size(137, 162);
            this.sekil_grubu.TabIndex = 7;
            this.sekil_grubu.TabStop = false;
            this.sekil_grubu.Text = "Shape";
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(544, 289);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(59, 32);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.Location = new System.Drawing.Point(466, 289);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(59, 32);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // colorGroup
            // 
            this.colorGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.colorGroup.Controls.Add(this.blueBox);
            this.colorGroup.Controls.Add(this.redBox);
            this.colorGroup.Controls.Add(this.yellowBox);
            this.colorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorGroup.Location = new System.Drawing.Point(466, 75);
            this.colorGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorGroup.Name = "colorGroup";
            this.colorGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorGroup.Size = new System.Drawing.Size(137, 162);
            this.colorGroup.TabIndex = 10;
            this.colorGroup.TabStop = false;
            this.colorGroup.Text = "Color";
            // 
            // blueBox
            // 
            this.blueBox.AutoSize = true;
            this.blueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blueBox.Location = new System.Drawing.Point(35, 105);
            this.blueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(60, 24);
            this.blueBox.TabIndex = 6;
            this.blueBox.Text = "Blue";
            this.blueBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blueBox.UseVisualStyleBackColor = true;
            this.blueBox.CheckedChanged += new System.EventHandler(this.blueBox_CheckedChanged);
            // 
            // redBox
            // 
            this.redBox.AutoSize = true;
            this.redBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.redBox.Location = new System.Drawing.Point(35, 76);
            this.redBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(58, 24);
            this.redBox.TabIndex = 5;
            this.redBox.Text = "Red";
            this.redBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.redBox.UseVisualStyleBackColor = true;
            // 
            // yellowBox
            // 
            this.yellowBox.AutoSize = true;
            this.yellowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yellowBox.Location = new System.Drawing.Point(35, 47);
            this.yellowBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(74, 24);
            this.yellowBox.TabIndex = 4;
            this.yellowBox.Text = "Yellow";
            this.yellowBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yellowBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "About";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(667, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorGroup);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sekil_grubu);
            this.Controls.Add(this.zorluk_grubu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.zorluk_grubu.ResumeLayout(false);
            this.zorluk_grubu.PerformLayout();
            this.sekil_grubu.ResumeLayout(false);
            this.sekil_grubu.PerformLayout();
            this.colorGroup.ResumeLayout(false);
            this.colorGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton easy_butonu;
        private System.Windows.Forms.RadioButton normal_butonu;
        private System.Windows.Forms.RadioButton hard_butonu;
        private System.Windows.Forms.RadioButton custom_butonu;
        private System.Windows.Forms.GroupBox zorluk_grubu;
        private System.Windows.Forms.CheckBox kare;
        private System.Windows.Forms.CheckBox ucgen;
        private System.Windows.Forms.CheckBox yuvarlak;
        private System.Windows.Forms.GroupBox sekil_grubu;
        private System.Windows.Forms.TextBox customBox;
        private System.Windows.Forms.TextBox customBox2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox colorGroup;
        private System.Windows.Forms.CheckBox blueBox;
        private System.Windows.Forms.CheckBox redBox;
        private System.Windows.Forms.CheckBox yellowBox;
        private System.Windows.Forms.Label label1;
    }
}