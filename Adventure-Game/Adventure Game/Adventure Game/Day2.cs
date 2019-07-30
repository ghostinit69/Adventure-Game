using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game
{
    class Day2
    {
        static bool Run = true;
        private int aChoice;
        public void dDay2()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("       ______     ___   __  __     ___    ");
            Console.WriteLine("       |_ __ |   | _ |  | |_| |   /   |   ");
            Console.WriteLine("       | |  | | | |_| |  |   |    |_| |   ");
            Console.WriteLine("       | |__| | |  _  |   | |      / /   _   _   _");
            Console.WriteLine("       |_____|  |_| |_|   |_|     |___| |_| |_| |_|");
            Console.WriteLine("\n\n");
            Console.WriteLine("    It's 1:30 pm, you wake up after a long night of partying and take a peek outside.  It's beautiful outside...");
            Console.WriteLine("How would you like to spend your day?");
            Console.WriteLine("\n\n");
            Console.WriteLine(" 1) Head to your significant other's house.");
            Console.WriteLine(" 2) Enjoy a day at the beach. ");
            Console.WriteLine(" 3) You're tired of playing and you want to end it.");
            aChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (aChoice == 3)
            {
                GameOver Ending1 = new GameOver();
                Ending1.GameOverRip();
                Run = false;
            }
            else
            {
                switch (aChoice)
                {
                    case 1:

                        GfHouse Scenerio1 = new GfHouse();
                        Scenerio1.girlsHouse();
                        break;

                    case 2:
                        Beach Scenerio2 = new Beach();
                        Scenerio2.beach();
                        break;

                    default:
                        GameOver whyGraphics = new GameOver();
                        whyGraphics.WhyWrongNum();

                        Console.WriteLine("             Why can't you enter a number between 1-4?!?!?");
                        Console.WriteLine("             Press ENTER to try again! ");
                        Console.ReadLine();
                        Console.Clear();
                        Game.Menu();
                        break;
                }
            }
        }
    }
}
