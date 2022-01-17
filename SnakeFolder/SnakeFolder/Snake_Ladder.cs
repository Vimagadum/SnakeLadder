using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeFolder
{
    public class Snake_Ladder
    {   
        //To get random value
        Random random = new Random();
        //to store the current position 
        int curposition = 0;
        const int MAX_POSITION = 100;
        int diceValue;
        int ranOption;
        //to store dicecount 
        int DiceCount;


        public void game()
        {

            //Writing loop to repeat a method till the position reaches max position
            while (curposition <= MAX_POSITION)
            {
                diceValue = random.Next(1, 7);
                if (curposition >= 0 && curposition < 100)
                {
                    ranOption = random.Next(0, 3);

                    if (ranOption == 0)
                    {
                        Console.WriteLine("no play");
                        DiceCount++;
                    }

                    else if (ranOption == 1)
                    {
                        if (curposition + diceValue <= 100)
                        {
                            curposition = curposition + diceValue;
                            Console.WriteLine("Ladder");
                            DiceCount++;
                        }

                        else
                        {
                            Console.WriteLine(" ramin in same position");
                            DiceCount++;
                        }
                    }

                    else if (ranOption == 2)
                    {
                        if (curposition - diceValue <= 0)
                        {
                            curposition = 0;
                            DiceCount++;
                        }
                        else
                        {
                            curposition -= diceValue;
                            Console.WriteLine("Snake");
                            DiceCount++;
                        }
                    }
                    Console.WriteLine(curposition);
                    Console.WriteLine(DiceCount);
                    Console.WriteLine();
                }


            }
        }

    }
}