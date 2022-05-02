using HighOrLower.library;
using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine("Welcome!");
            Console.ReadLine();
        }
        
        private static void ShowMainMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 : Start Game");
            Console.WriteLine("2 : Exit Game");
            Console.Write("Your answer: ");
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
