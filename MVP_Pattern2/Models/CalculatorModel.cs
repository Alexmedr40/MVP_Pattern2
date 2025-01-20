using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Pattern2.Models
{
    public class CalculatorModel
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b== 0)
                throw new DivideByZeroException("No se puede dividir entre cero");
            return a / b;
        }
    }
}
