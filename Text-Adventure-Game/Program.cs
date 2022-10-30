using System;
using System.Threading;

namespace Text_Adventure_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Text Adventure Game!");
            Console.WriteLine("--------------------------------------------------------");
            InfoOfTheGame();
            Console.WriteLine("--------------------------------------------------------");

            Console.Write("Press ENTER to start");
            Console.ReadLine();

            Console.WriteLine("...");
            Thread.Sleep(1800);

            Console.Clear();

            Forest();
        }

        public static void InfoOfTheGame()
        {
            Console.WriteLine("This is a game were you have to choose between 2 things.");
            Console.WriteLine("The goal is to survive all the obstacles without dying.");
        }

        public static void EndGame()
        {
            Console.WriteLine("Thank You For Playing!");
            Console.WriteLine("Made By Martin Simov");
            Console.WriteLine("Version: 1.0");

            Console.ReadKey();
        }

        public static void Forest()
        {
            Console.WriteLine("You wake up in the forest, not knowing how you got here, but you have a peace of paper that says:");
            Console.WriteLine("\"YOU NEED TO GET TO THE CITY! Follow the path..\"\n");

            Console.Write("Press ENTER to continue");
            Console.ReadLine();

            Thread.Sleep(400);

            Console.Clear();

            Forest1();
        }

        public static void Forest1()
        {
            Console.WriteLine("After 10 minutes of walking in front of you, you see a huge ravine.");
            Console.WriteLine("To get to the other side you will need to solve the riddle.\n");
            Console.WriteLine("Riddle: What gets bigger the more you take away?\n");
            Console.WriteLine("(write ONLY one word)");

            string yourGuess = Console.ReadLine().ToLower();

            //FOR TESTS
            if (yourGuess == "test123")
            {
                Console.Write("\nPress ENTER to continue");
                Console.ReadLine();

                Console.Clear();

                Forest2();
            }
            else
            {
                if (yourGuess == "hole")
                {
                    Console.WriteLine("\nCongratulation! The answer is \"hole\"");
                    Console.WriteLine("Now you can peacefully cross the ravine.\n");

                    Console.Write("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();

                    Forest2();
                }
                else
                {
                    Console.WriteLine("You didn't guessed the riddle now the bridge broke, you fell and died.\n");

                    Console.Write("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();

                    EndGame();
                }
            }
        }

        public static void Forest2()
        {
            Console.WriteLine("After some time you run across a sleeping wolf pack.");
            Console.WriteLine("You must to be quiet so you don't wake them up");
            Console.WriteLine("You will need to play \"Rock Paper Scissors\"");

            bool again = false;

            do
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 4);
                string respond = string.Empty;
                if (num == 1)
                {
                    respond = "rock";
                }
                else if (num == 2)
                {
                    respond = "paper";
                }
                else
                {
                    respond = "scissors";
                }

                Console.WriteLine("\n(write rock, paper or scissors)");
                string yourGuess = Console.ReadLine().ToLower();

                //FOR TESTS
                if (yourGuess == "test123")
                {
                    Console.Write("\nPress ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();

                    Forest3();
                }
                else
                {
                    if (yourGuess == "rock")
                    {
                        if (respond == "rock")
                        {
                            Console.WriteLine("\nDRAW! You will need to play again.\n");
                            again = true;

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                        else if (respond == "paper")
                        {
                            Console.WriteLine("\nYou lost.");
                            Console.WriteLine("You step onto one of the wolf's tail, they all woke up and you died.\n");

                            Console.Write("Press ENTER to continue\n");
                            Console.ReadLine();

                            Console.Clear();

                            EndGame();
                        }
                        else
                        {
                            again = false;

                            Console.WriteLine("\nYou won!");
                            Console.WriteLine("You didn't wake any wolf.\n");

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();

                            Console.Clear();

                            Forest3();
                        }
                    }
                    else if (yourGuess == "paper")
                    {
                        if (respond == "rock")
                        {
                            again = false;

                            Console.WriteLine("\nYou won!");
                            Console.WriteLine("You didn't wake any wolf.\n");

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();

                            Console.Clear();

                            Forest3();
                        }
                        else if (respond == "paper")
                        {
                            Console.WriteLine("\nDRAW! You will need to play again.\n");
                            again = true;

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nYou lost.");
                            Console.WriteLine("You step onto one of the wolf's tail, they all woke up and you died.\n");

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();

                            Console.Clear();

                            EndGame();
                        }
                    }
                    else if (yourGuess == "scissors")
                    {
                        if (respond == "rock")
                        {
                            Console.WriteLine("\nYou lost.");
                            Console.WriteLine("You step onto one of the wolf's tail, they all woke up and you died.\n");

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();

                            Console.Clear();

                            EndGame();
                        }
                        else if (respond == "paper")
                        {
                            again = false;

                            Console.WriteLine("\nYou won!");
                            Console.WriteLine("You didn't wake any wolf.\n");

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();

                            Console.Clear();

                            Forest3();
                        }
                        else
                        {
                            Console.WriteLine("\nDRAW! You will need to play again.\n");
                            again = true;

                            Console.Write("Press ENTER to continue");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\n\"{yourGuess}\" isn't valid");
                        Console.WriteLine("please try again");
                        again = true;

                        Console.Write("Press ENTER to continue");
                        Console.ReadLine();
                    }
                }
            } while (again);

        }

        public static void Forest3()
        {
            Console.WriteLine("After 20 minutes of walking the path splits in two.");
            Console.WriteLine("Now you need to choose which one you will follow, the left or the right one?");

            bool again = false;

            do
            {
                Console.WriteLine("\n(write left or right)");
                string yourGuess = Console.ReadLine().ToLower();

                //FOR TESTS
                if (yourGuess == "test123")
                {
                    Console.Write("\nPress ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();

                    Forest4();
                }
                else
                {
                    if (yourGuess == "left")
                    {
                        again = false;

                        Console.WriteLine("\nYou choose the left path.\n");

                        Console.Write("Press ENTER to continue");
                        Console.ReadLine();

                        Console.Clear();

                        Forest4();
                    }
                    else if (yourGuess == "right")
                    {
                        again = false;

                        Console.WriteLine("\nYou choose the right path.");
                        Console.WriteLine("After some time you realize that you are walking on floating sand.");
                        Console.WriteLine("You perish and die.\n");

                        Console.Write("Press ENTER to continue");
                        Console.ReadLine();

                        Console.Clear();

                        EndGame();
                    }
                    else
                    {
                        Console.WriteLine($"\"{yourGuess}\" isn't valid");
                        Console.WriteLine("please try again");
                        again = true;

                        Console.Write("Press ENTER to continue");
                        Console.ReadLine();
                    }
                }
            } while (again);
        }

        public static void Forest4()
        {
            Console.WriteLine("After a 10 minutes walk there is a large lake in front of you.");
            Console.WriteLine("There is a boat on the shore but in order to use it you have to crack the padlock code.\n");

            Console.WriteLine("The code:\n");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("  one number is\ncorrect and placed     2  6  5\n       well");
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("nothing is right       3  8  7\n");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("   one number is\ncorrect but wrongly    2  3  4\n      placed");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("  two numbers are\ncorrect but wrongly    4  7  1\n      placed");
            Console.WriteLine("-------------------------------");

            Console.Write("Your guess: ");
            string yourGuess = Console.ReadLine();

            //FOR TESTS
            if (yourGuess == "test123")
            {
                Console.Write("\nPress ENTER to continue");
                Console.ReadLine();

                Console.Clear();

                ForestEnd();
            }
            else
            {
                if (int.Parse(yourGuess) == 145)
                {
                    Console.WriteLine("\nCongratulation! 145 is the right number.");
                    Console.WriteLine("You cracked the code and now you can take the boat.");

                    Console.Clear();

                    ForestEnd();
                }
                else
                {
                    Console.WriteLine($"\n{yourGuess} isn't the right number.");
                    Console.WriteLine("You didn't crack the code, so you try to swim but the there is a shark in the lake, that ate you and you died.\n");

                    Console.Write("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();

                    EndGame();
                }
            }
        }

        public static void ForestEnd()
        {
            Console.WriteLine("Congratulation! You got to the city.\n");

            EndGame();
        }
    }
}
