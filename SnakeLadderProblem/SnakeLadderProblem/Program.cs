//Console.WriteLine("Welcome To Snake And Ladder Problem");
using System;
namespace SnakeAndLadderProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Snake And Ladder Game========");
            Console.WriteLine("Initital Position of both Players is 0");
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.StartGame();
            Console.ReadLine();
        }
    }
}