using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RoshamboApp
    {
        public Random r = new Random();
        Validator valid = new Validator();
        public virtual Player Opponent()
        {
            Console.WriteLine("Which opponent would you like to face? Rocky or Rando? (1,2)");
            string userSelect = Console.ReadLine();

            if (userSelect == "1")
            {
                return new Rocky();
            }
            if (userSelect == "2")
            {
                return new Rando(r);
            }
            return new Rocky();
        }

        public void Gameselect(Player playerUser, Player playerEnemy) 
        {
            
            string input;
            Console.WriteLine("Please select Rock, Paper, or Scissors (r/p/s)");
            input = Console.ReadLine();
            bool check = valid.rpsChk(input);
            if (check == true)
            {
                string enemyChoice = playerEnemy.GenRPS();
                Console.WriteLine("Enemy chose: " + enemyChoice);
                if (input == "r")//if user inputs rock
                {
                    if (enemyChoice == RPS.Rock)
                    {
                        Console.WriteLine("Tie!");
                    }
                    if (enemyChoice == RPS.Paper)
                    {
                        Console.WriteLine("You lose!");
                    }

                    if (enemyChoice == RPS.Scissors)
                    {
                        Console.WriteLine("You win!");
                    }
                }
                else if (input == "p")//if user inputs paper 
                {
                    if (enemyChoice == RPS.Paper)
                    {
                        Console.WriteLine("Tie!");
                    }
                    if (enemyChoice == RPS.Rock)
                    {
                        Console.WriteLine("You win!");
                    }
                    if (enemyChoice == RPS.Scissors)
                    {
                        Console.WriteLine("You lose!");
                    }
                }
                else if (input == "s")//if user inputs scissors 
                {
                    if (enemyChoice == RPS.Scissors)
                    {
                        Console.WriteLine("Tie!");
                    }
                    if (enemyChoice == RPS.Rock)
                    {
                        Console.WriteLine("You lose!");
                    }
                    if (enemyChoice == RPS.Paper)
                    {
                        Console.WriteLine("You win!");
                    }
                    string userChoice = playerUser.GenRPS();
                    
                }

                else
                {

                    Console.WriteLine("That is not a valid input");
                }



            }
        }
    }
}

