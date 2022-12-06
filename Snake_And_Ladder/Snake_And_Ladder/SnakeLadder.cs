using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    internal class SnakeLadder
    {
        public void Start()
        {
            //implementing single player start at 0.
            //variables
            int position = 0;
            int playerOne;
            //initialize player
            playerOne = position;
            Console.WriteLine($"player One position is {playerOne}");
            playerOne = RollDie();
            Console.WriteLine($"player One rolls die and get position {playerOne}");
        }
        public int RollDie()
        {
            //Roll die to produce random number between 1-6
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }

        public void Board()
        {
            //at the start
            Start();
        }
    }
}
