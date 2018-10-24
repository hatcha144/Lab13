using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
    {
        public Validator()
        {

        }
        public bool inRange(int check , int max, int min)
        {
            if (check > min && check < max)
            {
                return true;
            }
            else
            {
                return false; 
            }
        } 
        public int numCheck(string input)
        {
            try
            {
              return int.Parse(input);
            }
            catch
            {
                Console.WriteLine("That is not a valid input");
            }
            return 0;
        }
          public bool opponentChk(string input)
        {
            if(input == "Rando")
            {
                return true;
            }
            if(input == "Rocky")
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
          public bool rpsChk(string input)
        {
            if(input.ToLower() == "r")
            {
                return true;
            }
            if(input.ToLower() == "p")
            {
                return true;
            }
            if(input.ToLower() == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public bool yesNo()
        {
            string restart; 
            do
            {
               Console.WriteLine("Do you wish to continue? (y/n)");
               restart = Console.ReadLine();
                if (restart.ToLower() == "y")
                {
                    return true; 
                }
                else if (restart.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            } while (true);
        }
    }
}

