using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {

            RoshamboApp rps = new RoshamboApp();
            User u = new User();
            string restart;

            do
            {
                Console.WriteLine("Welcome to Rock, Paper,Scissors!");
                Console.ReadLine();
                Player Opponent = rps.Opponent();

                rps.Gameselect(u, Opponent);
                Console.WriteLine("Do you wish to continue? (Y or N");
                restart = Console.ReadLine();

                
            }while(restart.ToLower() == "y") ;

        }   
    }
}
