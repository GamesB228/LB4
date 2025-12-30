using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public abstract class BuildingMaterial
    {
        protected string name;
        protected double pricePerUnit;
        protected int quantity;

        public string Name => name;
        public int Quantity => quantity;

        protected BuildingMaterial(string name, double price, int quantity)
        {
            this.name = name;
            this.pricePerUnit = price;
            this.quantity = quantity;
        }

        public virtual double CalculateCost()
        {
            return pricePerUnit * quantity;
        }

        public virtual string GetDescription()
        {
            return $"{name}, кількість: {quantity}";
        }
    }
}
