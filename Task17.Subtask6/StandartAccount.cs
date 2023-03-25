using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Subtask6
{
    public class StandartAccount : Account, ICalculateInterest
    {
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.4;
            else if (Balance < 50000)
                Interest -= Balance * 0.2;
        }
    }
}
