using System;
using System.Windows.Forms;

namespace Prelab
{
    public partial class MainMenu : Form
    {
        Settings mySettings = Settings.MySettings();

        private static Board board;
        public static Board GetBoard
        {
            get
            {
                if (board ==null || board.IsDisposed)
                {
                    board = new Board();
                }
                return board;
            }
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void form2_play_Click(object sender, EventArgs e)
        {                      
            Board board = new Board();
            board.Show();            
        }

        private void form2_settings_Click(object sender, EventArgs e)
        {
            Settings yeniform2 = new Settings();          // ayarlar sekmesine gitmek için
            yeniform2.Show();
        }

        private void form2_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();     // Çıkış için
        }

        private void admin_menu_Click(object sender, EventArgs e)
        {
            Admin_paneli a1 = new Admin_paneli();
            a1.Show();
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Load last played settings defaults
            mySettings.Easy = 15;
            mySettings.Intermediate = 9;
            mySettings.Hard = 6;
            mySettings.CustomCol = Properties.Settings.Default.CusBox2;
            mySettings.CustomRow = Properties.Settings.Default.CusBox;
            mySettings.Difficulty = Properties.Settings.Default.Difficulty;
            mySettings.Shape = Properties.Settings.Default.Shape;
            mySettings.Color = Properties.Settings.Default.Color;
            mySettings.Point = Properties.Settings.Default.Point;
            
            if (mySettings.CustomCol != 0 || mySettings.CustomRow != 0)
            {
                mySettings.Difficulty = mySettings.CustomRow;
            }
            if (mySettings.Difficulty == 0 || mySettings.Difficulty == null)
            {
                Properties.Settings.Default.Normal = true;
                mySettings.Shape = "square_triangle_circle";
                mySettings.Point = 5;
                mySettings.Difficulty = 9;
            }
        }

        private void menu_profil_Click(object sender, EventArgs e)
        {
            Profil_sayfasi p = new Profil_sayfasi();
            p.Show();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }

        private void main_logout_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            p.Show();
            this.Close();
        }

        private void menu_help_butonu_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}