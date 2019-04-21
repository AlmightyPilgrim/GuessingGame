using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Run
    {
        public void RunProg()
        {
            GuessMethods guessMe = new GuessMethods();

            guessMe.GuessOneTen();
            Console.Clear();
            guessMe.PersonGuess();
            Console.Clear();
            guessMe.ComputerGuess();
        }
    }
}
