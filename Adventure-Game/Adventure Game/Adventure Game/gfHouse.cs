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
        private static int bChoice;
        private static int cChoice;
        private static int dChoice;
        
        public void girlsHouse()
        {

            Console.WriteLine("\n\n");
            Console.WriteLine("    You and Patty have been seeing each other for the last two years.  As of lately, she has been dropping small hints marriage.  ");
            Console.WriteLine("  For the last couple months, you've been talking with your parents about different ways to pop the big question.");
            Console.WriteLine("\n");
            Console.WriteLine("  You get to your significant other's house but there's a strange vehicle in the driveway...");
            GameOver ShagTruck = new GameOver();
            ShagTruck.ShagginWagon();
            Console.WriteLine("\n");
            Console.WriteLine("    The vehicle is a LandRover and you remember seeing one of your significant other's co-workers drive this truck.");
            Console.WriteLine("As you walk past the truck, you couldn't help but notice the license plate. ");
            Console.WriteLine("\n");
            Console.WriteLine("   You start to get an uneasy feeling...");
            Console.WriteLine("\n");
            Console.WriteLine("   What do you do?");
            Console.WriteLine("\n");
            Console.WriteLine("   1) Knock on the door...");
            Console.WriteLine("   2) Go inside the house...");
            bChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (bChoice == 1)
            {
                GameOver houseDoor = new GameOver();
                houseDoor.FrontGfHouse();
                Console.WriteLine("\n\n");
                Console.WriteLine("    As you walk up to the door, you can hear music playing inside...you knock.  After a few moments, there's no response and the music is still playing.  You knock on the door again.");
                Console.WriteLine("This time you hear the music turn off including some whispering and shuffling.  ");
                cChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (cChoice)
                {
                    case 1:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("    You hear the music stop along with some whispering.  Then she shouts,'Honey, is that you? I'll be right out!'");
                        break;
                    case 2:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\n\n");
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
                Console.WriteLine("    You walk up to the door and turn the knob.  Surprisingly, the door is unlocked and you proceed into the living room.  There's music playing in Patty's bedroom and you notice random clothes scattered on the floor leading to her door.");
                Console.WriteLine("Somethings not right...you start grinding your teeth as you can feel your blood boiling and heart beating in your chest.  All of a sudden, you are bombarded with all your fond memories of Patty and the possiblity she's in the room with another man.");
                Console.WriteLine("\n");
                Console.WriteLine("Remember, you have choices... What will you do?");
                Console.WriteLine("\n");
                Console.WriteLine(" 1)  Call out her name and wait for a response.");
                Console.WriteLine(" 2)  Walk into the bedroom empty handed.");
                Console.WriteLine(" 3)  Get revenge and slash Patty's tires.");
                Console.WriteLine(" 4)  Fetch a knife from the kitchen and proceed into the bedroom.");
                dChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (dChoice)
                {
                    case 1:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("    You hear the music stop along with some whispering.  Then she shouts,'Honey, is that you? I'll be right out!'");
                        Console.WriteLine("\n");
                        Console.WriteLine("  You:  Are you in there with someone?");
                        Console.WriteLine("\n");
                        Console.WriteLine("  With the door still closed,");
                        Console.WriteLine("  Patty:  No, why to you ask?");
                        Console.WriteLine("\n");
                        Console.WriteLine("  There's a strange truck out in the driveway...and I could have swore I hear you talking to someone just a moment ago?");
                        Thread.Sleep(5000);
                        Console.Clear();
                        GameOver saltyKiss = new GameOver();
                        saltyKiss.TheKiss();
                        Console.WriteLine("  Patty opens the door, walks up to you, and give you a kiss.  ");
                        Console.WriteLine("\n");
                        Console.WriteLine("  Patty:  Don't be silly.  You can look inside my room if it'll make you feel better?");
                        Console.WriteLine("\n");
                        Console.WriteLine("  Her lips taste a little salty.  You can feel a little bit of sweat bleeding through her shirt.");
                        Console.WriteLine("\n");
                        Console.WriteLine("  You:  Why is there a truck in your driveway?");
                        Console.WriteLine("\n");
                        Console.WriteLine("  Patty:  It's probably my neighbors truck.  They tend to use my driveway.");
                        Console.WriteLine("\n");
                        Console.WriteLine("As soon as she said that, the truck starts up and drives away.");
                        Console.ReadLine();
                        break;

                    case 2:
                        GameOver sex1 = new GameOver();
                        sex1.sexyTime();
                        Console.WriteLine("    You walk into the music filled bedroom to a horrific sight.  Your girlfriend is on the bed strattling her co-worker as he is pounding away trying to break her hips.");
                        Console.WriteLine("  Both of their eyes are closed as they concentrate on feeling each other's every move and heavy breathing.  Her body language and maons of ecstasy alone is resonating in your head.");
                        Thread.Sleep(10000);
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("    You turn around and walk out of the room before they notice you.  You get into your car, start the engine, and start driving up the street.  ");
                        Console.WriteLine("  At this point, you can't handle all the emotions that are erupting.  Under impulse, you turnaround and drive straight into your newly exgirlfriend's house.  ");
                        Console.WriteLine("  Unfortunately, in all your anguish, you didn't put on your seatbelt which led to you flying through the windshield and instantly killing you on impact.");
                        Thread.Sleep(10000);
                        GameOver Ending1 = new GameOver();
                        Ending1.GameOverRip();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        GameOver knife1 = new GameOver();
                        knife1.Knife();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("    You get your buck knife out of your car and walk over to Patty's vehicle.");
                        Console.WriteLine("  ");
                        Thread.Sleep(10000);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Thread.Sleep(15000);
                        GameOver polCar = new GameOver();
                        polCar.PoliceCar();
                        Console.WriteLine("\n\n");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\n\n");
                        break;
                    default:

                        GameOver whyGraphics = new GameOver();
                        whyGraphics.WhyWrongNum();

                        Console.WriteLine("    You failed to choose a correct path and must go back to day one!");
                        Console.WriteLine("    Press ENTER to try again!");
                        Console.ReadLine();
                        Game.Menu();
                        break;
                }
            }
            else if (bChoice >= 3)
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

