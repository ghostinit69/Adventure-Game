using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Adventure_Game
{
    class InsideHouse
    {
        public void InsideGfHouse()
        {
            int dChoice;
            Console.WriteLine("\n\n");
            Console.WriteLine("    Surprisingly, the door is unlocked and you proceed into the living room.  There's music playing in Patty's bedroom and you notice random clothes scattered on the floor leading to her door.");
            Console.WriteLine("  Somethings not right...you start grinding your teeth as you can feel your blood boiling and heart beating in your chest.  All of a sudden, you are bombarded with all your fond memories of ");
            Console.WriteLine("  Patty and the possiblity she's in the room with another man.");
            Console.WriteLine("\n");
            Console.WriteLine("  Remember, you have choices... What will you do?");
            Console.WriteLine("\n");
            Console.WriteLine("  1)  Call out her name and wait for a response.");
            Console.WriteLine("  2)  Walk into the bedroom empty handed.");
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
                    Console.WriteLine("  Patty:  No...why do you ask?");
                    Console.WriteLine("\n");
                    Console.WriteLine("  You:  There's a strange truck out in the driveway...and I could have swore I heard you talking to someone just a moment ago?");
                    Console.WriteLine("\n");
                    Console.WriteLine("                                    Press ENTER to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    
                    GameOver saltyKiss = new GameOver();
                    saltyKiss.TheKiss();

                    Console.WriteLine("\n\n");
                    Console.WriteLine("    Patty opens the door, walks up to you, and give you a kiss.  ");
                    Console.WriteLine("\n");
                    Console.WriteLine("  Patty:  Don't be silly.  You can look inside my room if it'll make you feel better?");
                    Console.WriteLine("\n");
                    Console.WriteLine("  Her lips taste a little salty.  You can feel a little bit of sweat bleeding through the back of her shirt.");
                    Console.WriteLine("\n");
                    Console.WriteLine("  You:  Why is there a truck in your driveway?");
                    Console.WriteLine("\n");
                    Console.WriteLine("  Patty:  It's probably my neighbor's truck.  They tend to use my driveway.");
                    Console.WriteLine("\n");
                    Console.WriteLine("  As soon as she said that, the truck starts up and drives away.");
                    Console.WriteLine("\n");
                    Console.WriteLine("    Maybe, it's all in your imagination...Or is it?  Either way, you stay for a quicky and bounce back to your home.");
                    Console.WriteLine("  You might as well get to bed early for a fresh start tomorrow.  As you fall asleep, you think about that damn license plate.");
                    Console.WriteLine("\n");
                    Console.WriteLine("  Press ENTER to continue...");
                    Console.ReadLine();

                    Day2Beach BeachDay2 = new Day2Beach();
                    BeachDay2.dDay2();

                    break;

                case 2:
                    GameOver sex1 = new GameOver();
                    sex1.sexyTime();

                    Console.WriteLine("    You walk into the music filled bedroom to a horrific sight.  Your girlfriend is on the bed strattling her co-worker as he is pounding away trying to break her hips.");
                    Console.WriteLine("  Both of their eyes are closed as they concentrate on feeling each other's every move and heavy breathing.  Her body language and maons of ecstasy alone is resonating in your head.");
                    Thread.Sleep(10000);
                    Console.WriteLine("\n\n");
                    Console.WriteLine("    You turn around and walk out of the room before they notice you.  You get into your car, start the engine, and start driving up the street.  ");
                    Console.WriteLine("  At this point, you can't handle all the emotions that are erupting.  Under impulse, you turnaround and drive straight into your newly exgirlfriend's house.  ");
                    Console.WriteLine("  Unfortunately, in all your anguish, you didn't put on your seatbelt which led to you flying through the windshield and instantly killing you on impact.");
                    Console.WriteLine("\n");
                    Console.WriteLine("    Press ENTER to continue...");

                    GameOver Ending1 = new GameOver();
                    Ending1.GameOverRip();

                    Console.WriteLine("    Press ENTER to continue...");
                    Console.ReadLine();
                    Console.Clear();
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
    }
}

