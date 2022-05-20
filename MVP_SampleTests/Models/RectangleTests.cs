using NUnit.Framework;
using MVP_Sample.Models;
using MVP_Sample.Views;
using MVP_Sample.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MVP_Sample.Models.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        RectanglePresenter rectanglePresenter = null;
        RectangleTest rectangleTest = null;
        [OneTimeSetUp]
        public void Init()
        {
            rectangleTest = new RectangleTest();
            rectanglePresenter = new RectanglePresenter(rectangleTest);
        }
        [TestCase("100","100","10000")]
        [TestCase("10", "10", "100")]
        [TestCase("150", "100", "15000")]
        public void CalCulate(string length, string breadth, string expected)
        {
            rectangleTest.LengthTest = length;
            rectangleTest.BreadthText = breadth;
            rectanglePresenter.CalculateArea();
            Assert.AreEqual(expected, rectangleTest.AreaText);
        }
    }
    public class RectangleTest : IRectangle
    {
        public string LengthTest { get; set; }
        public string BreadthText { get; set; }
        public string AreaText { get ; set ; }
    }
}