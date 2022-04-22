using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox.Models
{
    public class Triangle : ICalculate
    {

        private readonly List<double> _sides;

        public Triangle(List<double> sides)
        {
            if (sides.Count != 3)
                throw new IncorrentSidesException();
            if (sides.Count(x => x <= 0) > 0)
                throw new NegativeValueException();
            _sides = sides;
        }

        public double CalculateArea()
        {
            var p = 0.5 * (_sides.Sum());
            return Math.Sqrt(p*(p-_sides[0])*(p-_sides[1])*(p-_sides[2]));
        }

        public bool IsRight()
        {
            var tmp=_sides.OrderByDescending(x => x).ToArray();
            return (Math.Pow(tmp[0], 2) == (Math.Pow(tmp[1], 2) + Math.Pow(tmp[2], 2)));
        }
    }
}
