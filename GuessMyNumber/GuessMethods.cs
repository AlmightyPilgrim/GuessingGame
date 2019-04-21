using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    public class GuessMethods
    {        
        // remove redundant code for user guess and or choice
        public int UserEntry(int guess)
        {
            try
            {
                Console.WriteLine("Guess a number between 1 and 10");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry");
            }
            return guess;
        }

        // method to take and compare the guess with the set value
        // value will always be the number in which guess is compared to
        // even when sides switch from player guessing to computer.
        public void CompareValues(int guess, int value)
        {
            if (guess <= value)
            {
                Console.WriteLine("Higher");
            }
            else if (guess >= value)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }

        public void GuessOneTen()
        {
            Random rnd = new Random();
            int guess = 1;
            int value = rnd.Next(1, 11);

            do
            {
                // catching the execption before running through the code and breaking the system
                UserEntry(guess);
                CompareValues(guess, value);
            } while (guess != value);


        }

        public void PersonGuess()
        {
            Random rnd = new Random();
            int guess = 1;
            int value = rnd.Next(1, 1001);

            do
            {
                UserEntry(guess);
                CompareValues(guess, value);
            } while (guess != value);
        }

        public void ComputerGuess()
        {
            int guess;
            int value;
        }
    }
}
