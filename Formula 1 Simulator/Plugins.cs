using Meta;
using static Game.Program;

namespace Plugins
{
    class Program
    {
        public class DStandingComparer : IComparer<Driver>
        {
            public int Compare(Driver x, Driver y)
            {
                return y.points.CompareTo(x.points);
            }
        }
        public class TStandingComparer : IComparer<Team>
        {
            public int Compare(Team x, Team y)
            {
                return y.points.CompareTo(x.points);
            }
        }

        public static void Help()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valid general commands are:");
            Console.WriteLine("'grid'");
            Console.WriteLine("'specs'");
            Console.WriteLine("'driver standings'");
            Console.WriteLine("'team standings'");
            Console.WriteLine("'(driver)' or '(team)' to find stats and info on a certain driver or team");
            Console.WriteLine("'clear' - clears up the console so you can stay focused on the present!");
        }

        public static void CommandMode(Engine eRedBull, Engine eFerrari, Engine eMercedes, Engine eRenault,
            Team RedBull, Team Ferrari, Team Mercedes, Team Alpine, Team Mclaren, Team AlfaRomeo, Team AstonMartin, Team Haas, Team AlphaTauri, Team Williams,
            Driver ver, Driver per, Driver lec, Driver sai, Driver ham, Driver rus, Driver alo, Driver oco, Driver nor, Driver ric, Driver bot, Driver zho, Driver vet, Driver str, Driver mag, Driver msc, Driver gas, Driver tsu, Driver alb, Driver lat,
            Driver[] drivers, Driver[] rdrivers,
            Team car1, Team car2, Team car3, Team car4, Team car5, Team car6, Team car7, Team car8, Team car9, Team car10, Team car11, Team car12, Team car13, Team car14, Team car15, Team car16, Team car17, Team car18, Team car19, Team car20,
            Driver driver1, Driver driver2, Driver driver3, Driver driver4, Driver driver5, Driver driver6, Driver driver7, Driver driver8, Driver driver9, Driver driver10, Driver driver11, Driver driver12, Driver driver13, Driver driver14, Driver driver15, Driver driver16, Driver driver17, Driver driver18, Driver driver19, Driver driver20,
            Team[] chosenteams, Driver[] chosendrivers, Team currentteam, Driver currentdriver,
            bool grid, bool specs)
        {
            static void TeamMode(Engine eRedBull, Engine eFerrari, Engine eMercedes, Engine eRenault,
                Team RedBull, Team Ferrari, Team Mercedes, Team Alpine, Team Mclaren, Team AlfaRomeo, Team AstonMartin, Team Haas, Team AlphaTauri, Team Williams,
                Driver ver, Driver per, Driver lec, Driver sai, Driver ham, Driver rus, Driver alo, Driver oco, Driver nor, Driver ric, Driver bot, Driver zho, Driver vet, Driver str, Driver mag, Driver msc, Driver gas, Driver tsu, Driver alb, Driver lat,
                Driver[] drivers, Driver[] rdrivers,
                Team car1, Team car2, Team car3, Team car4, Team car5, Team car6, Team car7, Team car8, Team car9, Team car10, Team car11, Team car12, Team car13, Team car14, Team car15, Team car16, Team car17, Team car18, Team car19, Team car20,
                Driver driver1, Driver driver2, Driver driver3, Driver driver4, Driver driver5, Driver driver6, Driver driver7, Driver driver8, Driver driver9, Driver driver10, Driver driver11, Driver driver12, Driver driver13, Driver driver14, Driver driver15, Driver driver16, Driver driver17, Driver driver18, Driver driver19, Driver driver20,
                Team[] chosenteams, Driver[] chosendrivers, Team currentteam, Driver currentdriver)
            {
                bool loop = true;

                Console.ForegroundColor = ConsoleColor.Green;
            checkpoint2:
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What do you wish to learn about " + currentteam.name + "?");
            fallback2:
                ConsoleKeyInfo cmd = Console.ReadKey(true);
                if (cmd.Key == ConsoleKey.Backspace)
                {
                    loop = false;
                    goto endcmd2;
                }
                else if (cmd.Key == ConsoleKey.Enter)
                {
                    goto entercmd2;
                }
                else if (cmd.Key == ConsoleKey.H)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Valid commands here are:");
                    Console.WriteLine("'info' - to learn more about them");
                    Console.WriteLine("'ratings' - displays the overall and in depth ratings of this teams car");
                    Console.WriteLine("'stats' - shows accumulated statistics since the season start");
                    Console.WriteLine("'Backspace' - to return to general command mode");
                    goto checkpoint2;
                }
                goto fallback2;

            entercmd2:
                Console.Write(">");
                string input = Console.ReadLine()!;
                Console.ForegroundColor = ConsoleColor.White;
                if (input.ToLower() == "info")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(currentteam.name + " is " + currentteam.prefix + " Formula 1 team based in " + currentteam.hq + ".");
                    Console.WriteLine("They have been in the sport for " + currentteam.age + " years.");
                    Console.WriteLine(currentteam.principal + " is currently the team principal of " + currentteam.name + ".");
                }
                else if (input.ToLower() == "ratings" || input.ToLower() == "rating")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(currentteam.name + " ratings:");
                    Console.WriteLine();
                    Console.WriteLine("      Overall performance: " + currentteam.performance);
                    Console.WriteLine("ICE Power: " + currentteam.power + "     ICE Reliability:  " + currentteam.reliability);
                    Console.WriteLine("Downforce: " + currentteam.downforce + "     Aerodynamics:    " + currentteam.drag);
                    Console.WriteLine("Traction:  " + currentteam.traction + "     Tyre degradation: " + currentteam.degradation);
                }
                else if (input.ToLower() == "stats")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(currentteam.name + " currently has " + currentteam.wins + " wins, " + currentteam.podiums + " podiums, and " + currentteam.points + " points this season.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("'" + input + "'" + " is not a valid command, please try again");
                }

            endcmd2:
                if (loop == true)
                {
                    TeamMode(eRedBull, eFerrari, eMercedes, eRenault,
                        RedBull, Ferrari, Mercedes, Alpine, Mclaren, AlfaRomeo, AstonMartin, Haas, AlphaTauri, Williams,
                        ver, per, lec, sai, ham, rus, alo, oco, nor, ric, bot, zho, vet, str, mag, msc, gas, tsu, alb, lat,
                        drivers, rdrivers,
                        car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18, car19, car20,
                        driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8, driver9, driver10, driver11, driver12, driver13, driver14, driver15, driver16, driver17, driver18, driver19, driver20,
                        chosenteams, chosendrivers, currentteam, currentdriver);
                }
                else
                {
                    Console.WriteLine("Returned to command mode");
                }
            }

            static void DriverMode(Engine eRedBull, Engine eFerrari, Engine eMercedes, Engine eRenault,
                Team RedBull, Team Ferrari, Team Mercedes, Team Alpine, Team Mclaren, Team AlfaRomeo, Team AstonMartin, Team Haas, Team AlphaTauri, Team Williams,
                Driver ver, Driver per, Driver lec, Driver sai, Driver ham, Driver rus, Driver alo, Driver oco, Driver nor, Driver ric, Driver bot, Driver zho, Driver vet, Driver str, Driver mag, Driver msc, Driver gas, Driver tsu, Driver alb, Driver lat,
                Driver[] drivers, Driver[] rdrivers,
                Team car1, Team car2, Team car3, Team car4, Team car5, Team car6, Team car7, Team car8, Team car9, Team car10, Team car11, Team car12, Team car13, Team car14, Team car15, Team car16, Team car17, Team car18, Team car19, Team car20,
                Driver driver1, Driver driver2, Driver driver3, Driver driver4, Driver driver5, Driver driver6, Driver driver7, Driver driver8, Driver driver9, Driver driver10, Driver driver11, Driver driver12, Driver driver13, Driver driver14, Driver driver15, Driver driver16, Driver driver17, Driver driver18, Driver driver19, Driver driver20,
                Team[] chosenteams, Driver[] chosendrivers, Team currentteam, Driver currentdriver)
            {
                bool loop = true;

                Console.ForegroundColor = ConsoleColor.Green;
            checkpoint3:
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What do you want to find out about " + currentdriver.name + "?");
            fallback3:
                ConsoleKeyInfo cmd = Console.ReadKey(true);
                if (cmd.Key == ConsoleKey.Backspace)
                {
                    loop = false;
                    goto endcmd3;
                }
                else if (cmd.Key == ConsoleKey.Enter)
                {
                    goto entercmd3;
                }
                else if (cmd.Key == ConsoleKey.H)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Valid commands here are:");
                    Console.WriteLine("'info' - to learn more about him");
                    Console.WriteLine("'ratings' - displays the drivers overall and other detailed ratings");
                    Console.WriteLine("'stats' - shows different statistics since the season start");
                    Console.WriteLine("'Backspace' - to return to general command mode");
                    goto checkpoint3;
                }
                goto fallback3;

            entercmd3:
                Console.Write(">");
                string input = Console.ReadLine()!;
                Console.ForegroundColor = ConsoleColor.White;
                if (input.ToLower() == "info")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(currentdriver.name + " is a " + currentdriver.prefix + " Formula 1 driver.");
                    Console.WriteLine("He is " + currentdriver.age + " years of age.");
                    //andra alternativ när probabilites är fixat (50% chans till första 50% chans till denna): Console.WriteLine(currentdriver.name + " is a " + currentdriver.age + " year old Formula 1 driver from " + currentdriver.nationality);
                }
                else if (input.ToLower() == "ratings" || input.ToLower() == "rating")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(currentdriver.name + " ratings:");
                    Console.WriteLine();
                    Console.WriteLine("       Overall skill: " + currentdriver.overall);
                    Console.WriteLine("Pace:      " + currentdriver.pace + "     Consistency: " + currentdriver.consistency);
                    Console.WriteLine("Racecraft: " + currentdriver.racecraft + "     Experience:  " + currentdriver.experience);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (input.ToLower() == "stats")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(currentdriver.name + " has accumulated " + currentdriver.wins + " wins, " + currentdriver.podiums + " podiums, and " + currentdriver.points + " points since the start of this season.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(input + " is not a valid command, please try again");
                }

            endcmd3:
                if (loop == true)
                {
                    DriverMode(eRedBull, eFerrari, eMercedes, eRenault,
                        RedBull, Ferrari, Mercedes, Alpine, Mclaren, AlfaRomeo, AstonMartin, Haas, AlphaTauri, Williams,
                        ver, per, lec, sai, ham, rus, alo, oco, nor, ric, bot, zho, vet, str, mag, msc, gas, tsu, alb, lat,
                        drivers, rdrivers,
                        car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18, car19, car20,
                        driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8, driver9, driver10, driver11, driver12, driver13, driver14, driver15, driver16, driver17, driver18, driver19, driver20,
                        chosenteams, chosendrivers, currentteam, currentdriver);
                }
                else
                {
                    Console.WriteLine("Returned to command mode");
                }
            }

            bool loop = true;

            Console.ForegroundColor = ConsoleColor.Green;
        checkpoint1:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to enter a command or 'Backspace' to exit command mode:");
        fallback1:
            ConsoleKeyInfo cmd = Console.ReadKey(true);
            if (cmd.Key == ConsoleKey.Backspace)
            {
                loop = false;
                goto endcmd1;
            }
            else if (cmd.Key == ConsoleKey.Enter)
            {
                goto entercmd1;
            }
            else if (cmd.Key == ConsoleKey.H)
            {
                Help();
                goto checkpoint1;
            }
            goto fallback1;

        entercmd1:
            Console.Write(">");
            string input = Console.ReadLine()!;
            for (int i = 0; i < 20; i++)
            {
                if (input.ToLower() == chosendrivers[i].name.ToString().ToLower() || input.ToLower() == chosendrivers[i].firstname.ToString().ToLower() || input.ToLower() == chosendrivers[i].lastname.ToString().ToLower() || input.ToLower() == chosendrivers[i].shortname.ToString().ToLower())
                {
                    currentdriver = chosendrivers[i];
                    DriverMode(eRedBull, eFerrari, eMercedes, eRenault,
                        RedBull, Ferrari, Mercedes, Alpine, Mclaren, AlfaRomeo, AstonMartin, Haas, AlphaTauri, Williams,
                        ver, per, lec, sai, ham, rus, alo, oco, nor, ric, bot, zho, vet, str, mag, msc, gas, tsu, alb, lat,
                        drivers, rdrivers,
                        car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18, car19, car20,
                        driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8, driver9, driver10, driver11, driver12, driver13, driver14, driver15, driver16, driver17, driver18, driver19, driver20,
                        chosenteams, chosendrivers, currentteam, currentdriver);
                    goto checkpoint1;
                }
                else if (input.ToLower() == chosenteams[i].name.ToString().ToLower())
                {
                    currentteam = chosenteams[i];
                    TeamMode(eRedBull, eFerrari, eMercedes, eRenault,
                        RedBull, Ferrari, Mercedes, Alpine, Mclaren, AlfaRomeo, AstonMartin, Haas, AlphaTauri, Williams,
                        ver, per, lec, sai, ham, rus, alo, oco, nor, ric, bot, zho, vet, str, mag, msc, gas, tsu, alb, lat,
                        drivers, rdrivers,
                        car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18, car19, car20,
                        driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8, driver9, driver10, driver11, driver12, driver13, driver14, driver15, driver16, driver17, driver18, driver19, driver20,
                        chosenteams, chosendrivers, currentteam, currentdriver);
                    goto checkpoint1;
                }
            }
            if (input.ToLower() == "grid")
            {
                if (grid == true)
                {
                    string[] t = new string[20];

                    for (int i = 0; i < t.Length; i++)
                    {
                        t[i] = " ║ ";
                        for (int y = 0; y < 16 - chosendrivers[i].name.Length; y++)
                        {
                            t[i] = " " + t[i];
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗" +
                                  "\r\n║                         Current grid lineup                         ║" +
                                  "\r\n╠═══════════════════════════════╦══════════════════╦══════════════════╣" +
                                  "\r\n║             Team              ║    1st Driver    ║    2nd Driver    ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 4 + "m" + "Oracle Red Bull Racing" + "\x1b[38;5;" + 15 + "m" + "        ║ " + "\x1b[38;5;" + 4 + "m" + driver1.name + "\x1b[38;5;" + 15 + "m" + t[0] + "\x1b[38;5;" + 4 + "m" + driver2.name + "\x1b[38;5;" + 15 + "m" + t[1] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 196 + "m" + "Scuderia Ferrari" + "\x1b[38;5;" + 15 + "m" + "              ║ " + "\x1b[38;5;" + 196 + "m" + driver3.name + "\x1b[38;5;" + 15 + "m" + t[2] + "\x1b[38;5;" + 196 + "m" + driver4.name + "\x1b[38;5;" + 15 + "m" + t[3] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes-AMG Petronas" + "\x1b[38;5;" + 15 + "m" + "         ║ " + "\x1b[38;5;" + 50 + "m" + driver5.name + "\x1b[38;5;" + 15 + "m" + t[4] + "\x1b[38;5;" + 50 + "m" + driver6.name + "\x1b[38;5;" + 15 + "m" + t[5] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 39 + "m" + "BWT Alpine" + "\x1b[38;5;" + 15 + "m" + "                    ║ " + "\x1b[38;5;" + 39 + "m" + driver7.name + "\x1b[38;5;" + 15 + "m" + t[6] + "\x1b[38;5;" + 39 + "m" + driver8.name + "\x1b[38;5;" + 15 + "m" + t[7] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 208 + "m" + "McLaren" + "\x1b[38;5;" + 15 + "m" + "                       ║ " + "\x1b[38;5;" + 208 + "m" + driver9.name + "\x1b[38;5;" + 15 + "m" + t[8] + "\x1b[38;5;" + 208 + "m" + driver10.name + "\x1b[38;5;" + 15 + "m" + t[9] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 124 + "m" + "Alfa Romeo Orlen" + "\x1b[38;5;" + 15 + "m" + "              ║ " + "\x1b[38;5;" + 124 + "m" + driver11.name + "\x1b[38;5;" + 15 + "m" + t[10] + "\x1b[38;5;" + 124 + "m" + driver12.name + "\x1b[38;5;" + 15 + "m" + t[11] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 30 + "m" + "Aston Martin Aramco Cognizant" + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 30 + "m" + driver13.name + "\x1b[38;5;" + 15 + "m" + t[12] + "\x1b[38;5;" + 30 + "m" + driver14.name + "\x1b[38;5;" + 15 + "m" + t[13] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 11 + "m" + "Haas" + "\x1b[38;5;" + 15 + "m" + "                          ║ " + "\x1b[38;5;" + 11 + "m" + driver15.name + "\x1b[38;5;" + 15 + "m" + t[14] + "\x1b[38;5;" + 11 + "m" + driver16.name + "\x1b[38;5;" + 15 + "m" + t[15] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 240 + "m" + "Scuderia AlphaTauri" + "\x1b[38;5;" + 15 + "m" + "           ║ " + "\x1b[38;5;" + 240 + "m" + driver17.name + "\x1b[38;5;" + 15 + "m" + t[16] + "\x1b[38;5;" + 240 + "m" + driver18.name + "\x1b[38;5;" + 15 + "m" + t[17] +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 26 + "m" + "Williams Racing" + "\x1b[38;5;" + 15 + "m" + "               ║ " + "\x1b[38;5;" + 26 + "m" + driver19.name + "\x1b[38;5;" + 15 + "m" + t[18] + "\x1b[38;5;" + 26 + "m" + driver20.name + "\x1b[38;5;" + 15 + "m" + t[19] +
                                  "\r\n╚═══════════════════════════════╩══════════════════╩══════════════════╝");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This seasons grid has not been revealed yet!");
                }
            }
            else if (input.ToLower() == "specs")
            {
                if (specs == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("╔═══════════════════════════════════════════════╗" +
                                  "\r\n║            Technical specifications           ║" +
                                  "\r\n╠══════════════╦═════════╦══════════════════════╣" +
                                  "\r\n║     Team     ║ Chassis ║      Power unit      ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 4 + "m" + "Red Bull" + "\x1b[38;5;" + 15 + "m" + "     ║ " + "\x1b[38;5;" + 4 + "m" + "RB18" + "\x1b[38;5;" + 15 + "m" + "    ║ " + "\x1b[38;5;" + 4 + "m" + "Red Bull Powertrains" + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 196 + "m" + "Ferrari" + "\x1b[38;5;" + 15 + "m" + "      ║ " + "\x1b[38;5;" + 196 + "m" + "F1-75" + "\x1b[38;5;" + 15 + "m" + "   ║ " + "\x1b[38;5;" + 196 + "m" + "Ferrari" + "\x1b[38;5;" + 15 + "m" + "              ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes" + "\x1b[38;5;" + 15 + "m" + "     ║ " + "\x1b[38;5;" + 50 + "m" + "W13" + "\x1b[38;5;" + 15 + "m" + "     ║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes" + "\x1b[38;5;" + 15 + "m" + "             ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 39 + "m" + "Alpine" + "\x1b[38;5;" + 15 + "m" + "       ║ " + "\x1b[38;5;" + 39 + "m" + "A522" + "\x1b[38;5;" + 15 + "m" + "    ║ " + "\x1b[38;5;" + 39 + "m" + "Renault" + "\x1b[38;5;" + 15 + "m" + "              ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 208 + "m" + "McLaren" + "\x1b[38;5;" + 15 + "m" + "      ║ " + "\x1b[38;5;" + 208 + "m" + "MCL36" + "\x1b[38;5;" + 15 + "m" + "   ║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes" + "\x1b[38;5;" + 15 + "m" + "             ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 124 + "m" + "Alfa Romeo" + "\x1b[38;5;" + 15 + "m" + "   ║ " + "\x1b[38;5;" + 124 + "m" + "C41" + "\x1b[38;5;" + 15 + "m" + "     ║ " + "\x1b[38;5;" + 196 + "m" + "Ferrari" + "\x1b[38;5;" + 15 + "m" + "              ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 30 + "m" + "Aston Martin" + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 30 + "m" + "AMR22" + "\x1b[38;5;" + 15 + "m" + "   ║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes" + "\x1b[38;5;" + 15 + "m" + "             ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 11 + "m" + "Haas" + "\x1b[38;5;" + 15 + "m" + "         ║ " + "\x1b[38;5;" + 11 + "m" + "VF-22" + "\x1b[38;5;" + 15 + "m" + "   ║ " + "\x1b[38;5;" + 196 + "m" + "Ferrari" + "\x1b[38;5;" + 15 + "m" + "              ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 240 + "m" + "AlphaTauri" + "\x1b[38;5;" + 15 + "m" + "   ║ " + "\x1b[38;5;" + 240 + "m" + "AT03" + "\x1b[38;5;" + 15 + "m" + "    ║ " + "\x1b[38;5;" + 21 + "m" + "Red Bull Powertrains" + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠══════════════╬═════════╬══════════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 26 + "m" + "Williams" + "\x1b[38;5;" + 15 + "m" + "     ║ " + "\x1b[38;5;" + 26 + "m" + "FW44" + "\x1b[38;5;" + 15 + "m" + "    ║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes" + "\x1b[38;5;" + 15 + "m" + "             ║" +
                                  "\r\n╚══════════════╩═════════╩══════════════════════╝");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The teams haven't announced this years cars yet!");
                }
            }
            else if (input.ToLower() == "driver standings")
            {
                Driver[] standingdrivers = new[]
                {
                    driver1,
                    driver2,
                    driver3,
                    driver4,
                    driver5,
                    driver6,
                    driver7,
                    driver8,
                    driver9,
                    driver10,
                    driver11,
                    driver12,
                    driver13,
                    driver14,
                    driver15,
                    driver16,
                    driver17,
                    driver18,
                    driver19,
                    driver20
                };

                Array.Sort(standingdrivers, new DStandingComparer());

                string[] t = new string[20];
                string[] u = new string[20];

                for (int i = 0; i < t.Length; i++)
                {
                    t[i] = " ║ ";
                    for (int y = 0; y < 16 - standingdrivers[i].name.Length; y++)
                    {
                        t[i] = " " + t[i];
                    }
                }

                for (int i = 0; i < t.Length; i++)
                {
                    u[i] = " ║ ";
                    for (int y = 0; y < 3 - standingdrivers[i].points.ToString().Length; y++)
                    {
                        u[i] = " " + u[i];
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔═════════════════════════════════╗" +
                              "\r\n║     F1 Drivers Championship     ║" +
                              "\r\n╠════════╦══════════════════╦═════╣" +
                              "\r\n║ Pos.   ║      Driver      ║ Pts ║" +
                              "\r\n╠════════╬══════════════════╬═════╣" +
                              "\r\n║ Leader ║ " + standingdrivers[0].color + standingdrivers[0].name + "\x1b[38;5;" + 15 + "m" + t[0] + standingdrivers[0].points + u[0] +
                              "\r\n║ P2     ║ " + standingdrivers[1].color + standingdrivers[1].name + "\x1b[38;5;" + 15 + "m" + t[1] + standingdrivers[1].points + u[1] +
                              "\r\n║ P3     ║ " + standingdrivers[2].color + standingdrivers[2].name + "\x1b[38;5;" + 15 + "m" + t[2] + standingdrivers[2].points + u[2] +
                              "\r\n║ P4     ║ " + standingdrivers[3].color + standingdrivers[3].name + "\x1b[38;5;" + 15 + "m" + t[3] + standingdrivers[3].points + u[3] +
                              "\r\n║ P5     ║ " + standingdrivers[4].color + standingdrivers[4].name + "\x1b[38;5;" + 15 + "m" + t[4] + standingdrivers[4].points + u[4] +
                              "\r\n║ P6     ║ " + standingdrivers[5].color + standingdrivers[5].name + "\x1b[38;5;" + 15 + "m" + t[5] + standingdrivers[5].points + u[5] +
                              "\r\n║ P7     ║ " + standingdrivers[6].color + standingdrivers[6].name + "\x1b[38;5;" + 15 + "m" + t[6] + standingdrivers[6].points + u[6] +
                              "\r\n║ P8     ║ " + standingdrivers[7].color + standingdrivers[7].name + "\x1b[38;5;" + 15 + "m" + t[7] + standingdrivers[7].points + u[7] +
                              "\r\n║ P9     ║ " + standingdrivers[8].color + standingdrivers[8].name + "\x1b[38;5;" + 15 + "m" + t[8] + standingdrivers[8].points + u[8] +
                              "\r\n║ P10    ║ " + standingdrivers[9].color + standingdrivers[9].name + "\x1b[38;5;" + 15 + "m" + t[9] + standingdrivers[9].points + u[9] +
                              "\r\n║ P11    ║ " + standingdrivers[10].color + standingdrivers[10].name + "\x1b[38;5;" + 15 + "m" + t[10] + standingdrivers[10].points + u[10] +
                              "\r\n║ P12    ║ " + standingdrivers[11].color + standingdrivers[11].name + "\x1b[38;5;" + 15 + "m" + t[11] + standingdrivers[11].points + u[11] +
                              "\r\n║ P13    ║ " + standingdrivers[12].color + standingdrivers[12].name + "\x1b[38;5;" + 15 + "m" + t[12] + standingdrivers[12].points + u[12] +
                              "\r\n║ P14    ║ " + standingdrivers[13].color + standingdrivers[13].name + "\x1b[38;5;" + 15 + "m" + t[13] + standingdrivers[13].points + u[13] +
                              "\r\n║ P15    ║ " + standingdrivers[14].color + standingdrivers[14].name + "\x1b[38;5;" + 15 + "m" + t[14] + standingdrivers[14].points + u[14] +
                              "\r\n║ P16    ║ " + standingdrivers[15].color + standingdrivers[15].name + "\x1b[38;5;" + 15 + "m" + t[15] + standingdrivers[15].points + u[15] +
                              "\r\n║ P17    ║ " + standingdrivers[16].color + standingdrivers[16].name + "\x1b[38;5;" + 15 + "m" + t[16] + standingdrivers[16].points + u[16] +
                              "\r\n║ P18    ║ " + standingdrivers[17].color + standingdrivers[17].name + "\x1b[38;5;" + 15 + "m" + t[17] + standingdrivers[17].points + u[17] +
                              "\r\n║ P19    ║ " + standingdrivers[18].color + standingdrivers[18].name + "\x1b[38;5;" + 15 + "m" + t[18] + standingdrivers[18].points + u[18] +
                              "\r\n║ P20    ║ " + standingdrivers[19].color + standingdrivers[19].name + "\x1b[38;5;" + 15 + "m" + t[19] + standingdrivers[19].points + u[19] +
                              "\r\n╚════════╩══════════════════╩═════╝");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (input.ToLower() == "team standings")
            {
                Team[] standingteams = new[]
                {
                    car1,
                    car3,
                    car5,
                    car7,
                    car9,
                    car11,
                    car13,
                    car15,
                    car17,
                    car19,
                };

                Array.Sort(standingteams, new TStandingComparer());

                string[] t = new string[10];
                string[] u = new string[10];

                for (int i = 0; i < t.Length; i++)
                {
                    t[i] = "  ║ ";
                    for (int y = 0; y < 12 - standingteams[i].name.Length; y++)
                    {
                        t[i] = " " + t[i];
                    }
                }

                for (int i = 0; i < t.Length; i++)
                {
                    u[i] = " ║ ";
                    for (int y = 0; y < 3 - standingteams[i].points.ToString().Length; y++)
                    {
                        u[i] = " " + u[i];
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔══════════════════════════════╗" +
                              "\r\n║ F1 Constructors Championship ║" +
                              "\r\n╠════════╦═══════════════╦═════╣" +
                              "\r\n║ Pos.   ║     Team      ║ Pts ║" +
                              "\r\n╠════════╬═══════════════╬═════╣" +
                              "\r\n║ Leader ║ " + standingteams[0].color + standingteams[0].name + "\x1b[38;5;" + 15 + "m" + t[0] + standingteams[0].points + u[0] +
                              "\r\n║ P2     ║ " + standingteams[1].color + standingteams[1].name + "\x1b[38;5;" + 15 + "m" + t[1] + standingteams[1].points + u[1] +
                              "\r\n║ P3     ║ " + standingteams[2].color + standingteams[2].name + "\x1b[38;5;" + 15 + "m" + t[2] + standingteams[2].points + u[2] +
                              "\r\n║ P4     ║ " + standingteams[3].color + standingteams[3].name + "\x1b[38;5;" + 15 + "m" + t[3] + standingteams[3].points + u[3] +
                              "\r\n║ P5     ║ " + standingteams[4].color + standingteams[4].name + "\x1b[38;5;" + 15 + "m" + t[4] + standingteams[4].points + u[4] +
                              "\r\n║ P6     ║ " + standingteams[5].color + standingteams[5].name + "\x1b[38;5;" + 15 + "m" + t[5] + standingteams[5].points + u[5] +
                              "\r\n║ P7     ║ " + standingteams[6].color + standingteams[6].name + "\x1b[38;5;" + 15 + "m" + t[6] + standingteams[6].points + u[6] +
                              "\r\n║ P8     ║ " + standingteams[7].color + standingteams[7].name + "\x1b[38;5;" + 15 + "m" + t[7] + standingteams[7].points + u[7] +
                              "\r\n║ P9     ║ " + standingteams[8].color + standingteams[8].name + "\x1b[38;5;" + 15 + "m" + t[8] + standingteams[8].points + u[8] +
                              "\r\n║ P10    ║ " + standingteams[9].color + standingteams[9].name + "\x1b[38;5;" + 15 + "m" + t[9] + standingteams[9].points + u[9] +
                              "\r\n╚════════╩═══════════════╩═════╝");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (input.ToLower() == "clear")
            {
                Console.Clear();
                Console.WriteLine("Cleared console");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("'" + input + "'" + " is not a valid command, please try again");
            }

        endcmd1:
            if (loop == true)
            {
                CommandMode(eRedBull, eFerrari, eMercedes, eRenault,
                    RedBull, Ferrari, Mercedes, Alpine, Mclaren, AlfaRomeo, AstonMartin, Haas, AlphaTauri, Williams,
                    ver, per, lec, sai, ham, rus, alo, oco, nor, ric, bot, zho, vet, str, mag, msc, gas, tsu, alb, lat,
                    drivers, rdrivers,
                    car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18, car19, car20,
                    driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8, driver9, driver10, driver11, driver12, driver13, driver14, driver15, driver16, driver17, driver18, driver19, driver20,
                    chosenteams, chosendrivers, currentteam, currentdriver,
                    grid, specs);
            }
            else
            {
                Console.WriteLine("Exited command mode");
            }
        }
    }
}
