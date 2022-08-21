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
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Winning = 100;
        int StartPoint = 0;
        public void StartGame()
        {
            Console.WriteLine(" Game Started ");
            Console.WriteLine(" PlayerPosition :" + PlayerPosition);
            Random random = new Random();

            while (StartPoint < Winning)
            {
                int DieRolled = random.Next(1, 7);
                int Option = random.Next(0, 3);
                switch (Option)
                {
                    case No_Play:
                        Console.WriteLine(" No Play");
                        break;
                    case Ladder:
                        StartPoint += DieRolled;
                        Console.WriteLine(" Dice Rolls Number : +{0} ", DieRolled);
                        Console.WriteLine(" Got Ladder : " + StartPoint);
                        Console.WriteLine(" PlayerPosition : " + StartPoint);
                        break;
                    case Snake:
                        StartPoint -= DieRolled;
                        Console.WriteLine(" Dice Rolls Number : -{0} ", DieRolled);
                        Console.WriteLine(" Snake Attack : " + StartPoint);

                        if (StartPoint < 0)
                        {
                            StartPoint = 0;

                        }
                        Console.WriteLine(" PlayerPosition : " + StartPoint);
                        break;
                }
                if (StartPoint >= Winning)
                {
                    Console.WriteLine("Playe won");
                    break;
                }
            }
        }
    }
}