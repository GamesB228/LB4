using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Cement : BuildingMaterial
    {
        private double bagWeight;

        public Cement(string name, double price, int quantity, double bagWeight)
            : base(name, price, quantity)
        {
            this.bagWeight = bagWeight;
        }

        public bool CheckExpiry(DateTime expiryDate)
        {
            return expiryDate > DateTime.Now;
        }

        public override double CalculateCost()
        {
            double baseCost = base.CalculateCost();
            return quantity > 50 ? baseCost * 0.9 : baseCost; // знижка
        }
    }
}
