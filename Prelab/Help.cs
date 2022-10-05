using System;
using System.Windows.Forms;

namespace Prelab
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { Close(); }

        private void label1_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }

        private void help_usage_butonu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Controls: \n\n" + "Select Shape with mouse click.\n\n"
                + "Move Shape with W A S D keys.\n\n" + "Press space to drop shape.\n\n" + "Press 'Q' to quit.");
        }

        private void help_comp_butonu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are 3 different shape, color and 4 different difficulty\n\n" +
                "You must select 1 difficulty level for board size\n\n" + "You can select 1-3 shape or color\n\n" +
                "Also It will come to you randomly according to the colors and shapes you choose.\n\n" +
                "If five same coloured and shaped boxes are side by side (vertically or horizontally), you will earn as much as the point of that difficulty.");
        }
    }
}