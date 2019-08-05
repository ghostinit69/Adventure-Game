using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Adventure_Game
{
    class Beach
    {
        static bool Run = true;
        private int aChoice, bChoice;
        public void beach()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("You stroll up to the beach.  Upon entering, you see John soaking up rays on one of the lounge chairs.");
            Console.WriteLine("\n");
            Console.WriteLine("What will you do?");
            Console.WriteLine("\n");
            Console.WriteLine("  1) Lay out and get some sun.");
            Console.WriteLine("  2) Go for a swim.");
            aChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (aChoice == 2)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("    As you look at the ocean water, the sun's reflection sparkles and you decide to go for a swim.");
                Console.WriteLine("  You drop everyone by John and you run off into the water.  The water feels great and next thing you ");
                Console.WriteLine("  know, you're about 50 feet from shore.  You can barely touch the bottome with your toes.  ");
                Console.WriteLine("\n");
                Console.WriteLine("    In the distance, there's a group of people waving at you and yelling.  You smile and wave back unable to hear them...g");
                Console.WriteLine("  But they're not wavin to say hello.  They're waving to get your attention.  By the time you realize what's going on, something catches the");
                Console.WriteLine("  corner of your eye.  You turn and hear what sounds like an air leak.  Next thing you know, you're hit hard in the right side of your rib cage.");
                Console.WriteLine("  The loud and fast sound is suddenly drowned out by the water as you are drug underneathe the water.  You holding what little breath you have left.");
                Console.WriteLine("  But you belt out what little air you had when you see it's a shark that pulling you down.");
                Console.WriteLine("\n");
                Thread.Sleep(4000);

                GameOver SwimScene = new GameOver();
                SwimScene.SharkAttack();

                Console.WriteLine("    Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n");
                GameOver Ending1 = new GameOver();
                Ending1.GameOverRip();
                Console.WriteLine("\n");
                Console.WriteLine("    The authorities conduct a search for you that lasted 4 days.  Unfortunately, you were never found.");
                                           
                Console.ReadLine();
                Console.Clear();
                Game.Menu();
            }
            else
            {
                switch (aChoice)
                {
                    case 1:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("    You set down your belongings, apply some sun screen, and lay down for some rays.");
                        Console.WriteLine("  You awake 4 fours later to the sound of people packing up their stuff.  You must of fell asleep.");
                        Console.WriteLine("\n");
                        Console.WriteLine("    It's time to go home already?  Where did the time go?");
                        Console.WriteLine("  You pack up your things, hop in your vehicle, and head on home.");
                        Console.WriteLine("  It was a nice relaxing day, but the sunburn on your back is killing you.");
                        Console.WriteLine("  Press ENTER to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        Day2Beach BeachDay2 = new Day2Beach();
                        BeachDay2.dDay2();
                        break;

                    default:
                        GameOver whyGraphics = new GameOver();
                        whyGraphics.WhyWrongNum();

                        Console.WriteLine("             You failed to choose a correct path and must go back to day one!");
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
