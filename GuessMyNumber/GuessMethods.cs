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

        // this will be set to 1000, if larger numbers are needed
        // an additional variable will be needed (for another time)
        public int ComputerFirstGuess(int guess, int limit)
        {
            guess = limit / 2;
            return guess;
        }

        // guess where the value is less than guess
        public int ComputerLessThanGuesses(int guess, int limit)
        {
            guess = guess - (guess / 2); 
            return guess;
        }

        // guesses where the value is greater than guess
        public int ComputerGreaterGuesses(int guess, int limit)
        {
            guess = (guess + limit) / 2;
            return guess;
        }

        // first part of the assignment
        public void GuessOneTen()
        {
            Random rnd = new Random();
            int guess = 1;
            int value = rnd.Next(1, 11);
            bool checker = false;

            do
            {
                // catching the execption before running through the code and breaking the system
                UserEntry(guess);
                CompareValues(guess, value);
                if (guess == value)
                {
                    checker = true;
                }

            } while (checker == false);


        }

        // method for player guessing (might be needing the log)
        public void PersonGuess()
        {
            Random rnd = new Random();
            int guess = 1;
            int value = rnd.Next(1, 1001);
            // needs equation (log thing) to track how many chances are left
            do
            {
                UserEntry(guess);
                CompareValues(guess, value);

            } while (guess != value);
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
                    ComputerFirstGuess(guess, limit);
                }
                else if (guess < value)
                {
                    ComputerLessThanGuesses(guess, limit);
                }
                else
                {
                    ComputerGreaterGuesses(guess, limit);
                }
                count++;
            } while (guess != value);

            Console.WriteLine($"The computer took {count} guesses to succeed");
        }
    }
}
