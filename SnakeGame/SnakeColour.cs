using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeColor : Form
    {
        public SnakeColor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Odpremo novo okno in prenesemo vrednost in tem primeru barvo kače, katero je izbral uporabnik
        /// Kača se bo v igralnem oknu obarvala  v tej barvi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void playButten_Click(object sender, EventArgs e)
        {
            Form1 playGame = new Form1(colorSnake);
            playGame.PassingValue = colorSnake;
            playGame.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Odpremo novo okno in tega zapremo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void backButton_Click(object sender, EventArgs e)
        {
            Home goHome = new Home();
            goHome.Show();
            this.Close();
        }

        public string colorSnake = "";
        /// <summary>
        /// Po kliku na barvo, se v spremenljivko katero bomo prenesli v igralno okno shrani ime barve. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            colorSnake = "Gold";
            goodJob.Visible = true;
            timer.Start();
        }

        public void whiteSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "White";
            goodJob.Visible = true;
            timer.Start();
        }

        public void grenYellow_Click(object sender, EventArgs e)
        {
            colorSnake = "GreenYellow";
            goodJob.Visible = true;
            timer.Start();
        }

        public void AquamarineSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Aquamarine";
            goodJob.Visible = true;
            timer.Start();
        }

        public void royalBlueSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "RoyalBlue";
            goodJob.Visible = true;
            timer.Start();
        }

        public void paleGreenSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "PaleGreen";
            goodJob.Visible = true;
            timer.Start();
        }

        public void pinkSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Pink";
            goodJob.Visible = true;
            timer.Start();
        }

        public void purpleSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Purple";
            goodJob.Visible = true;
            timer.Start();
        }

        public void redSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Red";
            goodJob.Visible = true;
            timer.Start();

        }

        public void moccasinSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Moccasin";
            goodJob.Visible = true;
            timer.Start();
        }

        public void oliveSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Olive";
            goodJob.Visible = true;
            timer.Start();
        }

        public void salmonSnake_Click(object sender, EventArgs e)
        {
            colorSnake = "Salmon";
            goodJob.Visible = true;
            timer.Start();
        }

        /// <summary>
        /// Timer za prikaz slik po določenem času.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (goodJob.Visible)
            {
                timer.Interval = 700;
                goodJob.Visible = false;
                letsPlay.Visible = true;
                timer.Stop();
            }
        }
    }
}
