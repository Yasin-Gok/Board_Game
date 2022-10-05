using System;
using System.Windows.Forms;

namespace Prelab
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            // Tabloya verileri yükle
            this.userTableAdapter.Fill(this.userDataSet.User);
        }

        private void exitBtn_Click(object sender, EventArgs e) { this.Hide(); }
    }
}