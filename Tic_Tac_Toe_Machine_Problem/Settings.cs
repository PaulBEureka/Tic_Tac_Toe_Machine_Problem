using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Machine_Problem
{

    class Settings
    {
        private int timePerTurn3 = 3, timePerTurn6 = 6, timePerTurn10 = 9;
        private int gameTime3 = 1, gameTime6 = 3, gameTime10 = 5;

        public int TimePerTurn3 { get { return timePerTurn3; } set { timePerTurn3 = value; } }
        public int TimePerTurn6 { get { return timePerTurn6; } set { timePerTurn6 = value; } }
        public int TimePerTurn10 { get { return timePerTurn10; } set { timePerTurn10 = value; } }

        public int GameTime3 { get { return gameTime3; } set { gameTime3 = value; } }
        public int GameTime6 { get { return gameTime6; } set { gameTime6 = value; } }
        public int GameTime10 { get { return gameTime10; } set { gameTime10 = value; } }


        public void GameTimerCustom()
        {
            char clarifyTimer; bool validTimer, timerBreak = true;
            int changeValue;


            do
            {
                try
                {
                    Console.WriteLine($"\nDefault Values: (Easy - {gameTime3} || Normal - {gameTime6} || Hard - {gameTime10})");
                    Console.Write("Adjust Game Time for (1 - Easy, 2 - Normal, 3 - Hard): ");
                    changeValue = int.Parse(Console.ReadLine());

                    if (changeValue != 1 && changeValue != 2 && changeValue != 3)
                    {
                        throw new FormatException();
                    }
                    else
                    {

                        break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input...");
                }

            } while (true);




            do
            {
                Console.Write("\nChange Game Time: ");
                validTimer = int.TryParse(Console.ReadLine(), out int changeGameTime);

                if (validTimer)
                {
                    if (changeGameTime <= 0 || changeGameTime >= 60)
                    {
                        Console.WriteLine("Game Time is not in the range between 2 and 30.");
                    }
                    else
                    {
                        do
                        {
                            try
                            {

                                Console.Write("\nDo you want to readjust your Game Time? ( Y / N ): ");
                                clarifyTimer = Console.ReadLine()[0];

                                if (char.ToUpper(clarifyTimer) == 'Y')
                                {
                                    timerBreak = true;
                                    break;
                                }
                                else if (char.ToUpper(clarifyTimer) == 'N')
                                {
                                    timerBreak = false;

                                    if (changeValue == 1) { GameTime3 = changeGameTime; }
                                    else if (changeValue == 2) { GameTime6 = changeGameTime; }
                                    else if (changeValue == 3) { GameTime10 = changeGameTime; }

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Input must be Y or N");
                                }

                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Invalid Input...");
                            }
                        }
                        while (true);
                    }

                }
                else
                {

                    Console.WriteLine("Your Input must be a digit/number.");
                }

            }
            while (!validTimer || timerBreak == true);


        }


        public void TimerPerTurnCustom()
        {
            char clarifyTPT, upperTPT; int changeValue;
            bool validTPT, breakTPT = true;



            do
            {
                try
                {
                    Console.WriteLine($"\nDefault Values: (Easy - {timePerTurn3} || Normal - {timePerTurn6} || Hard - {timePerTurn10})");
                    Console.Write("Adjust Time Per Turn for (1 - Easy, 2 - Normal, 3 - Hard): ");
                    changeValue = int.Parse(Console.ReadLine());

                    if (changeValue != 1 && changeValue != 2 && changeValue != 3)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input...");
                }

            } while (true);



            do
            {
                Console.Write("\nChange Timer Per Turn: ");
                validTPT = int.TryParse(Console.ReadLine(), out int timePerTurn);

                while (true)
                {
                    if (!validTPT)
                    {
                        Console.WriteLine("Invalid Input...");
                        break;
                    }
                    else if (timePerTurn > 30 || timePerTurn < 3)
                    {
                        Console.WriteLine("Inputted Time per Turn is not in the range between 2 and 30.");
                        break;
                    }
                    else
                    {
                        Console.Write("\nDo you want to readjust your Timer Per Turn? ( Y / N ): ");
                        clarifyTPT = Console.ReadLine()[0];
                        upperTPT = char.ToUpper(clarifyTPT);

                        if (upperTPT == 'Y')
                        {
                            break;
                        }
                        else if (upperTPT == 'N')
                        {
                            breakTPT = false;
                            if (changeValue == 1) { TimePerTurn3 = timePerTurn; }
                            else if (changeValue == 2) { TimePerTurn6 = timePerTurn; }
                            else if (changeValue == 3) { TimePerTurn10 = timePerTurn; }


                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input.\n");
                        }
                    }
                }



            }
            while (!validTPT || breakTPT == true);


        }
    }
}
