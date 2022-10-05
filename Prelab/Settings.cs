using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prelab.Properties;

namespace Prelab
{
    public partial class Settings : Form
    {
        int selected = 0;
        private int easy;
        private int intermediate;
        private int hard;
        private int customRow;
        private int customCol;
        private int difficulty;
        private string shape;
        private string color;
        private int point;

        private static Settings mySettings;
        
        public int Easy { get => easy; set => easy = value; }
        public int Intermediate { get => intermediate; set => intermediate = value; }
        public int Hard { get => hard; set => hard = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
        public string Color { get => color; set => color = value; }
        public string Shape { get => shape; set => shape = value; }
        public int CustomRow { get => customRow; set => customRow = value; }
        public int CustomCol { get => customCol; set => customCol = value; }
        public int Point { get => point; set => point = value; }

        public static Settings MySettings()
        {
            if (mySettings == null)
            {
                mySettings = new Settings();
            }
            return mySettings;
        }

        public Settings()
        {
            InitializeComponent();
        }

        private void easy_butonu_CheckedChanged(object sender, EventArgs e)
        {
            mySettings.Easy = 15;
            mySettings.Difficulty = mySettings.Easy;
            mySettings.Point = 1;
        }

        private void normal_butonu_CheckedChanged(object sender, EventArgs e)
        {
            mySettings.Intermediate = 9;
            mySettings.Difficulty = mySettings.intermediate;
            mySettings.Point = 3;
        }

        private void hard_butonu_CheckedChanged(object sender, EventArgs e)
        {
            mySettings.Hard = 6;
            mySettings.Difficulty = mySettings.Hard;
            mySettings.Point = 5;
        }

        private void custom_butonu_CheckedChanged(object sender, EventArgs e)
        {
            customBox.Visible = true;
            customBox2.Visible = true;
            mySettings.Difficulty = mySettings.CustomRow;

            if (!custom_butonu.Checked)
            {
                customBox.Visible = false;
                customBox2.Visible = false;
                customBox.Text = "0";
                customBox2.Text = "0";
            }
        }

        private void kare_CheckedChanged(object sender, EventArgs e) 
        {
           // mySettings.Shape = "square";
        }
       
        private void ucgen_CheckedChanged(object sender, EventArgs e) { }

        private void yuvarlak_CheckedChanged(object sender, EventArgs e) { }

        private void exitBtn_Click(object sender, EventArgs e) { this.Hide(); }

        private void customBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mySettings.customRow = int.Parse(customBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen her iki kutucuğa bir değer girin. " + ex.Message);
            }           
        }

