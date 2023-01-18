using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Roller
    {
        //get a random number between 1-6, twice
        public int[] Rolls ()
        {
            int[] diceRolls = new int[2];
            Random r = new Random();
            diceRolls[0] = r.Next(1, 7);
            diceRolls[1] = r.Next(1, 7);

            return diceRolls;
        }

    }
}
