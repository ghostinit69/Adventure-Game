using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Adventure_Game
{
    class AroundGfHouse
    {
        private int Choice;
        public void WalkAround()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("    You start to walk around the house toward the backyard and you notic movement in one of Patty's windows.");
            Console.WriteLine("  You cannot believe your own eyes.  OMG, it's Patty with another man!");
            Console.WriteLine("\n\n");
            GameOver sex1 = new GameOver();
            sex1.sexyTime();
            Console.WriteLine("\n\n");
            Console.WriteLine("  What do you do?!?");
            Console.WriteLine("\n");
            Console.WriteLine("  1) Get revenge by vandalizing her car.");
            Console.WriteLine("  2) You're tired of her nonsense and you leave.");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (Choice == 1)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("    You run back toward the front of the house.  You can't help looking at Patty's car.");
                Console.WriteLine("  Not too long ago, you remembered her preaching how much she loved her car.  And now you want to destroy that love just as much as she destroyed yours. ");
                Console.WriteLine("\n\n");

                GameOver Knife1 = new GameOver();
                Knife1.Knife();

                Console.WriteLine("\n\n");
                Console.WriteLine("    You run back to your car and pull a knife from under the driver's seat.  You proceed to Patty's car and start stabbing her car tires.");
                Console.WriteLine("  With each stab, you're picturing this stranger penetrating Patty with each stroke.  By the time you come out of the trance, all of her");
                Console.WriteLine("  tire are now flat but you are still enraged from her poor decision to sleep with another man.  So, you decide to start stabbing the guys");
                Console.WriteLine("  shaggin wagon next.");
                Console.WriteLine("\n");
                Console.WriteLine("  Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine("\n\n");
                GameOver Cops1 = new GameOver();
                Cops1.PoliceCar();

                Console.WriteLine("\n\n");
                Console.WriteLine("    While still in the act, a police car show up.  Patty and her fun buddy noticed you slashing away");
                Console.WriteLine("  at their tires and called the cops.");
                Console.WriteLine("    You try to plea with the police officer will waving the knife in the air but the officer sees you as a threat and arrests you.");
                Console.WriteLine("  You can only stare at Patty and her new boy toy while you are handcuffed in the back of the squad car and ultimately, drives you away.");
                Console.WriteLine("\n");
                Console.WriteLine("  Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n\n");
                GameOver Jail1 = new GameOver();
                Jail1.JailCell();

                Console.WriteLine("\n\n");
                Console.WriteLine("    Well, here you are.  After all your rage and discontent, you've found yourself in jail.  You're stuck in a cell with three mean looking");
                Console.WriteLine("  fellows.  You can't help but feel their heavy eyes piercing your very soul.");
                Console.WriteLine("\n");
                Console.WriteLine("  Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n\n");
                GameOver Rip1 = new GameOver();
                Rip1.GameOverRip();

                Console.WriteLine("\n\n");
                Console.WriteLine("    After a short struggle, you find yourself lying on the floor in your own pool of blood.  You can't help but think of the irony. ");
                Console.WriteLine("     You were arrest for stabbing tires and now, you're dying from getting stabbed (several times) in the back.");
                Console.WriteLine("  Press ENTER to continue...");
                Console.ReadLine();
                Game.Menu();
            }
            else if (Choice == 2)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("    Fed up with her BS, you decide to go home and cry yourself to sleep.  .");
                Console.WriteLine("\n\n");
                GameOver Fish1 = new GameOver();
                Fish1.FishTank();
                Console.WriteLine("\n\n");
                Console.WriteLine("    The only living thing to witness the whole event was your fish 'Gumpy'");
                Console.WriteLine("\n\n");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();
                Day2Beach BeachDay2 = new Day2Beach();
                BeachDay2.dDay2();

            }
            
        }
    }
}
