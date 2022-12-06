// See https://aka.ms/new-console-template for more information
using Snake_And_Ladder;
using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Snake and Ladder game*********");
            SnakeLadder game = new SnakeLadder();
            game.Board();
        }
    }
}
