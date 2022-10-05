
namespace Prelab
{
    partial class Board
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.userDataSet = new Prelab.UserDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Prelab.UserDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new Prelab.UserDataSetTableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.TimerEvent);
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
            this.usernameTextBox.Location = new System.Drawing.Point(299, 230);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 22);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Visible = false;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint.Location = new System.Drawing.Point(-1, -1);
            this.lblPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoint.MaximumSize = new System.Drawing.Size(67, 16);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(43, 16);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "Point: ";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(433, 270);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.usernameTextBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Board_FormClosed);
            this.Load += new System.EventHandler(this.Board_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Board_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private UserDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label lblPoint;
    }
}