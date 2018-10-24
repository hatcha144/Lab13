using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Player
    {
     
        string name;
        string RPSvalue;

        public Player(string name)
        {
            this.name = name;
        }
    public virtual string GenRPS()
        {
            return RPS.Rock;
        }
        
}
}
