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
        }

        public void Board()
        {
            //at the start
            Start();
        }
    }
}
