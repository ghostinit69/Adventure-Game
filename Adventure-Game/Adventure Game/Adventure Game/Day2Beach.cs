using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game
{
    class Day2Beach
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
            Console.WriteLine("       Coming Soon....");
            Console.WriteLine("\n");
            Console.WriteLine("    Congratulations for making it to the second day of your virtual life.  ");
            Console.WriteLine("\n");
            Console.WriteLine("    The fingers of fate are currently planning your demise!");
            Console.WriteLine("\n");
            Console.WriteLine("    Press ENTER to relive the different paths of Day One. ");


            //Console.WriteLine("    After completing the first day, you go to bed early.  When you wakeup, it's 9:30 am and you take a peek outside.  Once again, it's beautiful outside...");
            //Console.WriteLine("\n");
            //Console.WriteLine("  How would you like to spend your day?");
            //Console.WriteLine("\n\n");
            //Console.WriteLine("  1) Enjoy a day at the beach. ");
            //Console.WriteLine("  2) You're tired of playing and you want to end it.");
            //aChoice = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();
            Game.Menu();
            //if (aChoice == 2)
            //{
            //    GameOver Ending1 = new GameOver();
            //    Ending1.GameOverRip();
            //    Run = false;
            //}
            //else
            //{
            //    switch (aChoice)
            //    {
            //        case 1:
            //            Beach Scenerio2 = new Beach();
            //            Scenerio2.beach();
            //            break;

            //        default:
            //            GameOver whyGraphics = new GameOver();
            //            whyGraphics.WhyWrongNum();

            //            Console.WriteLine("             Why can't you enter a number between 1-4?!?!?");
            //            Console.WriteLine("             Press ENTER to try again! ");
            //            Console.ReadLine();
            //            Console.Clear();
            //            Game.Menu();
            //            break;
            //    }
            //}
        }
    }
}
