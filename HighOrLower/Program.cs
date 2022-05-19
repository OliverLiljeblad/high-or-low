using HighOrLower.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HighOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaderBoard leaderboard = new LeaderBoard();
            
            bool game = true;
            while (game)
            {
                ShowMainMenu();

                int choise;
                while (true)
                {
                    try
                    {
                        choise = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("You must choose a number between 1-3!!!!!");
                        ShowMainMenu();
                    }
                }

                switch (choise)
                {
                    case 1:
                        StartGame(leaderboard);
                        break;
                    case 2:
                        Console.Clear();
                        PrintLeaderboard(leaderboard);
                        Console.Write("Press any key to EXIT : ");
                        Console.ReadLine();
                        break;
                    case 3:
                        game = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You must choose a number between 1-3");
                        break;
                }

            }
        }

        private static void PrintLeaderboard(LeaderBoard leaderboarad)
        {
            foreach (var item in leaderboarad.GetAll())
            {
                Console.WriteLine(item.Username + " " + item.Points);
            }
        }

        private static void StartGame(LeaderBoard leaderboard)
        {
          
            int score = 0;
            Console.Clear();
            var listOfCards = Dealer.GetAllCards();
            Dealer.Shuffle(listOfCards);
            var stackOfCards = new Stack<Card>(listOfCards);
 
             Console.WriteLine("Shuffling cards...");

             for (int i = 0; i < 10; i++)
             {
                Console.Write("*");
                Thread.Sleep(450);
             }  

            Console.Clear();
            Console.Write("Username: ");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Let the game begin " + name + "!");

            Card lastCard;

            for (int round = 0; round < 4; round++)
            {
                Console.Clear();
                Console.WriteLine($"Round: {round + 1}");
                lastCard = stackOfCards.Pop();
                for (int cardInRound = 0; cardInRound < 12; cardInRound++)
                {
                    
                    ConsoleKey key;
                    var curentCard = stackOfCards.Pop();

                    do
                    {
                        Console.WriteLine($"This is your card   {lastCard}  ");
                        
                        Console.WriteLine("Press H for HIGHER or L for LOWER");
                        key = Console.ReadKey(true).Key;

                    } while (key != ConsoleKey.H && key != ConsoleKey.L);



                    Console.WriteLine($"Other card : {curentCard}");

                    if (key == ConsoleKey.H)
                    {
                        if (curentCard.IsHigher(lastCard))
                        {
                            score += 1;
                            Console.WriteLine("The card was higher");
                            Console.WriteLine($"Your score : {score} ");
                            if (round == 12)
                            {
                                Console.WriteLine("You got another 50 score");
                                Console.WriteLine($"Now your score is {score}");
                            }
                            lastCard = curentCard;
                        }
                        else
                        {
                            Console.WriteLine("The card was lower, you lost this round");
                            Console.WriteLine("Press ENTER to go to next round");
                            Console.ReadLine();
                            break;

                        }
                    }
                    else if (key == ConsoleKey.L)
                    {
                        if (curentCard.IsLower(lastCard))
                        {
                            score += 1;
                            Console.WriteLine("The card was lower");
                            Console.WriteLine($"Your score : {score}");
                            lastCard = curentCard;
                        }
                        else
                        {
                            Console.WriteLine("The card was higher, you lost");
                            Console.WriteLine("Press ENTER to go to next round");
                            Console.ReadLine();
                            break;
                        }
                    }

                    if (cardInRound == 11)
                    {
                        score += 50;
                    }
                }
            }

            leaderboard.AddScore(name, score);
            Console.WriteLine("Press ENTER to go back");
            Console.ReadLine();
        }

        private static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 : Start Game");
            Console.WriteLine("2 : Highscore");
            Console.WriteLine("3 : Exit Game");
            Console.Write("Answer: ");
        }

        private static void WriteCards(List<Card> listOfCards)
        {
            foreach (var card in listOfCards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
