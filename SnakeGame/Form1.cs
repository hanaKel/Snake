using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Imaging;
using SnakeGame.Properties;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Premiki kače, hrane in ovire glede na časovnik se določajo nove koordinate in se tako ustvari premikanje
        /// </summary>
        private List<Moving> Snake = new List<Moving>();
        private Moving food = new Moving();
        private Moving barrier = new Moving();


        public int maxWidth, maxHeight, score;
        public int time = 0;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp, goEnd;

        /// <summary>
        /// To okno spreme parameter
        /// </summary>
        /// <param name="passingValue"></param>
        public Form1(string passingValue)
        {
            InitializeComponent();
            new Settings();
            string userColor = passingValue;
        }
        /// <summary>
        /// Lasnost 
        /// </summary>
        public string PassingValue {get; set; }

        // Prijavimo se na poslušanje dogodkov, kateri so kliki na tipkovnici
        // Izbrani kliki na tipkovnici opisujejo premike kače
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Enter)  // Poslusamo tudi klik na Enter, saj se bo takrat igra zaustavila
            {
                goEnd = true;
            }
        }

        /// <summary>
        /// Zanima nas tudi kdaj ni pritisnena tipka na tipkovnici, saj želimo da se kača odziva
        /// le na klike
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Escape)
            {
                goEnd = false; 
            }
        }

        // Klik na gumb Start zaženemo igro.
        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
            txtScore.Visible = true;
            // prikaz časa igranja
            txtTimer.Visible = true;
            goHomeButton.Visible = false;
            goHomeButton.Enabled = false;
            startButton.Visible = false;
        }

        // Timer dogodek
        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Ob vsakem kliku definiramo smer premika in ob premiku določimo zvok
            System.IO.Stream str = Properties.Resources.sound_movingSnake;
            SoundPlayer sound_movingSnake = new SoundPlayer(str);
            if (goLeft) // if goLeft is true -> dolocimo smer premika v levo
            {
                Settings.directions = "left";
                sound_movingSnake.Play();
            }
            if (goRight)
            {
                Settings.directions = "right";
                sound_movingSnake.Play();
            }
            if (goDown)
            {
                Settings.directions = "down";
                sound_movingSnake.Play();
            }
            if (goUp)
            {
                Settings.directions = "up"; 
                sound_movingSnake.Play();
            }
            if (goEnd) // igro damo na pauzo  s klikom na Enter
            {
                PauseGame(); // poklicemo funkcijo pauza in gumbe za play in go Home postaneta vidna in aktivna
                goHomeButton.Visible = true;
                goHomeButton.Enabled = true;
                startButton.Enabled = true;
            }

            // Premikanje kače, glede na ukaze
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    // če se kača zaleti v zid na drugi strani pogleda nazaj na igralno okno
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    // V primeru, da se hrana in kača prekrijeta je kača pojedla hrano
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();   
                        if (score == 20)  // ko je pojedla 20 enot hrane je uporabnik zmagal
                        {
                            WinWin();
                        }
                    }
                    // V primeru, da se kača in njen del telesa/ trup prekrijeta je konec igre
                    // Konec igre je tudi, če se kača zaleti v oviro.
                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                        if (Snake[0].X == barrier.X && Snake[0].Y == barrier.Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }

            }
            picCanvas.Invalidate();
            // V oknu se prikazuje čas igranja
            time++;
            txtTimer.Text = "Time : " + (time / 10.0).ToString() + " sec. ";
        }

        /// <summary>
        /// Timer, ki definira premike oz. prikaze ovire na igralnem oknu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBarriera_Tick(object sender, EventArgs e)
        {   
            timerBarriera.Interval = 1000;
            barrier = new Moving { X = rand.Next(0, maxWidth), Y = rand.Next(0, maxHeight) };
        }

        /// <summary>
        /// Klik na gumb Go home so odpre osnovno okno in igralno zapre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goHomeButton_Click(object sender, EventArgs e)
        {
            goHomeButton.Enabled = true;
            GameOver();
            Home goHome = new Home();
            goHome.Show();
            this.Hide();
        }

        // Pri kliku na gumb Start se igra zažene 
        private void startButton_Click(object sender, EventArgs e)
        {
            RestartGame();
            txtScore.Visible = true;
            // prikaz časa igranja
            txtTimer.Visible = true;
        }

        private void lbl_winner_Click(object sender, EventArgs e)
        {

        }

        private void timerGoHome_Tick(object sender, EventArgs e)
        {
            Home goHome = new Home();
            goHome.Show();
            this.Hide();
            timerGoHome.Stop();
            timerGoHome.Enabled = false;
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            //Uporabimo prenešen parameter oz. niz
            string userColor = PassingValue;
            // Določimo pot do slike, kjer je shranjena slika za kačino glavo.
            // string path = @"C:\Users\Ldon Kranjec\Desktop\HanaKranjec_P3_SN_popravki\Hana_Kranjec_P3_projekt\SnakeGame\pictures\snakeHead.png";

            // Image snakeHead = Image.FromFile(path);
            Image head = Resources.snakeHead;
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            // Obarvamo kačo
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0) // prvi el kače je glava, katera je drugačna od trupa
                {   
                    canvas.DrawImage(head, new Rectangle(
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width + 10, Settings.Height + 10));
                }
                else
                {
                    if (userColor == "0")
                    {   // če je prenešen parameter 0, potem je avtomatska barva 
                        // trup so krožci avtomatsko zelene barve
                        snakeColour = System.Drawing.Brushes.Chartreuse;
                        canvas.FillEllipse(snakeColour, new Rectangle(
                        Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));
                    }
                    else
                    {
                        // trup so krožci izbrane barve
                        List<String> colors1 = new List<string> { "Brushes.Gold", "Brushes.Yellow", "Brushes.Olive", "Brushes.Salmon", "Brushes.Pink", "Brushes.White",
                                                                 "Brushes.Red", "Brushes.GreenYellow", "Brushes.Moccasin", "Brushes.PaleGreen", "Brushes.Purple","Brushes.RoyalBlue", "Brushes.Aquamarine"};
                        List<Brush> colors2 = new List<Brush> { Brushes.Gold, Brushes.Yellow, Brushes.Olive, Brushes.Salmon, Brushes.Pink, Brushes.White,
                                                                Brushes.Red, Brushes.GreenYellow, Brushes.Moccasin, Brushes.PaleGreen, Brushes.Purple, Brushes.RoyalBlue, Brushes.Aquamarine};
                        int j = 0;
                        foreach (string col in colors1)
                        {
                            string[] cut = col.Split('.');
                            if (cut[1] == userColor)
                            {
                                Brush brushSnake = colors2[j];
                                canvas.FillEllipse(brushSnake, new Rectangle(
                                Snake[i].X * Settings.Width,
                                Snake[i].Y * Settings.Height,
                                Settings.Width, Settings.Height
                                ));
                            }
                            j++;
                        }
                    }

                }
                
            }

            // hrana se bo obarvala v naključnih barva iz tabele
            int num = rand.Next(0, 5);
            Brush[] foodi = new Brush[] { Brushes.AliceBlue, Brushes.Aqua, Brushes.Yellow, Brushes.Blue, Brushes.Pink, Brushes.Purple };
            Brush f = foodi[num];
            canvas.FillEllipse(f, new Rectangle(
            food.X * Settings.Width,
                    food.Y * Settings.Height,
            Settings.Width, Settings.Height
                ));

            // izgled ovire
            System.Drawing.Brush[] colors = new Brush[] { Brushes.AliceBlue, Brushes.Aqua, Brushes.Yellow, Brushes.Blue, Brushes.Pink, Brushes.White };
            Brush br = colors[num];
            Pen myPen = new Pen(br, 3);

            Rectangle myRectangle = new Rectangle(barrier.X * Settings.Height, barrier.Y * Settings.Width, Settings.Width, Settings.Height * 3);
            canvas.DrawRectangle(myPen, myRectangle);
        }

        private void PauseGame()
        {
            gameTimer.Enabled = false;
            startButton.Visible = true;
            startButton.Enabled = true;
        }

        private void RestartGame()
        {
            // Začela se je igra, kačo postavimo na začetno mesto.
            // Točke imajo na začetku vrednost 0.
            maxWidth = picCanvas.Width  / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;
            Snake.Clear();
            startButton.Visible = false;
            startButton.Enabled = false;
            goHomeButton.Visible = false;

            score = 0;
            txtScore.Text = "Score: " + score;

            Moving head = new Moving { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Moving body = new Moving();
                Snake.Add(body);
            }
            // Hrana se bo prikazovala z naključnimi kordinatami znotraj igralnega okna.
            food = new Moving { X = rand.Next(2, maxWidth -5 ), Y = rand.Next(2, maxHeight - 5) };
            barrier = new Moving { X = rand.Next(2, maxWidth-5), Y = rand.Next(2, maxHeight-5) };
            gameTimer.Start();
            lbl_gameOver.Visible = false;
        }

        private void WinWin()
        {
            gameTimer.Stop();
            pictureBox_win.Visible = true;
            lbl_winner.Visible = true;
            lbl_winner.Text = $"Congrats you're the winner. Score :  {score}.";
            startButton.Enabled = true;
            System.IO.Stream str1 = Properties.Resources.sound_eatFood;
            SoundPlayer sound_win= new SoundPlayer(str1);
            sound_win.Play();
        }

        private void EatFood()
            {
            // Kača se je prekrila s hrano, zato uporabnik dobi dodatno točko. 
            // Kača se podaljša in hrana dobi nove naključne kordinate kamor se naključno prikaže.
                score += 1;
                txtScore.Text = "Score: " + score;

                Moving body = new Moving
                {
                    X = Snake[Snake.Count - 1].X,
                    Y = Snake[Snake.Count - 1].Y
                };

                Snake.Add(body);

                food = new Moving { X = rand.Next(0, maxWidth), Y = rand.Next(0, maxHeight) };
                barrier = new Moving { X = rand.Next(0, maxWidth), Y = rand.Next(0, maxHeight) };
                // Ob prekriti hrani s kačo se izvede zmagovalni zvok.
                System.IO.Stream str1 = Properties.Resources.sound_eatFood;
                SoundPlayer sound_eatFood = new SoundPlayer(str1);
                sound_eatFood.Play();
        }

            private void GameOver()
{
                // Konec igre, zaigra zvok za poražence in izpišejo se točke.
                gameTimer.Stop();

                startButton.Visible = true;
                startButton.Enabled = true;
                goHomeButton.Visible = true;
                goHomeButton.Enabled = true;
                System.IO.Stream str1 = Properties.Resources.sound_gameOver;
                SoundPlayer sound_gameOver = new SoundPlayer(str1);
                sound_gameOver.Play();
                lbl_gameOver.Visible = true;
                txtScore.Text = $"High score is {score}.";
                timerGoHome.Start();

    }       }
}   


