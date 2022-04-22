using System;
using System.Collections.Generic;
using System.Linq;
using mindbox;
using mindbox.Models;
using Xunit;

namespace mindbox
{
    public class Tests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CircleIncorrectInputValidationTest(int value)
        {
            Assert.Throws<NegativeValueException>(() => { new Circle(value); });
        }

        [Fact]
        public void TriangleIncorrectInputValidationTest()
        {
            List<double> testData = new List<double>() { 1, 2 };
            Assert.Throws<IncorrentSidesException>(() => { new Triangle(testData); });
        }

        [Fact]
        public void CircleCorrectAreaCalculationTest()
        {
            Assert.Equal(78.54, Math.Round(new Circle(5).CalculateArea(), 2));
        }

        [Fact]
        public void TriangleCorrectAreaCalculationTest()
        {
            var triangle = new Triangle(new List<double>() { 3, 5, 4 });
            Assert.Equal(6, Math.Round(triangle.CalculateArea(),2));
        }

        [Fact]
        public void TriangleIsRightTest()
        {
            var triangle = new Triangle(new List<double>() { 3, 4,5 });
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void TriangleIsNotRightTest()
        {
            var triangle = new Triangle(new List<double>() { 3, 4, 3 });
            Assert.False(triangle.IsRight());
        }

        [Fact]
        public void CalculateBulkTest()
        {
            var res = Calculator.GetAreas(new List<ICalculate>() { new Triangle( new List<double>() { 3, 5, 4 }), new Triangle(new List<double>() { 3, 5, 4 }) });
            List<double> realRes = new List<double>() { 6, 6 };
            Assert.Equal(realRes, res.ToList());
        }

        [Fact]
        public void CalculateUnknownTest()
        {
            var res = Calculator.CalculateUnknown(new List<double>() { 3, 5, 4 });
            Assert.Equal(6, res);
        }
    }

}
