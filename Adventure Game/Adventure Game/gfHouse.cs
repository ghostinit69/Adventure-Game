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
        
        public void girlsHouse()
        {

            Console.WriteLine("\n\n");
            Console.WriteLine("    You and Patty have been seeing each other for the last two years.  For the last couple months, you've been talking with your parents about different ways to pop the big question.  ");
            Console.WriteLine("You get to your significant other's house but there's a strange vehicle in the driveway...");
            Console.WriteLine("\n");
            Console.WriteLine("    The vehicle is a 2019 Toyota Tacoma and you remember seeing one of your significant other's co-workers drive this truck.");
            Console.WriteLine("You walk past the truck and see the license plate says ");
            Console.WriteLine("__________________________________________________________ ");
            Console.WriteLine("|   _____   __   __    _____    ______  ___  __   __  __  |");
            Console.WriteLine("|  / ____|  | |  | |  |  _  |  /  ____| |  | | |  | | | | |");
            Console.WriteLine("|  | |___   | |__| |  | |_| |  | |  __  |   || |  | | | | |");
            Console.WriteLine("|  |___  |  |  __  |  | __  |  | |__| | | |__  |  | |_| | |");
            Console.WriteLine("|  |_____/  |_|  |_|  |_| |_|  |______| |_|  |_|  |_____| |");
            Console.WriteLine("|_________________________________________________________|");
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
                Console.WriteLine("\n\n");
                Console.WriteLine("    As you walk up to the door, you can hear music playing inside...you knock.  After a few moments, there's no response and the music is still playing.  You knock on the door again.");
                Console.WriteLine("This time you hear the music turn off including some whispering and shuffling.  ");
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
                cChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (cChoice)
                {
                    case 1:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("    You hear the music stop along with some whispering.  Then she shouts,'Honey, is that you? I'll be right out!'");
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                                ||  __                         ");
                        Console.WriteLine("         .=-`__               (`  `)  `-.                      ");
                        Console.WriteLine("        // '^ /               /  o2 _    |                     ");
                        Console.WriteLine("       '//>   < .           .'  --.  `_ /     ");
                        Console.WriteLine("       ///G  .-'/         ./  .-` `._.'   ");
                        Console.WriteLine("       ////.   '        `(/      `         ");
                        Console.WriteLine("       ////   ` |--.-.  c'   -    |         ");
                        Console.WriteLine("       /'.' '   .'  ` |  `-'   |   | .-  .  ");
                        Console.WriteLine("       .(   -- .   * ` .   )    `.  | .   |  ");
                        Console.WriteLine("      /         `     :|.  '    ( >  )     |   ");
                        Console.WriteLine("     /        *  ` . '(| `/ __.  /  /  .    |    ");
                        Console.WriteLine("    /    ` .    .'`.   | _(/,_  ' .'.|    `|     ");
                        Console.WriteLine(".. /     )_ `      .'..-'     `--:    / `.   `|     ");
                        Console.WriteLine("`::   ..'  `._    ..::::.        ) __' _._`.   |     ");
                        Console.WriteLine("  ( `   -.    `-.::::::::)    _.'          `-.  |_    ");
                        Console.WriteLine("   `.     `._ _  :::::<''--  '        `  '    `-. `-._   ");
                        Console.WriteLine("     `-..._  ' ``.`:::::.              _.        `--..----._  ");
                        Console.WriteLine("           `_. .``. `:::::        _..-'  `._..___  .       .)  ");
                        Console.WriteLine("              `.\\`   `::::. ---''               ` --..__`_ / ");
                        Console.WriteLine("                        `::::::           ");
                        Console.WriteLine("                          `::(.      ");
                        Console.WriteLine("                            ::.      ");
                        Console.WriteLine("                            .::     ");
                        Console.WriteLine("                            ''");
                        Console.WriteLine("    You walk into the music filled bedroom to a horrific sight.  Your girlfriend is on the bed strattling her co-worker as he is pounding away trying to break her hips.");
                        Console.WriteLine("  Both of their eyes are closed as they concentrate on feeling each other's every move and heavy breathing.  Her body language and maons of ecstasy alone is resonating in your head.");
                        Thread.Sleep(15000);
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("    You turn around and walk out of the room before they notice you.  You get into your car, start the engine, and start driving up the street.  ");
                        Console.WriteLine("  At this point, you can't handle all the emotions that are erupting.  Under impulse, you turnaround and drive straight into your newly exgirlfriend's house.  ");
                        Console.WriteLine("  Unfortunately, in all your anguish, you didn't put on your seatbelt which led to you flying through the windshield and instantly killing you on impact.");
                        Thread.Sleep(10000);
                        GameOver Ending1 = new GameOver();
                        Ending1.gameOver();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("\n\n");
                        
                        Console.WriteLine("                                   _----..................___");
                        Console.WriteLine("_____,,..,-           _,.--''------'' |   _____  ______________`''--._");
                        Console.WriteLine("`.  :      `.   __..--''              |  /::: / /::::::::::::::|      `|");
                        Console.WriteLine("  `.         `''                      | /____/ /___ ____ _____::|    .  |");
                        Console.WriteLine("    `.                          ,.... |            `    `     :_|   ( )  |");
                        Console.WriteLine("      `.                       /`     `. ,,,''`'- ,.----------.._     `   |");
                        Console.WriteLine("        `.                     |        ,'       `               `-.      |");
                        Console.WriteLine("           `-._                |                                    ``.. /");
                        Console.WriteLine("              `---.............>");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("    You get your buck knife out of your car and walk over to Patty's vehicle.");
                        Console.WriteLine("");
                        Thread.Sleep(15000);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Thread.Sleep(15000);
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                        _____________________    ");
                        Console.WriteLine( "    /  .       .      (<$$$$$$>#####<::::::>)    ");
                        Console.WriteLine("     .      .     ._ / ~~~~~~~~~~~~~~~~~~~~~~~~~|_.       .   .    ");                        Console.WriteLine(".(          . .  /~                             ~| . .   .");
                        Console.WriteLine("  ( . .        .~                                 ~.      .         )");
                        Console.WriteLine("           ()|/_____                           _____|/()   .    .  ).");
                        Console.WriteLine("(         .-''      ~~~~~~~~~~~~~~~~~~~~~~~~~~~     ``-.  ...");
                        Console.WriteLine(".  . . .-~              __________________              ~-.  .    /");
                        Console.WriteLine(" .   ..`~~/~~~~~~~~~~~~TTTTTTTTTTTTTTTTTTTT~~~~~~~~~~~~|~~'    . ) .");
                        Console.WriteLine("    . .| | | #### #### || | | | [] | | | || #### #### | | | .");
                        Console.WriteLine("   (   ;__||___________|++++++++++++++++++|___________|/__;.   .");
                        Console.WriteLine("     .  (~~====___________________________________====~~~)");
                        Console.WriteLine(" ( .  .. |------_____________[ POLICE ]__________-------| ..  .     )");
                        Console.WriteLine("         .  |      ||         ~~~~~~~~       ||      |");
                        Console.WriteLine("             |_____/                          |_____/");
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
                        Console.WriteLine("");
                        Console.WriteLine("    You failed to choose a correct path and must go back to day one!");
                        Console.WriteLine("    Press ENTER to try again!");
                        Console.ReadLine();
                        break;
                }

                
                Game.Menu();
            }
        }
        
    }
}
