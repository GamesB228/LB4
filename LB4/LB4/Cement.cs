using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Cement : BuildingMaterial, IExpirable
    {
        private double bagWeight;

        public Cement(string name, double price, int quantity, double bagWeight)
            : base(name, price, quantity)
        {
            this.bagWeight = bagWeight;
        }

        public bool CheckExpiry(DateTime date)
        {
            return date > DateTime.Now;
        }

        public override double CalculateCost()
        {
            double cost = base.CalculateCost();
            return quantity > 50 ? cost * 0.9 : cost;
        }
    }
}
