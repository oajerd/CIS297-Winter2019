using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> shapes = new List<Polygon>();
            Rectangle smallRectangle = new Rectangle(2, 4);
            shapes.Add(smallRectangle);
            Square bigSquare = new Square(100);
        }
    }
}
