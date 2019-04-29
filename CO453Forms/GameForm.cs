using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CO453Forms
{
    /// <summary>
    /// This class is responsible for getting input from the player
    /// and passing it to the game. It is also responsible for 
    /// getting the result back from the game and displaying it 
    /// to the user. IT SHOULD NOT EVER DO ANY OF THE GAME LOGIC ITSELF.
    /// </summary>
    public partial class GameForm : Form
    {
        private string playerName;
        private string computerName;

        public GameForm()
        {
            Thread t = new Thread(new ThreadStart(StartSplash));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            GameStart();
        }

        private void SelectScissors(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("scissors.jpg");
            Game.PlayerChoice = Game.SCISSORS;
            EnablePlayButton();
        }

        private void SelectPaper(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("paper.jpg");
            Game.PlayerChoice = Game.PAPER;
            EnablePlayButton();
        }

        private void SelectStone(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("stone.jpg");
            Game.PlayerChoice = Game.STONE;
            EnablePlayButton();
        }

        /// <summary>
        /// This method is called when the playButton is clicked
        /// </summary>
        private void SelectComputerChoice(object sender, EventArgs e)
        {
            Game.GetComputerChoice();
            if (Game.ComputerChoice == Game.SCISSORS)
            {
                computerPictureBox.Image = Image.FromFile("scissors.jpg");
            }
            else if (Game.ComputerChoice == Game.PAPER)
            {
                computerPictureBox.Image = Image.FromFile("paper.jpg");
            }
            else if (Game.ComputerChoice == Game.STONE)
            {
                computerPictureBox.Image = Image.FromFile("stone.jpg");
            }
            ShowResults();
        }

        private void ShowResults()
        {
            Game.WorkoutWinner();
            if (Game.Winner == playerName)
            {
                resultsLabel.Text = "The user has won!!!";
                resultsLabel.BackColor = Color.Green;
                resultsLabel.ForeColor = Color.Yellow;
            }
            else if (Game.Winner == computerName)
            {
                resultsLabel.Text = "The computer has won!!!";
                resultsLabel.BackColor = Color.Blue;
                resultsLabel.ForeColor = Color.Yellow;
            }
            else
            {
                resultsLabel.Text = "It's a draw!!!";
                resultsLabel.BackColor = Color.MistyRose;
                resultsLabel.ForeColor = Color.Black;
            }

            computerScoreLabel.Text = "Computer = " + Game.ComputerScore;
            userScoreLabel.Text = "User = " + Game.PlayerScore;

        }

        private void EnablePlayButton()
        {
            playButton.Enabled = true;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameStart()
        {
            Game.Start();
            playerName = Game.PlayerName;
            computerName = Game.ComputerName;
        }

        /// <summary>
        /// This method will start the Splash Screen
        /// </summary>
        public void StartSplash()
        {
            Application.Run(new SplashScreen());
        }

        /// <summary>
        /// This method will show the winner gif
        /// </summary>
        public static void ShowWinnerGif()
        {
            Application.Run(new WinnerGif());
        }

        /// <summary>
        /// This method will show the loser gif
        /// </summary>
        public static void ShowLoserGif()
        {
            Application.Run(new LoserGif());
        }

        /// <summary>
        /// This method will show the draw gif
        /// </summary>
        public static void ShowDrawGif()
        {
            Application.Run(new DrawGif());
        }

        /// <summary>
        /// This method will show an appropriate image always the user
        /// or computer scores, or both reach 20.
        /// </summary>
        public void GameOver()
        {
            if ((Game.PlayerScore == 20))
            {
                Thread win = new Thread(new ThreadStart(ShowWinnerGif));
                win.Start();
                Thread.Sleep(5000);
            }
            else if ((Game.ComputerScore == 20))
            {
                Thread lose = new Thread(new ThreadStart(ShowLoserGif));
                lose.Start();
                Thread.Sleep(5000);
            }
            else if ((Game.PlayerScore == 20) && (Game.ComputerScore == 20))
            {
                Thread draw = new Thread(new ThreadStart(ShowDrawGif));
                draw.Start();
                Thread.Sleep(5000);
            }
        }
    }
}