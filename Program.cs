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
           
            Console.WriteLine("Welcome to Rock, Paper,Scissors!");
            Console.ReadLine();
            var Opponent = rps.Opponent();

            
               
            
            
            Console.ReadLine();

        }   
    }
}
