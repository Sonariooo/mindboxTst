using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox.Models
{
    public class Circle : ICalculate
    {

        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new NegativeValueException();
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}
