﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLib
{
    public class rockPaperScissorsLizardSpock
    {
        public enum Choice {Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, Spock = 4}
        public enum Outcome {Win = 10, Lose = 11, Draw = 12}

        private int playerChoice;
        public int PlayerChoice
        {
            get { return playerChoice; }
            set { playerChoice = value; }
        }

        //generating random for computer's choice and outputting
        private static readonly Random rand = new Random();
        private int computerChoice = rand.Next(5);
        public int ComputerChoice
        {
            get {return computerChoice;}
        }

        //assigning user's input to a real world value
        public string displayUserChoice(int m_userInput)
        {
            string m_result = "";
            switch (m_userInput)
            {
                case (int)Choice.Rock:
                    m_result = "ROCK";
                    break;
                case (int)Choice.Paper:
                    m_result = "PAPER";
                    break;
                case (int)Choice.Scissors:
                    m_result = "SCISSORS";
                    break;
                case (int)Choice.Lizard:
                    m_result = "LIZARD";
                    break;
                case (int)Choice.Spock:
                    m_result = "SPOCK";
                    break;
            }
            return m_result;
        }

        //assigning results to real world value
        public string displayResult(int m_outcome)
        {
            string m_result = "";
            switch (m_outcome)
            {
                case (int)Outcome.Win:
                    m_result = "You Win!";
                    break;
                case (int)Outcome.Lose:
                    m_result = "You Lose!";
                    break;
                case (int)Outcome.Draw:
                    m_result = "Draw.";
                    break;
            }
            return m_result;
        }

        //determine outcome of the game
        public int determineOutcome()
        {
            int m_result;
            int[,] selection = new int[5, 5]
            {
                {(int)Outcome.Draw,(int)Outcome.Lose,(int)Outcome.Win,(int)Outcome.Win,(int)Outcome.Lose},
                {(int)Outcome.Win,(int)Outcome.Draw,(int)Outcome.Lose,(int)Outcome.Lose,(int)Outcome.Win},
                {(int)Outcome.Lose,(int)Outcome.Win,(int)Outcome.Draw,(int)Outcome.Win,(int)Outcome.Lose},
                {(int)Outcome.Lose,(int)Outcome.Win,(int)Outcome.Lose,(int)Outcome.Draw,(int)Outcome.Win},
                {(int)Outcome.Win,(int)Outcome.Lose,(int)Outcome.Win,(int)Outcome.Lose,(int)Outcome.Draw}
            };
            m_result = selection[PlayerChoice, ComputerChoice];
            return m_result;
        }

    }
}
