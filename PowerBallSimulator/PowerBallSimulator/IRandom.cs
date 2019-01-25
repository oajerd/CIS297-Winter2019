using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBallSimulator
{
    public interface IRandom
    {
        int Next(int startingAtThisMin, int upToButNotIncludingThisMax);
    }
}
