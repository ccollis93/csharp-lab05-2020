using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool valid = true;
            bool player1 = true;

            int uScore = 0;
            int cScore = 0;

            Console.WriteLine("Welcome to PIG! The goal is to be the first to reach 100 points");
            Console.WriteLine("On your turn you will roll a pair of six-sided dice. If no 1's The total of those dice is added to your score,");
            Console.WriteLine("and you may roll again, or end your turn. If a 1 is rolled on one die, you get no score and your turn is over");
            Console.WriteLine("If you roll two 1's your score drops to zero and your turn is over");
            Console.WriteLine();

            int showUScore = PlayerTurn(uScore);
            Console.WriteLine("Your score is " + showUScore);
            Console.WriteLine();

            int showCScore = ComTurn(cScore);
            Console.WriteLine("The Computer's score is " + showCScore);
            Console.WriteLine();

            Console.ReadLine();
        }

       static int PlayerTurn(int uScore)
        {
            Random roller = new Random();

            int dieOne = roller.Next(1, 6);
            int dieTwo = roller.Next(1, 6);

            if (dieOne == 1 || dieTwo == 1)
                return uScore;
            if (dieOne == 1 && dieTwo == 1)
            {
                uScore = 0;
                return uScore;
            }
            else
                uScore = uScore + dieOne + dieTwo;
            return uScore;

        }

       static int ComTurn(int cScore)
        {
            Random roller = new Random();
            int dieOne = roller.Next(1, 6);
            int dieTwo = roller.Next(1, 6);

            if (dieOne == 1 || dieTwo == 1)
                return cScore;
            if (dieOne == 1 && dieTwo == 1)
            {
                cScore = 0;
                return cScore;
            }
            else
                cScore = cScore + dieOne + dieTwo;
            return cScore;
                
        }

       /*static bool DetermineWinner(int uScore, int cScore)
        {
            if(uScore == 100)
            {

            }
            if(cScore == 100)
            {

            }
        } */
    }
}
