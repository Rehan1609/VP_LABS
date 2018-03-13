using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vplabs
{
    class allied:interest
    {
        public double showInterest(double amount)
        {
            return ((0.15 * amount) + amount);
        }
    }
}
