using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Rectangle : Polygon
    {
        private int length;
        private int width;
       
        /* needed if you want square to not call base constructor
        public Rectangle() : base(4, new List<int> { 0, 0, 0, 0 })
        {
          
            length = 0;
            width = 0;
        }
        */

        public Rectangle(int length, int width) : base(4, new List<int> { length, length, width, width })
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return length * width;
        }
    }
}
