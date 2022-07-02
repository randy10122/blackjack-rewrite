using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace blackjack_rewrite
{
    class Program
    {
        static void DelayedWriteLine(string message)
        {
            Thread.Sleep(100);
            Console.WriteLine(message);
        }
        static void RefreshCards()
        {
            // figure out how to do this shit
           // cards.Clear;
        }

        static void Main(string[] args)
        {
            // dictionary of cards. its ugly but i like how it works so
            Dictionary<string, int> cards = new Dictionary<string, int>();
            cards.Add("Ace of Clubs", 1);
            cards.Add("Two of Clubs", 2);
            cards.Add("Three of Clubs", 3);
            cards.Add("Four of Clubs", 4);
            cards.Add("Five of Clubs", 5);
            cards.Add("Six of Clubs", 6);
            cards.Add("Seven of Clubs", 7);
            cards.Add("Eight of Clubs", 8);
            cards.Add("Nine of Clubs", 9);
            cards.Add("Ten of Clubs", 10);
            cards.Add("Jack of Clubs", 10);
            cards.Add("Queen of Clubs", 10);
            cards.Add("King of Clubs", 10);

            cards.Add("Ace of Spades", 1);
            cards.Add("Two of Spades", 2);
            cards.Add("Three of Spades", 3);
            cards.Add("Four of Spades", 4);
            cards.Add("Five of Spades", 5);
            cards.Add("Six of Spades", 6);
            cards.Add("Seven of Spades", 7);
            cards.Add("Eight of Spades", 8);
            cards.Add("Nine of Spades", 9);
            cards.Add("Ten of Spades", 10);
            cards.Add("Jack of Spades", 10);
            cards.Add("Queen of Spades", 10);
            cards.Add("King of Spades", 10);

            cards.Add("Ace of Diamonds", 1);
            cards.Add("Two of Diamonds", 2);
            cards.Add("Three of Diamonds", 3);
            cards.Add("Four of Diamonds", 4);
            cards.Add("Five of Diamonds", 5);
            cards.Add("Six of Diamonds", 6);
            cards.Add("Seven of Diamonds", 7);
            cards.Add("Eight of Diamonds", 8);
            cards.Add("Nine of Diamonds", 9);
            cards.Add("Ten of Diamonds", 10);
            cards.Add("Jack of Diamonds", 10);
            cards.Add("Queen of Diamonds", 10);
            cards.Add("King of Diamonds", 10);

            cards.Add("Ace of Hearts", 1);
            cards.Add("Two of Hearts", 2);
            cards.Add("Three of Hearts", 3);
            cards.Add("Four of Hearts", 4);
            cards.Add("Five of Hearts", 5);
            cards.Add("Six of Hearts", 6);
            cards.Add("Seven of Hearts", 7);
            cards.Add("Eight of Hearts", 8);
            cards.Add("Nine of Hearts", 9);
            cards.Add("Ten of Hearts", 10);
            cards.Add("Jack of Hearts", 10);
            cards.Add("Queen of Hearts", 10);
            cards.Add("King of Hearts", 10);

            Console.WriteLine("welcome to randy casino");

        }
    }
}
