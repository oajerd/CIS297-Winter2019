using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public abstract class Polygon
    {
        protected int numberOfSides;
        protected List<int> sideLengths;
        public  Polygon(int numberOfSides, List<int> sideLengths)
        {
            this.numberOfSides = numberOfSides;
            this.sideLengths = sideLengths;
       
        }

        public virtual int getPerimeter()
        {
            /*
            int perimeter = 0;
            foreach( var side in sideLengths )
            {
                perimeter += side;
            }
            */
            return sideLengths.Sum();
        }

        public abstract double GetArea();
    }
}
