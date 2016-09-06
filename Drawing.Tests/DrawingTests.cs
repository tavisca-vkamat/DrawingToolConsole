using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingManager;
using Factory;
using System.Collections.Generic;

namespace Drawing.Tests
{
    [TestClass]
    public class DrawingTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestHorizontalLineDraw()
        {
            Line line = ObjectFactory.GetInstanceHorizontalLine();

            List<Point> lineCoordinates = line.Draw(new Point(10,10),new Point(100,100));

            Assert.IsNotNull(lineCoordinates);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestVerticalLineDraw()
        {
            Line line = ObjectFactory.GetInstanceVerticalLine();

            List<Point> lineCoordinates = line.Draw(new Point(10, 10), new Point(11, 20));

            Assert.IsNotNull(lineCoordinates);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCircleDraw()
        {
            Ellipse circle = ObjectFactory.GetInstanceCircle();

            List<Point> circumference = circle.Draw(new Point(10, 10), 11);

            Assert.IsNotNull(circumference);
        }
    

        [TestMethod]
        public void TestRectangleDraw()
        {
            Rectangle rectangle = ObjectFactory.GetInstanceNormalRectangle();

            List<Point> rectangleCoordinates = rectangle.Draw(new Point(10, 10), new Point(20, 20));

            Assert.IsNotNull(rectangleCoordinates);
        }
    }

}
