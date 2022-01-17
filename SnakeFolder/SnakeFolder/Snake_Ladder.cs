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
        public void game()
        {
            //First player starting from position 0
            FirstPlayerPosition = 0;
            //Taking random value of Dice from 1-6
            int DiceValue = random.Next(1, 7);
        }
    }
}
