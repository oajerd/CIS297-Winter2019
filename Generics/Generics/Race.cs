using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Race<T> where T : IVehicle
    {
        public string Result { get; private set; }
        private T Winner;
        private T Loser;
        public Race(T first, T second)
        {
            if (first.getQuarterMileTimeWithRandom() > second.getQuarterMileTimeWithRandom())
            {
                Result = $"{second.getDescription()} beat the {first.getDescription()}";
                Winner = second;
                Loser = first;
            }
            else
            {
                Result = $"{first.getDescription()} beat the {second.getDescription()}";
                Winner = first;
                Loser = second;
            }
        }

        public T getWinner()
        {
            return Winner;
        }

        public T getLoser()
        {
            return Loser;
        }


    }
}
