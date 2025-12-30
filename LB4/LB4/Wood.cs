using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Wood : BuildingMaterial
    {
        private string treatmentType;

        public Wood(string name, double price, int quantity, string treatment)
            : base(name, price, quantity)
        {
            treatmentType = treatment;
        }

        public override double CalculateCost()
        {
            double factor = treatmentType == "Лакування" ? 1.5 : 1.0;
            return base.CalculateCost() * factor;
        }
    }
}
