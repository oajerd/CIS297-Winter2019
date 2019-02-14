using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            cards.Add(new Card("Ace", "Hearts"));
            cards.Add(new Card("Ace", "Diamonds"));

            cards.Sort();
        }

    }
}
