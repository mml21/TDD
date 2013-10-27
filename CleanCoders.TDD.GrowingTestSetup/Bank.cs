using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoders.TDD.GrowingTestSetup
{
    public static class Bank
    {
        private static double standardRate = 0.00125;

        public static double GetStandardRate()
        {
            return standardRate;
        }

        public static void SetStandardRate(double oldRate)
        {
            standardRate = oldRate;
        }
    }
}
