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
            Console.WriteLine("    It's 1:30 pm, you wake up after a long night of partying and take a peek outside.  It's beautiful a great day to be alive!");
            Console.WriteLine("How would you like to spend your day?");
            Console.WriteLine("\n\n");
            Console.WriteLine(" 1) Head to your significant other's house.");
            Console.WriteLine(" 2) Enjoy a day at the beach. ");
            Console.WriteLine(" 3) Meet your friend John at the pool. ");
            Console.WriteLine(" 4) You're tired of playing and you want to end it.");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            if (Choice == 4)
            {
                GameOver Ending1 = new GameOver();
                Ending1.gameOver();
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

                    case 3:
                        Console.WriteLine("C content...");
                        //content here....
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("        ,");
                        Console.WriteLine("  (`-.-/(           .:::::.,");
                        Console.WriteLine("   `-.__)           /  ``:::: .               /7_.-,");
                        Console.WriteLine("       '. -.       -  - `:::'           .- (  `_.=");
                        Console.WriteLine("         :  `--._   /   _?'`      ___.-'   -`'''");
                        Console.WriteLine("          :         -  / )----'''' -    .-'");
                        Console.WriteLine("           `--..   `--' ,'           .-'");
                        Console.WriteLine("                `:   --'       )---''");
                        Console.WriteLine("                  |           )");
                        Console.WriteLine("                  |          _|");
                        Console.WriteLine("                  |           |");
                        Console.WriteLine("                   L          /");
                        Console.WriteLine("                   |          |");
                        Console.WriteLine("                   )__     _   |");
                        Console.WriteLine("                    | `---' `--'");
                        Console.WriteLine("                     L         |");
                        Console.WriteLine("                     |   |      |");
                        Console.WriteLine("                      |   L     )");
                        Console.WriteLine("                       L_ (      |");
                        Console.WriteLine("                       |   |  .  J");
                        Console.WriteLine("                       |    `.    |");
                        Console.WriteLine("                    _.-`--='  |    )");
                        Console.WriteLine("                   (   _-'     `--'|");
                        Console.WriteLine("                    '''        / ' J");
                        Console.WriteLine("                              (,_./");
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
            Console.WriteLine("\n\n");
            Console.WriteLine("   For maximum enjoyment, go to full screen!");
            Console.WriteLine("\n");
            Console.WriteLine("           Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("             You're about to embark on a journey...");
            Thread.Sleep(2500);
            Console.WriteLine("\n\n");
            Console.WriteLine("                     For some people, the future is bright...");
            Thread.Sleep(2500);
            Console.WriteLine("\n\n");
            Console.WriteLine("                             But for others, they will head down a dark path...");
            Thread.Sleep(3000);
            
            Console.WriteLine("\n\n\n\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("     ______   __  __   _____  ");
            Console.WriteLine("     |__ __|  | | | |  |  __| ");
            Console.WriteLine("       | |    | |_| |  | |_   ");
            Console.WriteLine("       | |    |  _  |  |  _|  ");
            Console.WriteLine("       |_|    |_| |_|  |____| ");
            Console.WriteLine("\n");
            Console.WriteLine("              ____   __   __    _____   ___   ____   _____  ");
            Console.WriteLine("             /  __|  | |  | |  |  __ |  | |  /  __|  |  __| ");
            Console.WriteLine("             | |     | |__| |  | | | |  | |  | |     | |_   ");
            Console.WriteLine("             | |__   |  __  |  | |_| |  | |  | |__   |  _|  ");
            Console.WriteLine("             |____|  |_|  |_|  |_____|  |_|  |____|  |____| ");
            Console.WriteLine("\n");
            Console.WriteLine("                      _____     _____   __  __   ______  ");
            Console.WriteLine("                     /  ___|  /  _  |  /  |/  |  |  ___| ");
            Console.WriteLine("                     | |  _   | |_| |  |  |   |  | |_    ");
            Console.WriteLine("                     | |_| |  | | | |  |  __  |  |  _|   ");
            Console.WriteLine("                     |_____|  |_| |_|  |_/  |_|  |_____| ");
            Console.WriteLine("\n\n");
            Console.WriteLine("                                    Proceed at your own risk...");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            Game.Menu();
        }
    }
}
