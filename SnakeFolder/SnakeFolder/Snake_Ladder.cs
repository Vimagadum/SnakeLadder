using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeFolder
{
    public class Snake_Ladder
    {
        int FirstPlayerPosition;

        Random random = new Random();
        int ranOption;
        public void game()
        {
            //First player starting from position 0
            FirstPlayerPosition = 0;
            //Taking random value of Dice from 1-6
            int DiceValue = random.Next(1, 7);

            ranOption = random.Next(0, 3);

            if (ranOption == 0)
            {
                Console.WriteLine("no play");
                FirstPlayerPosition += FirstPlayerPosition;
            }
            else if (ranOption == 1)
            {
                Console.WriteLine("Ladder");
                FirstPlayerPosition = FirstPlayerPosition + DiceValue;
            }
            else
            {
                Console.WriteLine("Snake");
                FirstPlayerPosition = FirstPlayerPosition + DiceValue;
            }
        }
    }
}
