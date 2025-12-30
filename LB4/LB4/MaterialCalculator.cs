using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class MaterialCalculator
    {
        public double TotalCost(List<BuildingMaterial> materials)
        {
            return materials.Sum(m => m.CalculateCost());
        }
    }
}
