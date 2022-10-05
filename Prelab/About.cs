using System;
using System.Windows.Forms;

namespace Prelab
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { Close(); }

        private void About_Load(object sender, EventArgs e) { TopMost = true; }
    }
}