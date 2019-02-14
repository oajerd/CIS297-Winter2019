using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Card : IEquatable<Card>, IComparable<Card>
    {
        public string Face { get; private set; }
        public string Suit { get; private set; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public Bitmap GetCardImage()
        {
            // https://stackoverflow.com/questions/8292710/c-sharp-winforms-drawimage-without-losing-animation
            var bitmap = new Bitmap(2925 / 13, 1260 / 4);
            Graphics g = Graphics.FromImage(bitmap);
            Image image = Properties.Resources.cards;
            // TODO - Pick the right rectangle from the source
            g.DrawImage(image,
                new Rectangle(0, 0, 2925 / 13, 1260 / 4),
                new Rectangle(0, 0, 2925 / 13, 1260 / 4),
                GraphicsUnit.Pixel);

            return bitmap;
        }

        public bool Equals(Card other)
        {
            return Face == other.Face && Suit == other.Suit;
        }

        // don't do this at home
        public int CompareTo(Card other)
        {
            return 1;
        }

        // comparing strings like this will lead to no good
        //public int CompareTo(Card other)
        //{
        //    if (Face == "Ace")
        //        {
        //        if ( other.Face == "Ace")
        //        {
        //            return 0;
        //        }
        //        return 1;
        //    }
        //}
    }
}
