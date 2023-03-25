using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17.Subtask6
{
    public class SalaryAccount : Account, ICalculateInterest
    {
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
