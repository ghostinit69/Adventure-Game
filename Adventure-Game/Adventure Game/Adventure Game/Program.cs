using System;
using System.Threading;


namespace Adventure_Game
{
    class Game
    {
        static bool Run = true;
        private static int Choice;
        static bool Goal = false;

        public static void Menu()
        {
            
            Console.WriteLine("\n\n\n");
            Console.WriteLine("       ______     ___   __  __     __    ");
            Console.WriteLine("       |_ __ |   | _ |  | |_| |   /  |   ");
            Console.WriteLine("       | |  | | | |_| |  |   |     | |   ");
            Console.WriteLine("       | |__| | |  _  |   | |     _| |_   _   _   _");
            Console.WriteLine("       |_____|  |_| |_|   |_|    |_____| |_| |_| |_|");
            
            Console.WriteLine("\n\n");
            Console.WriteLine("    It's 1:30 pm, you wake up after a long night of partying and take a peek outside.  It's beautiful day to be alive!");
            Console.WriteLine("How would you like to spend your day?");
            Console.WriteLine("\n\n");
            Console.WriteLine(" 1) Head to your girlfriend Patty's house.");
            Console.WriteLine(" 2) Enjoy a day at the beach. ");
            Console.WriteLine(" 3) You're tired of playing and you want to end it.");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            if (Choice == 3)
            {
                GameOver Ending1 = new GameOver();
                Ending1.GameOverRip();
                Run = false;
            }
            else
            {
                switch (Choice)
                {
                    case 1:

                        GfHouse Scenerio1= new GfHouse();
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
    class Program
    {
        static void Main(string[] args)
        {
            //Into to menu.
            IntroToMenu Menu1 = new IntroToMenu();
            Menu1.MenuIntro();
            
            //Day one scenerio.
            Game.Menu();
        }
    }
}
