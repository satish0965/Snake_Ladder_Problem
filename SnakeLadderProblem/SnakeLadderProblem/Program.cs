//Console.WriteLine("Welcome To Snake And Ladder Problem");
using System;
namespace SnakeAndLadderProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Snake And Ladder Game========");
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.StartGame();
            Console.ReadLine();
        }
    }
}