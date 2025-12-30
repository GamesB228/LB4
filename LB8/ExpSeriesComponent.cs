using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB8
{
    public class ExpSeries
    {
        
        public double CalculateLoop(double x, int n)
        {
            double sum = 0;
            double term = 1; 

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                    term *= x / i;

                sum += term;
            }

            return sum;
        }

        
        public double CalculateRecursive(double x, int n)
        {
            return RecursiveTerm(x, n, 0);
        }

        private double RecursiveTerm(double x, int n, int i)
        {
            if (i == n)
                return 0;

            return Power(x, i) / Factorial(i)
                   + RecursiveTerm(x, n, i + 1);
        }

        private double Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        private double Power(double x, int n)
        {
            if (n == 0) return 1;
            return x * Power(x, n - 1);
        }
    }
}
