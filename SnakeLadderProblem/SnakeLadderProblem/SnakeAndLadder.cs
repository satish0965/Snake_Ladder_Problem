using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    public class SnakeAndLadder
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        private int PlayerPosition;
        public void StartGame()
        {
            Console.WriteLine(" Game Started ");
            Console.WriteLine(" Player Position: {0} ", PlayerPosition);
            Random random = new Random();
            int DieRolled = random.Next(1, 7);
            Console.WriteLine(" Dice Rolled : {0} ", DieRolled);
            PlayerPosition = PlayerPosition + DieRolled;
            Console.WriteLine(" Player Position: {0} ", PlayerPosition);
            int Option = random.Next(0, 3);
            Console.WriteLine(" Dice Value : " + Option);
            switch (Option)
            {
                case No_Play:
                    Console.WriteLine(" No Play");
                    break;
                case Ladder:
                    PlayerPosition += DieRolled;
                    Console.WriteLine(" Got Ladder : " + PlayerPosition);
                    break;
                case Snake:
                    PlayerPosition -= DieRolled;
                    Console.WriteLine(" Snake Attack : " + PlayerPosition);
                    break;
                default:
                    Console.WriteLine(" Invalid Option");
                    break;
            }

        }
    }
}