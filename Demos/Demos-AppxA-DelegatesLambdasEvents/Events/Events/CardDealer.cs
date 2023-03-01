
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // --------------------------------------------------------------------
    // Define a class to hold contextual information about events
    // --------------------------------------------------------------------
    public class CardEventArgs : EventArgs
    {
        public string Number { get; init; }
        public string Suit { get; init; }

        public CardEventArgs(string number, string suit)
        {
            Number = number;
            Suit = suit;
        }
    }


    // --------------------------------------------------------------------
    // Define a delegate type for all events from CardDealer.
    // This is the standard pattern for all events in .NET 
    // --------------------------------------------------------------------
    public delegate void CardEventHandler(object? src, CardEventArgs e);


    // --------------------------------------------------------------------
    // Define the "card dealer" class
    // --------------------------------------------------------------------
    public class CardDealer
    {
        // Card numbers.
        private static string[] NUMBERS =
        {
            "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
        };

        // Card suits.
        private static string[] SUITS =
        {
            "Clubs", "Diamonds", "Hearts", "Spades"
        };

        // Define events, using our delegate type to denote the signatures.
        public event CardEventHandler? AcePicked;
        public event CardEventHandler? PicturecardPicked;
        public event CardEventHandler? DiamondPicked;

        // Or alternatively, using EventHandler<T>:
        //public event EventHandler<CardEventArgs>? AcePicked;
        //public event EventHandler<CardEventArgs>? PicturecardPicked;
        //public event EventHandler<CardEventArgs>? DiamondPicked;

        // Pick a card, any card...
        public void Deal(out string number, out string suit)
        {
            Random rg = new Random();
            number = NUMBERS[rg.Next(0, 13)];
            suit = SUITS[rg.Next(0, 4)];

            if (number == "A")
            {
                AcePicked?.Invoke(this, new CardEventArgs(number, suit));
            }
            else if (number == "J" || number == "Q" || number == "K")
            {
                PicturecardPicked?.Invoke(this, new CardEventArgs(number, suit));
            }
            if (suit == "Diamonds")
            {
                DiamondPicked?.Invoke(this, new CardEventArgs(number, suit));
            }
        }
    }
}
