using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class Square :Rectangle
    {
        public Square(int length) : base (length, length)
        {
            // EMPTY
        }

        public override int getPerimeter()
        {
            return base.getPerimeter();
        }
    }
}
