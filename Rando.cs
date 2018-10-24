using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Rando : Player
    {
        Random r;

        public Rando(Random r) : base("Rando")
        {
            this.r = r;
        }
        public override string GenRPS()
        {
            int pick = r.Next(0, 3);
            
            switch(pick)
            {
                case 0:
                    return RPS.Rock;

                case 1:
                    return RPS.Paper;

                case 2:
                    return RPS.Scissors;
                   
                default:
                    return RPS.Rock;
                    
            }

            
        }
        
    }
}
