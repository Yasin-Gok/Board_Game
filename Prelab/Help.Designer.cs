namespace Prelab
{
    partial class Help
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
            this.help_baslik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.help_usage_butonu = new System.Windows.Forms.Button();
            this.help_comp_butonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help_baslik
            // 
            this.help_baslik.AutoSize = true;
            this.help_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help_baslik.ForeColor = System.Drawing.Color.Blue;
            this.help_baslik.Location = new System.Drawing.Point(239, 23);
            this.help_baslik.Name = "help_baslik";
            this.help_baslik.Size = new System.Drawing.Size(208, 38);
            this.help_baslik.TabIndex = 0;
            this.help_baslik.Text = "Help Screen";
            this.help_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(549, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "About";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // help_usage_butonu
            // 
            this.help_usage_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help_usage_butonu.Location = new System.Drawing.Point(274, 90);
            this.help_usage_butonu.Name = "help_usage_butonu";
            this.help_usage_butonu.Size = new System.Drawing.Size(130, 54);
            this.help_usage_butonu.TabIndex = 8;
            this.help_usage_butonu.Text = "Usage of the game";
            this.help_usage_butonu.UseVisualStyleBackColor = true;
            this.help_usage_butonu.Click += new System.EventHandler(this.help_usage_butonu_Click);
            // 
            // help_comp_butonu
            // 
            this.help_comp_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help_comp_butonu.Location = new System.Drawing.Point(274, 168);
            this.help_comp_butonu.Name = "help_comp_butonu";
            this.help_comp_butonu.Size = new System.Drawing.Size(130, 54);
            this.help_comp_butonu.TabIndex = 9;
            this.help_comp_butonu.Text = "Game components";
            this.help_comp_butonu.UseVisualStyleBackColor = true;
            this.help_comp_butonu.Click += new System.EventHandler(this.help_comp_butonu_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(662, 364);
            this.Controls.Add(this.help_comp_butonu);
            this.Controls.Add(this.help_usage_butonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.help_baslik);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label help_baslik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button help_usage_butonu;
        private System.Windows.Forms.Button help_comp_butonu;
    }
}