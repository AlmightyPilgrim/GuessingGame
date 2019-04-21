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
        public void UserEntry(ref int guess, int limit)
        {
            try
            {
                Console.WriteLine($"Guess a number between 1 and {limit}");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry");
            }
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

        // this will be set to 1000, if larger numbers are needed
        // an additional variable will be needed (for another time)
        public void ComputerFirstGuess(ref int guess, int limit)
        {
            guess = limit / 2;            
        }

        // guess where the value is less than guess
        public void ComputerLessThanGuesses(ref int guess, ref int limit)
        {
            // setting limit equal to guess to attempt to lower the likelihood of never ending loop
            // due to limit always being greater than the previous guesses that were smaller than
            // limit but larger than value
            limit = guess;
            guess = guess - (guess / 2);             
        }

        // guesses where the value is greater than guess
        public void ComputerGreaterGuesses(ref int guess, int limit)
        {
            guess = (guess + limit) / 2;            
        }

        // first part of the assignment
        public void GuessOneTen()
        {
            Random rnd = new Random();
            int guess = 1;
            int limit = 10;
            int value = rnd.Next(1, (limit + 1));
            bool checker = false;

            do
            {
                // catching the execption before running through the code and breaking the system
                UserEntry(ref guess, limit);
                CompareValues(guess, value);
                if (guess == value)
                {
                    checker = true;
                }

            } while (checker == false);
            Console.WriteLine("CORRECT!!");
        }

        // method for player guessing (might be needing the log)
        public void PersonGuess()
        {
            Random rnd = new Random();
            int guess = 1;
            int limit = 1000;
            int value = rnd.Next(1, (limit + 1));
            // needs equation (log thing) to track how many chances are left
            do
            {
                UserEntry(ref guess, limit);
                CompareValues(guess, value);

            } while (guess != value);
            Console.WriteLine("CORRECT!!!");
        }

        // method for computer guessing
        public void ComputerGuess()
        {
            int guess = 1;
            int value = 0;
            int count = 1;
            int limit = 1000;

            try
            {
                Console.WriteLine($"Please enter value between 1 and {limit}");
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }

            do
            {
                if (count == 1)
                {
                    ComputerFirstGuess(ref guess, limit);
                }
                else if (guess > value)
                {
                    ComputerLessThanGuesses(ref guess, ref limit);
                }
                else
                {
                    ComputerGreaterGuesses(ref guess, limit);
                }
                count++;
            } while (guess != value);

            Console.WriteLine($"The computer took {count} guesses to succeed");
        }
    }
}
