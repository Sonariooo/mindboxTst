using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox.Models
{
    public static class Calculator
    {
        public static double GetArea(ICalculate form)
        {
            return form.CalculateArea();
        }

        public static IEnumerable<double> GetAreas(List<ICalculate> forms)
        {
            foreach (var form in forms)
            {
                yield return (double)form.CalculateArea();
            }
        }

        public static double CalculateUnknown(List<double> sides)
        {
            if (sides.Count == 1)
                return new Circle(sides[0]).CalculateArea();

            if (sides.Count == 3)
                return new Triangle(sides).CalculateArea();

            throw new IncorrentSidesException();
        }
    }
}
