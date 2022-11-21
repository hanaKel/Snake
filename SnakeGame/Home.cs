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
    public partial class Home : Form
    {
        /// <summary>
        /// Osnovno okno, katero se odpre bi zagonu aplikacije
        /// </summary>
        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Po kliku na PLAY se odpre drugo okno, tukaj prenesemo parameter v igralno okno,
        /// ker smo definirali, da igralno okno prejme niz. Zato si tukaj nekaj zmislim, kar 
        /// bo pomenilo, da je avtomatsko barvanje kače. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playSnakeGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Igralno okno mora prejeti parameter. Iz osnovnega okna ne nastavimo barve kače, zato je tukaj 
            string colorSnake = "0";
            Form1 playGame = new Form1(colorSnake);
            playGame.PassingValue = colorSnake;
            playGame.ShowDialog();
            this.Hide();
        }
        /// <summary>
        /// Odpre se novo okno How to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playSnakeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToPlay howToPlay = new HowToPlay();
            howToPlay.Show();
            this.Hide();


        }


        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Odpre se novo okno Snake Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snakeColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SnakeColor snakeColour = new SnakeColor();
            snakeColour.Show();
            this.Hide();

        }

        /// <summary>
        /// Odpre se novo okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void howTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinLose winOrlose = new WinLose ();
            winOrlose.Show();
            this.Hide();
        }

    }
}
