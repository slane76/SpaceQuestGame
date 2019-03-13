using System;

/*
namespace MySandBox
{ }
*/
namespace CharacterSelect
{
    public class SpaceProgram
    {
        static void Main(string[] args)
        {
            string userGreeting = "";
            int userResponse = 0;

            Console.WriteLine("Welcome to the Make it rain space game!!! We would like to thank you for joining our space program\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Please Enter Your Name\n");
            userGreeting = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------------------------------\n");


            Console.WriteLine($"Greetings {userGreeting}, Time to select your explorer. Would you like to see player Bios first?\nPress (1) for YES and (2) for NO\n");
            userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------------------------------------\n");

            if (userResponse == 1)
            {
                Console.WriteLine("Please select the player that you would like to view or Select 5 to chose a character.\n");
                Console.WriteLine("-------------------------------------------------------------------------------------------------\n");

                Console.WriteLine("Option 1.) Cynthia: Planet Earth\n ");
                Console.WriteLine("Option 2.) Jasmine: Planet Proxima B\n ");
                Console.WriteLine("Option 3.) FLEX: Planet ALPHA Centuri\n ");
                Console.WriteLine("Option 4.) J-RON: Planet Titain AE\n ");
                Console.WriteLine("Option 5.) Select a player\n ");
                Console.WriteLine("Option 6.) Exit Game\n ");

                Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
                userResponse = Convert.ToInt32(Console.ReadLine());

                if (userResponse == 1)
                {
                    Cynthia();
                }
                else if (userResponse == 2)
                {
                    Jasmine();
                }
                else if (userResponse == 3)
                {
                    FLEX();
                }
                else if (userResponse == 4)
                {
                    JRON();
                }
                else if (userResponse == 5)
                {
                    playerSelect();
                }
                else if (userResponse == 6)
                {
                    exitGame();
                }
                else
                {
                    Console.WriteLine("Invalid entry, please select a valid player...");
                }
            }
            else if (userResponse == 2)
            {
                playerSelect();
            }
            else
            {
                Console.WriteLine("Invalid entry, please select a valid player...");
            }
        }
        private static void Cynthia()
        {
            int userResponse = 0;

            Console.Clear();

            Console.WriteLine("Cynthia is a 20 year old Federal officer of the law from planet earth. She is single with no kids.\n");
            Console.WriteLine("Cynthia grew up in New Jersey the the oldest of two siblings, her brother (18) and her sister (15).\n");
            Console.WriteLine("Cynthia graduated early from highschool and college at the top of her class and fluent in 6 languages\n");
            Console.WriteLine("and a blackbelt in three different martial arts. She currently works with the Special Assignment Unit.\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Strentgh: Navigation\n");
            Console.WriteLine("Weakness: \n");
            Console.WriteLine("Agility: 7 out of 10\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Cynthia's father was an astronaut who's space shuddle disappeared on a mission and he and  the crew was \n ");
            Console.WriteLine("never heard from again. She beleives that by joining this program she will be able to find him and finally\n");
            Console.WriteLine("bring him home\n ");

            Console.WriteLine("---------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("What would you like to do now? Select (1) to select player, (2) to view another player");
            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                playerSelect();
            }
            if (userResponse == 2)
            {
                viewPlayer();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }





        }

        private static void Jasmine()
        {
            int userResponse = 0;

            Console.Clear();


            Console.WriteLine("Cynthia is a 20 year old Federal officer of the law from planet earth. She is single with no kids.\n");
            Console.WriteLine("Cynthia grew up in New Jersey the the oldest of two siblings, her brother (18) and her sister (15).\n");
            Console.WriteLine("Cynthia graduated early from highschool and college at the top of her class and fluent in 6 languages\n");
            Console.WriteLine("and a blackbelt in three different martial arts.\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Strentgh: 6 out of 10");
            Console.WriteLine("Weakness: ");
            Console.WriteLine("Agility: 7 out of 10\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Cynthia's father was an astronaut who's space shuddle disappeared on a mission and he and  the crew was \n" +
                              "never heard from again. She beleives that by joining this program she will be able to find him and finally\n" +
                              "bring him home\n");

            Console.WriteLine("What would you like to do now? Select (1) to select player, (2) to view another player");
            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                playerSelect();
            }
            if (userResponse == 2)
            {
                viewPlayer();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }





        }

