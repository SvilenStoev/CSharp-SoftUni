using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker_02._11._2019___G1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> cardsInDeck = new List<string>();

            string command;

            while ((command = Console.ReadLine()) != "Ready")
            {
                string firstCommand = command.Split()[0];

                if (firstCommand == "Add")
                {
                    AddCard(cards, cardsInDeck, command);
                }
                else if (firstCommand == "Insert")
                {
                    InsertCard(cards, cardsInDeck, command);
                }
                else if (firstCommand == "Remove")
                {
                    RemoveCard(cards, cardsInDeck, command);
                }
                else if (firstCommand == "Swap")
                {
                    SwapCards(cards, cardsInDeck, command);
                }
                else if (firstCommand == "Shuffle")
                {
                    cardsInDeck.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", cardsInDeck));
        }

        private static void SwapCards(List<string> cards, List<string> cardsInDeck, string command)
        {
            string firstCard = command.Split()[1];
            string secondCard = command.Split()[2];

            int indexOfFirstCard = cardsInDeck.IndexOf(firstCard);
            int indexOfSecondtCard = cardsInDeck.IndexOf(secondCard);

            string temp = cardsInDeck[indexOfFirstCard];
            cardsInDeck[indexOfFirstCard] = cardsInDeck[indexOfSecondtCard];
            cardsInDeck[indexOfSecondtCard] = temp;

            //cardsInDeck.Remove(firstCard);
            //cardsInDeck.Insert(indexOfFirstCard, secondCard);

            //cardsInDeck.Remove(secondCard);
            //cardsInDeck.Insert(indexOfSecondtCard, firstCard);
        }

        private static void RemoveCard(List<string> cards, List<string> cardsInDeck, string command)
        {
            string cardName = command.Split()[1];

            if (cardsInDeck.Contains(cardName))
            {
                cardsInDeck.Remove(cardName);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

        private static void InsertCard(List<string> cards, List<string> cardsInDeck, string command)
        {
            string cardName = command.Split()[1];
            int index = int.Parse(command.Split()[2]);

            if (cards.Contains(cardName) && index >= 0 && index < cardsInDeck.Count)
            {
                cardsInDeck.Insert(index, cardName);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        private static void AddCard(List<string> cards, List<string> cardsInDeck, string command)
        {
            string cardName = command.Split()[1];

            if (cards.Contains(cardName))
            {
                cardsInDeck.Add(cardName);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
    }
}
