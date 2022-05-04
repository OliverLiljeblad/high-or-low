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
                        Console.WriteLine("You must choose a number between 1-2!!!!!");
                        ShowMainMenu();
                        
                    }
                }

                switch (choise)
                {
                    case 1:
                        StartGame();
                        break;
                    case 2:
                        ShowHighscore();
                        break;
                    case 3:
                        game = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You must choose a number between 1-2");
                        break;
                }
            }

           /* var listOfCards = Dealer.GetAllCards();
            WriteCards(listOfCards);

            Dealer.Shuffle(listOfCards);
            Console.WriteLine("-----------------------------------------");
            WriteCards(listOfCards);

            listOfCards = listOfCards.OrderBy(x => (int)x.Rank).ToList();
  
            WriteCards(listOfCards);
           */
        }

        private static void StartGame()
        {
            Console.Clear();
            var listOfCards = Dealer.GetAllCards();
            Dealer.Shuffle(listOfCards);

            /* 
             Console.WriteLine("Shuffling cards...");

             for (int i = 0; i < 10; i++)
             {
                 Console.Write("*");
                 Thread.Sleep(700);
             }  */

            Console.Clear();
            Console.Write("Username: ");
            var name = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("Let the game begin " + name + "!");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    WriteCards(listOfCards);
                    Console.ReadLine();
                }
            }
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

        private static void ShowHighscore()
        {
            Console.Clear();
            Console.WriteLine("Highscore:" + "\n");
            Console.WriteLine("1: " + " name " + "Score: ");
            Console.WriteLine("2: " + " name " + "Score: ");
            Console.WriteLine("3: " + " name " + "Score: ");
            Console.WriteLine("4: " + " name " + "Score: ");
            Console.WriteLine("5: " + " name " + "Score: ");

            Console.WriteLine("Press ENTER to go back");
            Console.ReadLine();
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
