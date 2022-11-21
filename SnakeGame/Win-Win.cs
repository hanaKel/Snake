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
    public partial class WinLose : Form
    {
        public WinLose()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Po kliku na gumb Play se odpre novo okno in to zapre. Tukaj tudi prenesemo parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            string colorSnake = "0";
            Form1 playGame = new Form1(colorSnake);
            playGame.PassingValue = colorSnake;
            playGame.ShowDialog();
            this.Hide();
        }
        /// <summary>
        /// Odpremo novo okno in tega zapremo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Home goHome = new Home();
            goHome.Show();
            this.Close();
        }
    }
}
