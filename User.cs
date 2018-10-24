using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class User : Player
    {
        public User() : base("User")
        {

        }
        public override string GenRPS()
        {

            Console.WriteLine("Select Rock, Paper, or Scissors:(r, p or s) ");
            string userInput = Console.ReadLine();
            if (userInput == "r")
            {
                return RPS.Rock;
            }
            if (userInput == "p")
            {
                return RPS.Paper;
            }
            if (userInput == "s")
            {
                return RPS.Scissors;
            }
            return RPS.Rock;
        }
    }
}
