using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Subtask6
{
    public static class Calculator
    {
        public static void CalculateInterest(ICalculateInterest account)
        {
            account.CalculateInterest();
        }
    }
}