        private void customBox2_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                mySettings.customCol = int.Parse(customBox2.Text);
                int val1 = int.Parse(customBox.Text);
                int val2 = int.Parse(customBox2.Text);
                int[,] dimArr = new int[val1, val2];
            }
            catch (Exception ex) // Kutucuklara değer girilmezse hata döndürür
            {
                MessageBox.Show("Lütfen her iki kutucuğa bir değer girin. " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)          // Ayarları default kayıt etmek için
        {
            Properties.Settings.Default.Yuvarlak = yuvarlak.Checked;
            Properties.Settings.Default.Kare = kare.Checked;
            Properties.Settings.Default.Ucgen = ucgen.Checked;
            Properties.Settings.Default.Easy = easy_butonu.Checked;
            Properties.Settings.Default.Normal = normal_butonu.Checked;
            Properties.Settings.Default.Hard = hard_butonu.Checked;
            Properties.Settings.Default.Custom = custom_butonu.Checked;
            Properties.Settings.Default.Yellow = yellowBox.Checked;
            Properties.Settings.Default.Red = redBox.Checked;
            Properties.Settings.Default.Blue = blueBox.Checked;             
            
            // Difficulty Check 
            if (easy_butonu.Checked)
            {
                Properties.Settings.Default.Difficulty = mySettings.Easy;
                Properties.Settings.Default.Point = mySettings.Point;
            }
            else if (normal_butonu.Checked)
            {
                Properties.Settings.Default.Difficulty = mySettings.intermediate;
                Properties.Settings.Default.Point = mySettings.Point;
            }
            else if (hard_butonu.Checked)
            {
                Properties.Settings.Default.Difficulty = mySettings.Hard;
                Properties.Settings.Default.Point = mySettings.Point;
            }else
            {
                try
                {
                    Properties.Settings.Default.CusBox = int.Parse(customBox.Text);
                    Properties.Settings.Default.CusBox2 = int.Parse(customBox2.Text);
                }
                catch (Exception ex) // Kutucuklara değer girilmeyip kayıt edilmeye çalışılırsa hata döndürür.
                {
                    MessageBox.Show("Lütfen her iki kutucuğa bir değer girin. " + ex.Message);
                }
            }
                        
            // Shape Check
            if (kare.Checked)
            {
                mySettings.Shape = "square";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }
            if (ucgen.Checked)
            {
                mySettings.Shape = "triangle";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }
            if (yuvarlak.Checked)
            {
                mySettings.Shape = "circle";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }
            if (kare.Checked && ucgen.Checked)
            {
                mySettings.Shape = "square_triangle";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }
            if (kare.Checked && yuvarlak.Checked)
            {
                mySettings.Shape = "square_circle";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }
            if (ucgen.Checked && yuvarlak.Checked)
            {
                mySettings.Shape = "triangle_circle";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }
            if (kare.Checked && ucgen.Checked && yuvarlak.Checked)
            {
                mySettings.Shape = "square_triangle_circle";
                Properties.Settings.Default.Shape = mySettings.Shape;
                selected++;
            }

            // Color Check 
            if (yellowBox.Checked)
            {
                mySettings.Color = "yellow";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }
            if (redBox.Checked)
            {
                mySettings.Color = "red";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }
            if (blueBox.Checked)
            {
                mySettings.Color = "blue";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }
            if (yellowBox.Checked && redBox.Checked)
            {
                mySettings.Color = "yellow_red";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }
            if (yellowBox.Checked && blueBox.Checked)
            {
                mySettings.Color = "yellow_blue";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }
            if (redBox.Checked && blueBox.Checked)
            {
                mySettings.Color = "red_blue";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }
            if (yellowBox.Checked && redBox.Checked && blueBox.Checked)
            {
                mySettings.Color = "yellow_red_blue";
                Properties.Settings.Default.Color = mySettings.Color;
                selected++;
            }

            if (selected<3)
            {
                MessageBox.Show("Lütfen en az 3 tür seçiniz.");
                exitBtn.Enabled = false;
            }
            else {
                exitBtn.Enabled = true; 
            }
            
            Properties.Settings.Default.Save();
            MessageBox.Show("Kayıt başarılı.");
        }

        private void Form3_Load(object sender, EventArgs e)         // Kayıtlı ayarlar yükleniyor
        {
            yuvarlak.Checked = Properties.Settings.Default.Yuvarlak;
            kare.Checked = Properties.Settings.Default.Kare;
            ucgen.Checked = Properties.Settings.Default.Ucgen;
            easy_butonu.Checked = Properties.Settings.Default.Easy;
            normal_butonu.Checked = Properties.Settings.Default.Normal;
            hard_butonu.Checked = Properties.Settings.Default.Hard;
            custom_butonu.Checked = Properties.Settings.Default.Custom;
            customBox.Text = Properties.Settings.Default.CusBox.ToString();
            customBox2.Text = Properties.Settings.Default.CusBox2.ToString();
            yellowBox.Checked = Properties.Settings.Default.Yellow;
            redBox.Checked = Properties.Settings.Default.Red;
            blueBox.Checked = Properties.Settings.Default.Blue;
            mySettings.Color = Properties.Settings.Default.Color;

            // Difficulty
            if (easy_butonu.Checked)
            {
                mySettings.Easy = Properties.Settings.Default.Difficulty;
            }
            else if (normal_butonu.Checked)
            {
                mySettings.intermediate = Properties.Settings.Default.Difficulty;
            }
            else if (hard_butonu.Checked)
            {
                mySettings.Hard = Properties.Settings.Default.Difficulty;
            }
            
            // Shape
            if (kare.Checked)
            {
                mySettings.Shape = "square";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }
            if (ucgen.Checked)
            {
                mySettings.Shape = "triangle";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }
            if (yuvarlak.Checked)
            {
                mySettings.Shape = "circle";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }
            if (kare.Checked && ucgen.Checked)
            {
                mySettings.Shape = "square_triangle";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }
            if (kare.Checked && yuvarlak.Checked)
            {
                mySettings.Shape = "square_circle";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }
            if (ucgen.Checked && yuvarlak.Checked)
            {
                mySettings.Shape = "triangle_circle";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }
            if (kare.Checked && ucgen.Checked && yuvarlak.Checked)
            {
                mySettings.Shape = "square_triangle_circle";
                mySettings.Shape = Properties.Settings.Default.Shape;
            }

                // Color
            if (yellowBox.Checked)
            {
                mySettings.Color = "yellow";
                mySettings.Color = Properties.Settings.Default.Color;
            }
            if (redBox.Checked)
            {
                mySettings.Color = "red";
                mySettings.Color = Properties.Settings.Default.Color;
            }
            if (blueBox.Checked)
            {
                mySettings.Color = "blue";
                mySettings.Color = Properties.Settings.Default.Color;
            }
            if (yellowBox.Checked && redBox.Checked)
            {
                mySettings.Color = "yellow_red";
                mySettings.Color = Properties.Settings.Default.Color;
            }
            if (yellowBox.Checked && blueBox.Checked)
            {
                mySettings.Color = "yellow_blue";
                mySettings.Color = Properties.Settings.Default.Color;
            }
            if (redBox.Checked && blueBox.Checked)
            {
                mySettings.Color = "red_blue";
                mySettings.Color = Properties.Settings.Default.Color;
            }
            if (yellowBox.Checked && redBox.Checked && blueBox.Checked)
            {
                mySettings.Color = "yellow_red_blue";
                mySettings.Color = Properties.Settings.Default.Color;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            About p = new About();
            p.Show();
        }

        private void yellowBox_CheckedChanged(object sender, EventArgs e) { }

        private void redBox_CheckedChanged(object sender, EventArgs e) { }
 
        private void blueBox_CheckedChanged(object sender, EventArgs e) { }      
    }
}