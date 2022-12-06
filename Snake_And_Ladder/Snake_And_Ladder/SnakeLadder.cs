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
            while (playerOne <= 100) //loop until playerOne reaches 100
            {
               int checkwin = CheckWin(playerOne);
                if (checkwin == 1) //player has reached exact 100th position
                {
                    Console.WriteLine($"playerOne wins!!");// display win message
                    break; //End the game
                }
                if (checkwin == 2) // player reaches over hundred than do No play
                {
                    position = 0;
                }
                else // else continue game
                {
                    position = RollDie();
                }
                // No play condition
                if (position == 0)
                {
                    Console.WriteLine("its a no play");
                    playerOne += position;// player get no play then remain at same place
                }

                //snake condition
                if (playerOne == 0 && position < 0) //when player is at start  
                {
                    Console.WriteLine("its a snake bite @ 0");
                    playerOne = 0; //if player gets snake bite, player remain at same place
                }
                if (playerOne > 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite");
                    playerOne += position; //if player is at position less than 6 and gets snake bite
                    if (playerOne < 0)
                    {
                        //if player position is below 0
                        playerOne = 0;
                    }
                }

                //ladder condition
                if (position > 0)
                {
                    Console.WriteLine("its a ladder");
                    playerOne += position;
                }
                if (playerOne > 100)//player position is greater than 100
                {
                    playerOne -= position; // do no play
                }
                Console.WriteLine($"player One rolls die and get position {playerOne}");
            }
        }
        public int CheckWin(int playerOne)
        {
            if (playerOne == 100) //check for 100th position
                return 1;
            if (playerOne > 100) //check for over 100th position
                return 2;
            else // continue game
                return 0;
        }



        readonly Random random = new Random();
        int diceThrown = 0;
        public int RollDie()
        {
            int dice, check;
            dice = random.Next(1, 7);
            diceThrown++;
            Console.WriteLine($"Dice = {dice}");
            check = CheckPlay();
            //Roll die to produce random number between 1-6
            if (check == 1)
                return -dice; //snake bite
            if (check == 2)
                return dice; //ladder
            else
                return 0; // No play
        }

        public int CheckPlay()
        {
            //generate Check play using random
            int check = random.Next(1, 4);
            return check;
        }

        public void Board()
            {
                //at the start
                Start();
            Console.WriteLine($"Number of Times Dice Thrown: {diceThrown}");
        }
        
    }
}
