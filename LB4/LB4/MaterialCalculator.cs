using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class MaterialCalculator
    {
        public double TotalCost(List<ICostCalculable> items)
        {
            double total = 0;

            foreach (ICostCalculable item in items)
            {
                total += item.CalculateCost();
            }

            return total;
        }
    }
}
