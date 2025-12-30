using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Paint : ICostCalculable, IDescribable, IExpirable
    {
        private double pricePerLiter;
        private int liters;

        public Paint(double price, int liters)
        {
            pricePerLiter = price;
            this.liters = liters;
        }

        public double CalculateCost()
        {
            return pricePerLiter * liters;
        }

        public string GetDescription()
        {
            return $"Фарба, літрів: {liters}";
        }

        public bool CheckExpiry(DateTime date)
        {
            return date > DateTime.Now;
        }
    }
}
