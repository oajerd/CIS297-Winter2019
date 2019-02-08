using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Batmobile : IVehicle
    {
        public string getDescription()
        {
            return "Batmobile!";
        }

        public double getQuarterMileTimeWithRandom()
        {
            return 1.01;
        }
    }
}
