using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameLib;

namespace RPSLSconsole
{
    class Program
    {
        public enum Choice { Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, Spock = 4 }
        public enum Outcome { Win = 10, Lose = 11, Draw = 12 }

        static void Main(string[] args)
        {

            string userInput = "";
            int userChoice;
            rockPaperScissorsLizardSpock RPSLS = new rockPaperScissorsLizardSpock();
            while (true)
            {
                splash();
                userInput = Console.ReadLine();
                userChoice = determineChoice(userInput);
                switch (userChoice)
                {
                    case 6:
                        Console.Clear();
                        Console.WriteLine("***Type the number that corresponds with your selection, then press enter.***\n");
                        break;
                    default:
                        /*TODO: This is where we would actually send the RPSLS class the userChoice and return a win, 
                                lose, or draw. What would be the best way to do this?*/
                        break;
                }
            }
        }
        
        // display user's options
        static void splash()
        {
            Console.WriteLine("Please make a selection and press the return key:\n");
            Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n4. Lizard\n5. Spock\n6. Exit Game");
        }
        
        // confirm user's choice
        static Boolean confirm()
        {
            string m_userInput = "";
            bool m_result;
            Console.Clear();
            Console.WriteLine("Are you sure?\n Y or N.");
            m_userInput = Console.ReadLine();
            while ((m_userInput != "y") && (m_userInput != "Y") && (m_userInput != "n") && (m_userInput != "N"))
            {
                Console.WriteLine("Type Y or N and hit the return key. \n");
                m_userInput = Console.ReadLine();
            }
            if (m_userInput == "Y" || m_userInput == "y")
            {
                m_result = true;
            }
            else
            {
                m_result = false;
            }
            return m_result;
        }
        
        // assign user's input to game value
        static int determineChoice(string m_userInput)
        {
            int m_result;
            switch (m_userInput)
            {
                case "1":
                    m_result = 0;
                    break;
                case "2":
                    m_result = 1;
                    break;
                case "3":
                    m_result = 2;
                    break;
                case "4":
                    m_result = 3;
                    break;
                case "5":
                    m_result = 4;
                    break;
                case "6":
                    m_result = 5;
                    break;
                default:
                    m_result = 6;
                    break;
            }
            return m_result;
        }
    }
}
