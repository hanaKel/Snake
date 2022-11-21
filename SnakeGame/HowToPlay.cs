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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Odpremo novo okno po kliku na gumb
        /// Odpremo okno, katero mora prejeti parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            string colorSnake = "0";
            Form1 playGame = new Form1(colorSnake);
            playGame.PassingValue = colorSnake;
            playGame.ShowDialog();
            this.Hide();
        }

        /// <summary>
        ///Po kliku se odpre novo okno in to okno se zapre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Home goHome = new Home();
            goHome.Show();
            this.Close();
        }
    }
}
