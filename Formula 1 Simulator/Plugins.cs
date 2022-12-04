﻿using Meta;

namespace Plugins
{
    class Program
    {
        public static void Help()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valid commands are:");
            Console.WriteLine("'grid'");
            Console.WriteLine("'specs'");
            Console.WriteLine("'driver standings'");
            Console.WriteLine("'team standings'");
            Console.WriteLine("'(driver)' or '(team)' to find stats and info on a certain driver or team");
            Console.WriteLine("'clear' - clears up the console so you can stay focused on the present!");
            Console.WriteLine();
            Console.WriteLine();
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
            //loop2
            TeamMode:
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What do you wish to learn about " + currentteam.name + "?");
                ConsoleKeyInfo help = Console.ReadKey(true);
                if (help.Key == ConsoleKey.Backspace)
                {
                    //break;
                }
                else if (help.Key == ConsoleKey.H)
                {
                    Console.WriteLine("Valid commands here are:");
                    Console.WriteLine("'info' - to learn more about them");
                    Console.WriteLine("'ratings' - displays the overall and in depth ratings of this teams car");
                    Console.WriteLine("'stats' - shows accumulated statistics since the season start");
                    Console.WriteLine("'Backspace' - to return to general command mode");
                    goto TeamMode;
                }
                string input = Console.ReadLine()!;
                Console.ForegroundColor = ConsoleColor.White;
                if (input.ToLower() == "info")
                {
                    Console.WriteLine(currentteam.name + " is " + currentteam.prefix + " Formula 1 team based in " + currentteam.hq + ".");
                    Console.WriteLine("They have been in the sport for " + currentteam.age + " years.");
                    Console.WriteLine(currentteam.principal + " is currently the team principal of " + currentteam.name + ".");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (input.ToLower() == "ratings" || input.ToLower() == "rating")
                {
                    Console.WriteLine(currentteam.name + " uses the " + currentteam.engine + " power unit as their internal combustion engine.");
                    Console.WriteLine("Ratings:");
                    Console.WriteLine("              Overall performance:   " + currentteam.performance);
                    Console.WriteLine("ICE Power:  " + currentteam.power + "     ICE Reliability: " + currentteam.reliability);
                    Console.WriteLine("Downforce:  " + currentteam.downforce + "     Drag:  " + currentteam.drag);
                    Console.WriteLine("Traction:  " + currentteam.traction + "     Grip:  " + currentteam.grip);
                    Console.WriteLine("Tyre degradation:  " + currentteam.degradation);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (input.ToLower() == "stats")
                {
                    Console.WriteLine(currentteam.name + " currently has " + currentteam.wins + " wins, " + currentteam.podiums + " podiums, and " + currentteam.points + " points this season.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("'" + input + "'" + " is not a valid command, please try again");
                    Console.WriteLine();
                    Console.WriteLine();
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
            //loop2
            DriverMode:
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What do you want to find out about " + currentdriver.name + "?");
                ConsoleKeyInfo help = Console.ReadKey(true);
                if (help.Key == ConsoleKey.Backspace)
                {
                    //break;
                }
                else if (help.Key == ConsoleKey.H)
                {
                    Console.WriteLine("Valid commands here are:");
                    Console.WriteLine("'info' - to learn more about him");
                    Console.WriteLine("'ratings' - displays the drivers overall and other detailed ratings");
                    Console.WriteLine("'stats' - shows different statistics since the season start");
                    Console.WriteLine("'Backspace' - to return to general command mode");
                    goto DriverMode;
                }
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
                    Console.WriteLine("           Overall skill:   " + currentdriver.overall);
                    Console.WriteLine("Pace:       " + currentdriver.pace + "     Consistency: " + currentdriver.consistency);
                    Console.WriteLine("Racecraft:  " + currentdriver.racecraft + "     Experience:  " + currentdriver.experience);
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
            }

            //loop
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter a command or press 'Backspace' to exit command mode:");
            ConsoleKeyInfo exit = Console.ReadKey(true);
            if (exit.Key == ConsoleKey.Backspace)
            {
                goto exit;
            }
            else if (exit.Key == ConsoleKey.H)
            {
                Help();
            }
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
                }
            }
            if (input.ToLower() == "grid")
            {
                if (grid == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗" +
                                  "\r\n║                         Current grid lineup                         ║" +
                                  "\r\n╠═══════════════════════════════╦══════════════════╦══════════════════╣" +
                                  "\r\n║             Team              ║    1st Driver    ║    2nd Driver    ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 21 + "m" + "Oracle Red Bull Racing" + "\x1b[38;5;" + 15 + "m" + "        ║ " + "\x1b[38;5;" + 21 + "m" + driver1.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 21 + "m" + driver2.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 196 + "m" + "Scuderia Ferrari" + "\x1b[38;5;" + 15 + "m" + "              ║ " + "\x1b[38;5;" + 196 + "m" + driver3.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 196 + "m" + driver4.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 50 + "m" + "Mercedes-AMG Petronas" + "\x1b[38;5;" + 15 + "m" + "        ║ " + "\x1b[38;5;" + 50 + "m" + driver5.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 50 + "m" + driver6.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 39 + "m" + "BWT Alpine" + "\x1b[38;5;" + 15 + "m" + "                    ║ " + "\x1b[38;5;" + 39 + "m" + driver7.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 39 + "m" + driver8.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 208 + "m" + "McLaren" + "\x1b[38;5;" + 15 + "m" + "                       ║ " + "\x1b[38;5;" + 208 + "m" + driver9.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 208 + "m" + driver10.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 124 + "m" + "Alfa Romeo Orlen" + "\x1b[38;5;" + 15 + "m" + "              ║ " + "\x1b[38;5;" + 124 + "m" + driver11.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 124 + "m" + driver12.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 30 + "m" + "Aston Martin Aramco Cognizant" + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 30 + "m" + driver13.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 30 + "m" + driver14.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 11 + "m" + "Haas" + "\x1b[38;5;" + 15 + "m" + "                          ║ " + "\x1b[38;5;" + 11 + "m" + driver15.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 11 + "m" + driver16.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 240 + "m" + "Scuderia AlphaTauri" + "\x1b[38;5;" + 15 + "m" + "           ║ " + "\x1b[38;5;" + 240 + "m" + driver17.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 240 + "m" + driver18.name + "\x1b[38;5;" + 15 + "m" + " ║" +
                                  "\r\n╠═══════════════════════════════╬══════════════════╬══════════════════╣" +
                                  "\r\n║ " + "\x1b[38;5;" + 26 + "m" + "Williams Racing" + "\x1b[38;5;" + 15 + "m" + "               ║ " + "\x1b[38;5;" + 26 + "m" + driver19.name + "\x1b[38;5;" + 15 + "m" + " ║ " + "\x1b[38;5;" + 26 + "m" + driver20.name + "\x1b[38;5;" + 15 + "m" + " ║" +
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
                                  "\r\n║ " + "\x1b[38;5;" + 21 + "m" + "Red Bull" + "\x1b[38;5;" + 15 + "m" + "     ║ " + "\x1b[38;5;" + 21 + "m" + "RB18" + "\x1b[38;5;" + 15 + "m" + "    ║ " + "\x1b[38;5;" + 21 + "m" + "Red Bull Powertrains" + "\x1b[38;5;" + 15 + "m" + " ║" +
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
                /*
                Console.WriteLine("The standings in the F1 Drivers Championship:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Leader  " + driver + "  " + points);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("P2  " + driver + "  " + points);
                Console.WriteLine("P3  " + driver + "  " + points);
                Console.WriteLine("P4  " + driver + "  " + points);
                Console.WriteLine("P5  " + driver + "  " + points);
                Console.WriteLine("P6  " + driver + "  " + points);
                Console.WriteLine("P7  " + driver + "  " + points);
                Console.WriteLine("P8  " + driver + "  " + points);
                Console.WriteLine("P9  " + driver + "  " + points);
                Console.WriteLine("P10  " + driver + "  " + points);
                Console.WriteLine("P11  " + driver + "  " + points);
                Console.WriteLine("P12  " + driver + "  " + points);
                Console.WriteLine("P13  " + driver + "  " + points);
                Console.WriteLine("P14  " + driver + "  " + points);
                Console.WriteLine("P15  " + driver + "  " + points);
                Console.WriteLine("P16  " + driver + "  " + points);
                Console.WriteLine("P17  " + driver + "  " + points);
                Console.WriteLine("P18  " + driver + "  " + points);
                Console.WriteLine("P19  " + driver + "  " + points);
                Console.WriteLine("P20  " + driver + "  " + points);
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (input.ToLower() == "team standings")
            {
                Console.WriteLine("The standings in the F1 Constructors Championship:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Leader  " + team + "  " + points);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("P2  " + team + "  " + points);
                Console.WriteLine("P3  " + team + "  " + points);
                Console.WriteLine("P4  " + team + "  " + points);
                Console.WriteLine("P5  " + team + "  " + points);
                Console.WriteLine("P6  " + team + "  " + points);
                Console.WriteLine("P7  " + team + "  " + points);
                Console.WriteLine("P8  " + team + "  " + points);
                Console.WriteLine("P9  " + team + "  " + points);
                Console.WriteLine("P10  " + team + "  " + points);
                Console.WriteLine();
                Console.WriteLine();
                */
            }
            else if (input.ToLower() == "clear")
            {
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("'" + input + "'" + " is not a valid command, please try again");
            }
            CommandMode(eRedBull, eFerrari, eMercedes, eRenault,
                RedBull, Ferrari, Mercedes, Alpine, Mclaren, AlfaRomeo, AstonMartin, Haas, AlphaTauri, Williams,
                ver, per, lec, sai, ham, rus, alo, oco, nor, ric, bot, zho, vet, str, mag, msc, gas, tsu, alb, lat,
                drivers, rdrivers,
                car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18, car19, car20,
                driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8, driver9, driver10, driver11, driver12, driver13, driver14, driver15, driver16, driver17, driver18, driver19, driver20,
                chosenteams, chosendrivers, currentteam, currentdriver,
                grid, specs);
        exit:
            Console.WriteLine("Exited command mode");
        }
    }
}