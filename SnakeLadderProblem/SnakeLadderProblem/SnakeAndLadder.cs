using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    public class SnakeAndLadder
    {
        private int PlayerPosition;
        public void DieRolled()
        {
            Console.WriteLine(" Game Started ");
            Console.WriteLine(" Player Position: {0} ", PlayerPosition);
            Random random = new Random();
            int DieRolled = random.Next(1, 7);
            Console.WriteLine(" Dice Rolled : {0} ", DieRolled);
            PlayerPosition = PlayerPosition + DieRolled;
            Console.WriteLine(" Player Position: {0}", PlayerPosition);
        }
    }
}
