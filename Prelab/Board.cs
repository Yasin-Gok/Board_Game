using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Prelab
{
    public partial class Board : Form
    {
        public User user = User.LoginedUser();
        static Settings mySetting = Settings.MySettings();
        int[,] test = new int[mySetting.Difficulty, mySetting.Difficulty];
        public List<PictureBox> items = new List<PictureBox>();
        
        Random random = new Random();
        int red, blue, yellow, yellowRed, redBlue, yellowBlue,shapeNumber;
        int rndmX, rndmY, locationX, locationY;
        
        int shapeCount, shapeCountTemp = 0;
        int speed = 50;
        int point = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sound\move.wav");
        System.Media.SoundPlayer pointSound = new System.Media.SoundPlayer(@"sound\point.wav");

        string selectedItem;
        int selectedShape = 0;
        // for all shape colors
        int[] yellowColor = { 2, 6, 9 };
        int[] redColor = { 3, 5, 8 };
        int[] blueColor = { 1, 4, 7 };
        int[] allyellowBlue = { 2, 6, 9, 1, 4, 7 };
        int[] allyellowRed = { 2, 6, 9, 3, 5, 8 };
        int[] allredBlue = { 3, 5, 8, 1, 4, 7 };
        // for square_circle colors
        int[] scYellow = { 2, 6};
        int[] scRed = { 3, 5 };
        int[] scBlue = { 1, 4 };
        int[] scYellowBlue = { 2, 6, 1, 4 };
        int[] scYellowRed = { 2, 6, 3, 5 };
        int[] scRedBlue = { 3, 5, 1, 4 };
        int[] scAll = { 2, 6, 3, 5, 1, 4 };
        // for square_triangle colors
        int[] stYellow = { 2, 9 };
        int[] stRed = { 3, 8 };
        int[] stBlue = { 1, 7 };
        int[] stYellowBlue = { 2,9,1,7 };
        int[] stYellowRed = { 2,9,3,8 };
        int[] stRedBlue = { 3,8,1,7 };
        int[] stAll = { 2, 9, 3, 8, 1, 7 };
        // for circle_triangle colors
        int[] ctYellow = { 6, 9 };
        int[] ctRed = { 5, 8 };
        int[] ctBlue = { 4, 7 };
        int[] ctYellowBlue = { 6, 9, 4, 7 };
        int[] ctYellowRed = { 6, 9, 5,8 };
        int[] ctRedBlue = { 5, 8, 4, 7 };
        int[] ctAll = { 6, 9, 5, 8, 4, 7 };
        // single shape colors
        int[] squareBlue = { 1 };
        int[] squareRed = { 3 };
        int[] squareYellow = { 2 };
        int[] circleBlue = { 4 };
        int[] circleRed = { 5 };
        int[] circleYellow = { 6 };
        int[] triangleBlue = { 7 };
        int[] triangleRed = { 8 };
        int[] triangleYellow = { 9 };

        private void Board_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result2 == DialogResult.OK)
            {               
                Application.Exit();
            }
            else if (result2 == DialogResult.Cancel) { this.Hide(); }
        }
    

        public Board()
        {
            InitializeComponent();
        }
        
        private void spawnLocationColor()
        {
            // Spawn Shape at Random Location and Color based on the difficulty 
            try
            {
                if (mySetting.Difficulty == mySetting.CustomRow || mySetting.Difficulty == mySetting.CustomCol)
                {

                    rndmX = random.Next(0, mySetting.CustomRow);
                    rndmY = random.Next(0, mySetting.CustomCol);
                    while (test[rndmX, rndmY] == 1)
                    {
                        rndmX = random.Next(0, mySetting.CustomRow);
                        rndmY = random.Next(0, mySetting.CustomCol);
                    }
                }
                else
                {
                    rndmX = random.Next(0, mySetting.Difficulty);
                    rndmY = random.Next(0, mySetting.Difficulty);

                    while (test[rndmX, rndmY] == 1)
                    {
                        rndmX = random.Next(0, mySetting.Difficulty);
                        rndmY = random.Next(0, mySetting.Difficulty);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            // Selected Color based on Color Settings
            PictureBox pic = new PictureBox();
            if (mySetting.Color == "red")
            {
                pic.Image = Image.FromFile(@"pics\" + red + ".png");
            }
            else if (mySetting.Color == "blue")
            {
                pic.Image = Image.FromFile(@"pics\" + blue + ".png");
            }
            else if (mySetting.Color == "yellow")
            {
                pic.Image = Image.FromFile(@"pics\" + yellow + ".png");
            }
            else if (mySetting.Color == "yellow_red")
            {
                pic.Image = Image.FromFile(@"pics\" + yellowRed + ".png");
            }
            else if (mySetting.Color == "red_blue")
            {
                pic.Image = Image.FromFile(@"pics\" + redBlue + ".png");
            }
            else if (mySetting.Color == "yellow_blue")
            {
                pic.Image = Image.FromFile(@"pics\" + yellowBlue + ".png");
            }
            else //if color didnt select then random color will be selected 
            {
                pic.Image = Image.FromFile(@"pics\" + shapeNumber + ".png");
            }

            try
            {  //Spawn shapes at random location
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new Size(50, 50);
                pic.Location = new Point(rndmX * 50, rndmY * 50);

                test[rndmX, rndmY] = 1;
                pic.Tag = shapeNumber;
                items.Add(pic);
                this.Controls.Add(pic);
                pic.BringToFront();
                shapeCount++;
                shapeCountTemp++;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
           
            pic.Click += pic_Click;
        }
        // Create a new shape based on selected Shapes
        private void MakeShapes()
        {
            lblPoint.Size = new Size(50, 13);

            if (mySetting.Shape == null || mySetting.Shape == "square_triangle_circle" || mySetting.Color == null)
            {
                for (int i = 0; i < 3; i++)
                {
                //  if shape is empty, spawn a random shape
                    shapeNumber = random.Next(1, 10);

                    red = redColor[random.Next(0, redColor.Length)];
                    blue = blueColor[random.Next(0, blueColor.Length)];
                    yellow = yellowColor[random.Next(0, yellowColor.Length)];
                    yellowRed = allyellowRed[random.Next(0, allyellowRed.Length)];
                    redBlue = allredBlue[random.Next(0, allredBlue.Length)];
                    yellowBlue = allyellowBlue[random.Next(0, allyellowBlue.Length)];

                    spawnLocationColor();
                }
            }

            if (mySetting.Shape == "square")
            {
                for (int i = 0; i < 3; i++)
                {
                    shapeNumber = random.Next(1, 4);
                    red = squareRed[random.Next(0, squareRed.Length)];
                    blue = squareBlue[random.Next(0, squareBlue.Length)];
                    yellow = squareYellow[random.Next(0, squareYellow.Length)];
                    yellowRed = random.Next(2, 4);
                    redBlue = random.Next(10, 12);
                    yellowBlue = random.Next(1, 3);

                    spawnLocationColor();
                }
            }

            if (mySetting.Shape == "circle")
            {
                for (int i = 0; i < 3; i++)
                {
                    shapeNumber = random.Next(4, 7);
                    red = circleRed[random.Next(0, circleRed.Length)];
                    blue = circleBlue[random.Next(0, circleBlue.Length)];
                    yellow = circleYellow[random.Next(0, circleYellow.Length)];
                    yellowRed = random.Next(5, 7);
                    redBlue = random.Next(4, 6);
                    yellowBlue = random.Next(12, 14);

                    spawnLocationColor();
                }
            }

            if (mySetting.Shape == "triangle")
            {
                for (int i = 0; i < 3; i++)
                {
                    shapeNumber = random.Next(7, 10);
                    red = triangleRed[random.Next(0, triangleRed.Length)];
                    blue = triangleBlue[random.Next(0, triangleBlue.Length)];
                    yellow = triangleYellow[random.Next(0, triangleYellow.Length)];
                    yellowRed = random.Next(8, 10);
                    redBlue = random.Next(7, 9);
                    yellowBlue = random.Next(14, 16);

                    spawnLocationColor();
                }
            }

            if (mySetting.Shape == "square_triangle")
            {
                for (int i = 0; i < 3; i++)
                {
                    shapeNumber = stAll[random.Next(0, stAll.Length)];
                    red = stRed[random.Next(0, stRed.Length)];
                    blue = stBlue[random.Next(0, stBlue.Length)];
                    yellow = stYellow[random.Next(0, stYellow.Length)];
                    yellowRed = stYellowRed[random.Next(0, stYellowRed.Length)];
                    redBlue = stRedBlue[random.Next(0, stRedBlue.Length)];
                    yellowBlue = stYellowBlue[random.Next(0, stYellowBlue.Length)];

                    spawnLocationColor();
                }
            }

            if (mySetting.Shape == "triangle_circle")
            {
                for (int i = 0; i < 3; i++)
                {
                    shapeNumber = ctAll[random.Next(0, ctAll.Length)];
                    red = ctRed[random.Next(0, ctRed.Length)];
                    blue = ctBlue[random.Next(0, ctBlue.Length)];
                    yellow = ctYellow[random.Next(0, ctYellow.Length)];
                    yellowRed = ctYellowRed[random.Next(0, ctYellowRed.Length)];
                    redBlue = ctRedBlue[random.Next(0, ctRedBlue.Length)];
                    yellowBlue = ctYellowBlue[random.Next(0, ctYellowBlue.Length)];

                    spawnLocationColor();
                }
            }

            if (mySetting.Shape == "square_circle")
            {
                for (int i = 0; i < 3; i++)
                {
                    shapeNumber = scAll[random.Next(0, scAll.Length)];
                    red = scRed[random.Next(0, scRed.Length)];
                    blue = scBlue[random.Next(0, scBlue.Length)];
                    yellow = scYellow[random.Next(0, scYellow.Length)];
                    yellowRed = scYellowRed[random.Next(0, scYellowRed.Length)];
                    redBlue = scRedBlue[random.Next(0, scRedBlue.Length)];
                    yellowBlue = scYellowBlue[random.Next(0, scYellowBlue.Length)];

                    spawnLocationColor();
                }
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {      
            PictureBox pic = sender as PictureBox;
            
            if (selectedShape<1)
            {
                selectedItem = pic.Tag.ToString();
                
                pic.BringToFront();
                lblPoint.BringToFront();
                pic.Tag = "player";
                selectedItem = "player";
                locationY = pic.Location.X/50;
                locationX = pic.Location.Y/50;
               
                selectedShape++;
            }           
        }

        private void Board_Load(object sender, EventArgs e)
        {
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand cmd = new SqlCommand("Select Username FROM [User] where Username=@Username ", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();

            usernameTextBox.Text = user.Username1;
            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                usernameTextBox.Text = da["Username"].ToString();
            }
            Database.CreateSingle().Sqlconnection.Close();

            MessageBox.Show("Game Controls: \n\n" + "Select Shape with mouse click.\n\n"
                + "Move Shape with W A S D keys.\n\n" + "Press space to drop shape.\n\n" + "Press 'Q' to quit.");

            // Create board based on last game played and settings by user
            if (Properties.Settings.Default.Easy)
            {
                for (int i = 0; i < mySetting.Easy; i++)
                {                                    
                    for (int j = 0; j < mySetting.Easy; j++)
                    {                     
                        Button b = new Button();
                        b.Size = new Size(50, 50);
                        b.Location = new Point(i * 50, j * 50);
                        b.BackColor = Color.White;
                        
                        this.Controls.Add(b);
                        
                        if (shapeCount < 3)
                        {
                            MakeShapes();                           
                        }
                    }
                }
            }
            else if (Properties.Settings.Default.Normal)
            {
                for (int i = 0; i < mySetting.Intermediate; i++)
                {
                    for (int j = 0; j < mySetting.Intermediate; j++)
                    {
                        Button b = new Button();
                        b.Size = new Size(50, 50);
                        b.Location = new Point(i * 50, j * 50);
                        b.BackColor = Color.White;

                        this.Controls.Add(b);

                        if (shapeCount < 3)
                        {
                            MakeShapes();                            
                        }
                    }
                }
            }
            else if (Properties.Settings.Default.Hard)
            {
                for (int i = 0; i < mySetting.Hard; i++)
                {
                    for (int j = 0; j < mySetting.Hard; j++)
                    {
                        Button b = new Button();
                       
                        b.Size = new Size(50, 50);
                        b.Location = new Point(i* 50, j * 50);
                        b.BackColor = Color.White;
                        
                        this.Controls.Add(b);                      

                        if (shapeCount < 3) 
                        {
                            MakeShapes();
                        }                      
                    }
                }
            }
            else
            {
                for (int i = 0; i < mySetting.CustomRow; i++)
                {
                    for (int j = 0; j < mySetting.CustomCol; j++)
                    {
                        Button b = new Button();
                        b.Size = new Size(50, 50);
                        b.Location = new Point(i * 50, j * 50);
                        b.BackColor = Color.White;

                        this.Controls.Add(b);

                        if (shapeCount < 3)
                        {
                            MakeShapes();
                        }
                    }
                }
            }
        }

        private void Board_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q)
            {
                this.Hide();
            }

            try
            {
                foreach (PictureBox pic in items.ToList())
                {
                    if (selectedItem == pic.Tag.ToString())
                    {
                        player.Play();

                        int x = pic.Location.X;
                        int y = pic.Location.Y;
                        locationX = pic.Location.X / 50;
                        locationY = pic.Location.Y / 50;
                        test[locationX, locationY] = 0;

                        if (e.KeyCode == Keys.D && this.Width - pic.Width > pic.Left + speed && test[locationX + 1, locationY] == 0)
                        {
                            x += speed;
                            pic.Location = new Point(x, y);
                            test[x / 50, y / 50] = 1;
                        }
                        else if (e.KeyCode == Keys.A && 0 <= pic.Left - speed && test[locationX - 1, locationY] == 0)
                        {
                            x -= speed;
                            pic.Location = new Point(x, y);
                            test[x / 50, y / 50] = 1;
                        }
                        else if (e.KeyCode == Keys.W && pic.Top > 0 && test[locationX, locationY - 1] == 0)
                        {
                            y -= speed;
                            pic.Location = new Point(x, y);
                            test[x / 50, y / 50] = 1;
                        }
                        else if (e.KeyCode == Keys.S && this.Height - pic.Height > pic.Top + speed && test[locationX, locationY + 1] == 0)
                        {
                            y += speed;
                            pic.Location = new Point(x, y);
                            test[x / 50, y / 50] = 1;
                        }
                        else if (e.KeyCode == Keys.Space)
                        {
                                                            
                            if (shapeCount < mySetting.Difficulty * mySetting.Difficulty || shapeCount < mySetting.CustomCol * mySetting.CustomRow)
                            {
                                shapeCountTemp = 0;
                                selectedItem = mySetting.Color;
                                pic.Tag = mySetting.Shape;
                                selectedShape--;

                                test[locationX, locationY] = 1;

                                pic.Location = new Point(x, y);
                                test[x / 50, y / 50] = 1;

                                int temp = 0;
                                for (int i = 0; i < mySetting.Difficulty ; i++)
                                {
                                    if (test[i, locationY] == 1 && pic.Tag.ToString() == mySetting.Shape)
                                    {
                                        temp++;
                                        if (temp == 5 && pic.Tag.ToString() == mySetting.Shape)
                                        {
                                            player.Stop();
                                            pointSound.Play();
                                            point += mySetting.Point;
                                            lblPoint.Text = "Point: " + point;

                                        }
                                    }
                                }

                                if (shapeCountTemp < 3) { MakeShapes(); }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

               
            }
            
         
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            // Game is Over Screen & update score to database and open GameOver form 
            if (shapeCount >= mySetting.Difficulty * mySetting.Difficulty || shapeCount + 1 == mySetting.CustomCol * mySetting.CustomRow || shapeCount + 2 == mySetting.CustomCol * mySetting.CustomRow)
            {               
                gameTimer.Stop();
                if (point == 0) 
                    MessageBox.Show("Game Over!\n\n", "Point: " + point, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                else MessageBox.Show("Congrulations!\n\n", "Point: " + point, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (MessageBoxButtons.OK == 0)
                {
                    Database database = Database.CreateSingle();
                    database.GetConnection();
                    
                    SqlCommand cmd = new SqlCommand("Update [User] set Point=@Point where Username=@Username ", Database.CreateSingle().Sqlconnection);
                    Database.CreateSingle().Sqlconnection.Open();
                    cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);

                    cmd.Parameters.AddWithValue("@Point", point);

                    cmd.ExecuteNonQuery();
                    Database.CreateSingle().Sqlconnection.Close();

                    this.Hide();
                    GameOver gameover = new GameOver();
                    gameover.Show();
                }             
            }
        }
    }
}