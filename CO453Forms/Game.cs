using System;
using System.Collections.Generic;
using System.Threading;

namespace CO453Forms
{
    public enum Players
    {
        COMPUTER,
        PLAYER
    }

    /// <summary>
    /// To use this class the Start method should be called first 
    /// to clear the scores and set up the names of the computer and
    /// the player. The getComputerChoice method should be called 
    /// after the start method and the workOutWinner method should be 
    /// called next. To terminate the End method should be called.
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 12/02/2019
    /// Last Update:
    /// </summary>
    public class Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "STONE";
        public const string PAPER = "PAPER";

        public static string PlayerName { get; set; }
        public static string ComputerName { get; set; }
        public static string ComputerChoice { get; set; }
        public static string PlayerChoice { get; set; }
        public static string Winner { get; set; }

        public static int PlayerScore { get; set; }
        public static int ComputerScore { get; set; }

        private static Random randomGenerator = new Random(234);

        //static void Main()
        //{
        //    Game myGame = new Game();

        //    myGame.Play();
        //}

        /// <summary>
        /// *******************************************************
        /// This method will Start the Game
        /// *******************************************************
        /// </summary>
        public static void Start()
        {
            PlayerScore = 0;
            ComputerScore = 0;

            PlayerName = "Ana";
            ComputerName = "The Computer";
        }


        /// <summary>
        /// *******************************************************
        /// This method will End the Game
        /// *******************************************************
        /// </summary>
        public static void End()
        {
            if (PlayerScore > ComputerScore)
                Winner = PlayerName;
            else if (PlayerScore < ComputerScore)
                Winner = ComputerName;
            else
                Winner = "No Winner";
        }

        /// <summary>
        /// *******************************************************
        /// This method will Get the Computer Choice
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = SCISSORS;
            }
            else if (choice == 1)
            {
                ComputerChoice = PAPER;
            }
            else if (choice == 2)
            {
                ComputerChoice = STONE;
            }
        }

        /// <summary>
        /// *******************************************************
        /// This method will Work out the Winner
        /// *******************************************************
        /// </summary>
        public static void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "No Winner";
                ComputerScore++;
                PlayerScore++;
            }
            else if ((PlayerChoice == STONE && ComputerChoice == PAPER) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == STONE) ||
                    (PlayerChoice == PAPER && ComputerChoice == SCISSORS))
            {
                Winner = ComputerName;
                ComputerScore += 2;
            }
            else if ((PlayerChoice == STONE && ComputerChoice == SCISSORS) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == PAPER) ||
                    (PlayerChoice == PAPER && ComputerChoice == STONE))
            {
                Winner = PlayerName;
                PlayerScore += 2;
            }
        }
    }
}