        private static void FLEX()
        {
            int userResponse = 0;

            Console.Clear();


            Console.WriteLine("Cynthia is a 20 year old Federal officer of the law from planet earth. She is single with no kids.\n");
            Console.WriteLine("Cynthia grew up in New Jersey the the oldest of two siblings, her brother (18) and her sister (15).\n");
            Console.WriteLine("Cynthia graduated early from highschool and college at the top of her class and fluent in 6 languages\n");
            Console.WriteLine("and a blackbelt in three different martial arts.\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Strentgh: 6 out of 10");
            Console.WriteLine("Weakness: ");
            Console.WriteLine("Agility: 7 out of 10\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Cynthia's father was an astronaut who's space shuddle disappeared on a mission and he and  the crew was \n" +
                              "never heard from again. She beleives that by joining this program she will be able to find him and finally\n" +
                              "bring him home\n");

            Console.WriteLine("What would you like to do now? Select (1) to select player, (2) to view another player");
            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                playerSelect();
            }
            if (userResponse == 2)
            {
                viewPlayer();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }





        }

        private static void JRON()
        {
            int userResponse = 0;

            Console.Clear();

            Console.WriteLine("Cynthia is a 20 year old Federal officer of the law from planet earth. She is single with no kids.\n");
            Console.WriteLine("Cynthia grew up in New Jersey the the oldest of two siblings, her brother (18) and her sister (15).\n");
            Console.WriteLine("Cynthia graduated early from highschool and college at the top of her class and fluent in 6 languages\n");
            Console.WriteLine("and a blackbelt in three different martial arts.\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Strentgh: 6 out of 10");
            Console.WriteLine("Weakness: ");
            Console.WriteLine("Agility: 7 out of 10\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Cynthia's father was an astronaut who's space shuddle disappeared on a mission and he and  the crew was \n" +
                              "never heard from again. She beleives that by joining this program she will be able to find him and finally\n" +
                              "bring him home\n");

            Console.WriteLine("What would you like to do now? Select (1) to select player, (2) to view another player");
            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                playerSelect();
            }
            if (userResponse == 2)
            {
                viewPlayer();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }





        }

        private static void viewPlayer()
        {
            int userResponse = 0;

            Console.Clear();

            Console.WriteLine("Please select the player that you would like to view or Select 5 to chose a character.\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Option 1.) Cynthia: Planet Earth\n ");
            Console.WriteLine("Option 2.) Jasmine: Planet Proxima B\n ");
            Console.WriteLine("Option 3.) FLEX: Planet ALPHA Centuri\n ");
            Console.WriteLine("Option 4.) J-RON: Planet Titain AE\n ");
            Console.WriteLine("Option 5.) Select a player\n ");
            Console.WriteLine("Option 6.) Exit Game\n ");


            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                Cynthia();
            }
            else if (userResponse == 2)
            {
                Jasmine();
            }
            else if (userResponse == 3)
            {
                FLEX();
            }
            else if (userResponse == 4)
            {
                JRON();
            }
            else if (userResponse == 5)
            {
                playerSelect();
            }
            else if (userResponse == 6)
            {
                exitGame();
            }
            else
            {
                Console.WriteLine("Unknown Player, please select a valid player...");

            }
        }

        private static void playerSelect()
        {
            int userResponse = 0;

            Console.Clear();

            Console.WriteLine("Please select your player\n ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Option 1.) Cynthia: Planet Earth\n ");
            Console.WriteLine("Option 2.) Jasmine: Planet Proxima B\n ");
            Console.WriteLine("Option 3.) FLEX: Planet ALPHA Centuri\n ");
            Console.WriteLine("Option 4.) J-RON: Planet Titain AE\n ");
            Console.WriteLine("Option 5.) View player BIO\n ");
            Console.WriteLine("Option 6.) Exit Game\n ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 5)
            {
                viewPlayer();
            }
            else if (userResponse == 6)
            {
                exitGame();
            }
            
        }

        private static void exitGame()
        {
            //Money earned, distance traveled, age to date, goods aquired
            Console.Clear();

            exitGame();
        }
    }
}
