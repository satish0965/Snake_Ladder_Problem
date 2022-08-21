using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    public class SnakeAndLadder
    {
        public int PlayerPosition1 = 0;
        public int PlayerPosition2 = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Winning = 100;
        public int StartPoint = 0;
        public int DieCountPlayer1 = 0;
        public int DieCountPlayer2 = 0;
        public int TotalDieCount = 0;


        public void StartGame()
        {
            Console.WriteLine(" Game Started ");

            Random random = new Random();

            while (PlayerPosition1 != Winning || PlayerPosition2 != Winning)
            {
            Player1Chance:
                int DieRolled = random.Next(1, 7);
                Console.Write(" Dice Rolled for Player1: {0} ", DieRolled);

                int Option1 = random.Next(0, 3);
                Console.WriteLine(" Move Option : " + Option1);

                TotalDieCount++;
                DieCountPlayer1++;

                switch (Option1)
                {
                    case No_Play:
                        Console.WriteLine(" No Play");
                        break;
                    case Ladder:
                        PlayerPosition1 += DieRolled;

                        if (PlayerPosition1 > Winning)
                        {
                            PlayerPosition1 -= DieRolled;
                            Console.WriteLine("Can't move ahead of 100");
                            break;

                        }
                        Console.WriteLine("Player1 got Ladder, New Position : {0}", PlayerPosition1);
                        goto Player1Chance;


                    case Snake:
                        PlayerPosition1 -= DieRolled;
                        if (PlayerPosition1 < 0)
                        {
                            PlayerPosition1 = StartPoint;
                        }
                        Console.WriteLine("Player1 got Snake, New Position : {0}", PlayerPosition1);
                        break;
                }
            Player2Chance:
                DieRolled = random.Next(1, 7);
                Console.Write(" Dice Rolled for Player2: {0} ", DieRolled);

                int Option2 = random.Next(0, 3);
                Console.WriteLine(" Move Option : " + Option2);

                TotalDieCount++;
                DieCountPlayer2++;

                switch (Option2)
                {
                    case No_Play:
                        Console.WriteLine(" No Play");
                        break;
                    case Ladder:
                        PlayerPosition2 += DieRolled;

                        if (PlayerPosition2 > Winning)
                        {
                            PlayerPosition2 -= DieRolled;
                            Console.WriteLine("Can't move ahead of 100");
                            break;

                        }
                        Console.WriteLine("Player2 got Ladder, New Position : {0}", PlayerPosition2);
                        goto Player2Chance;


                    case Snake:
                        PlayerPosition2 -= DieRolled;
                        if (PlayerPosition2 < 0)
                        {
                            PlayerPosition2 = StartPoint;
                        }
                        Console.WriteLine("Player2 got Snake, New Position : {0}", PlayerPosition2);
                        break;
                }
            }
            if (PlayerPosition1 == Winning)
            {
                Console.WriteLine("Congratulations Player1 won the Game");
            }
            else
            {
                Console.WriteLine("Congratulations Player2 won the Game");

            }
            Console.WriteLine("Total Number of Die thrown: " + TotalDieCount);
            Console.WriteLine("Total Number of Die thrown by Player1: " + DieCountPlayer1);
            Console.WriteLine("Total Number of Die thrown by Player2: " + DieCountPlayer2);

        }
    }
}