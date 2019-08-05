using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace Adventure_Game
{
    class GfHouse
    {
        static bool Run = true;
        private static int bChoice, cChoice, dChoice;
        
        public void girlsHouse()
        {

            Console.WriteLine("\n\n");
            Console.WriteLine("    You and Patty have been seeing each other for the last two years.  As of lately, she has been dropping small hints of marriage.  ");
            Console.WriteLine("  For the last couple months, you've been talking with your parents about different ways to pop the big question.");
            Console.WriteLine("\n");
            Console.WriteLine("  You get to your significant other's house but there's a strange vehicle in the driveway...");
            GameOver ShagTruck = new GameOver();
            ShagTruck.ShagginWagon();
            Console.WriteLine("\n");
            Console.WriteLine("    The vehicle is a LandRover and you remember seeing one of your significant other's co-workers drive this truck.");
            Console.WriteLine("  As you walk past the truck, you couldn't help but notice the license plate. ");
            Console.WriteLine("\n");
            Console.WriteLine("  You start to get an uneasy feeling...");
            Console.WriteLine("\n");
            Console.WriteLine("  What do you do?");
            Console.WriteLine("\n");
            Console.WriteLine("    1) Knock on the door...");
            Console.WriteLine("    2) Go inside the house...");
            bChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (bChoice == 1)
            {
                GameOver houseDoor = new GameOver();
                houseDoor.FrontGfHouse();
                Console.WriteLine("\n\n");
                Console.WriteLine("    As you walk up to the door, you can hear music playing inside...you knock.  After a few moments, there's no response and the music is still playing.  ");
                Console.WriteLine("  You knock on the door again.  This time you hear the music turn off including some whispering and shuffling.  But no one comes to the door.");
                Console.WriteLine("\n");
                Console.WriteLine("  What will you do?");
                Console.WriteLine("\n");
                Console.WriteLine("    1) Turn the knob and attempt to enter...");
                Console.WriteLine("    2) Walk around the house for signs of life...");
                cChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (cChoice)
                {
                    case 1:
                        Console.WriteLine("\n\n");
                        InsideHouse InsideScene = new InsideHouse();
                        InsideScene.InsideGfHouse();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n\n");
                        AroundGfHouse AroundHouse = new AroundGfHouse();
                        AroundHouse.WalkAround();
                        break;
                    default:
                        GameOver whyGraphics = new GameOver();
                        whyGraphics.WhyWrongNum();
                        Game.Menu();
                        break;
                }
            }
            else if (bChoice == 2)
            {
                Console.WriteLine("\n\n");

                GameOver DoorWalk1 = new GameOver();
                DoorWalk1.FrontGfHouse();

                Console.WriteLine("\n\n");
                Console.WriteLine("    You walk up to the door and turn the knob. ");

                InsideHouse InsideScene = new InsideHouse();
                InsideScene.InsideGfHouse();

                
            }
            else if(bChoice >= 3)
            {
                GameOver whyGraphics = new GameOver();
                whyGraphics.WhyWrongNum();
                
            Console.WriteLine("    You failed to choose a correct path and must go back to day one!");
                Console.WriteLine("    Press ENTER to try again!");
                Console.ReadLine();
                Console.Clear();
                Game.Menu();
            }
        }
    }
}

