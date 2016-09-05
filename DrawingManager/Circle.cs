using System;
using System.Collections.Generic;

namespace DrawingManager
{
    public class Circle : Ellipse
    {
        public override List<Point> Draw(Point center, int radius)
        {
            List<Point> arrayToReturn = new List<Point>();

            if (center.X - radius < 0 | center.Y - radius < 0)
                throw new Exception("Circle circumference is out of window.");
            else
            {
                for (int circumferenceX = center.X, circumferenceY = center.Y - radius; circumferenceY < center.Y & circumferenceX < center.X + radius; circumferenceX += 2, circumferenceY+=1)
                {
                    arrayToReturn.Add(new Point(circumferenceX, circumferenceY));
                }
                for (int circumferenceX = center.X + radius, circumferenceY = center.Y; circumferenceX > center.X & circumferenceY < center.Y + radius; circumferenceY += 2, circumferenceX-=1)
                {
                    arrayToReturn.Add(new Point(circumferenceX, circumferenceY));
                }
                for (int circumferenceX = center.X, circumferenceY = center.Y + radius; circumferenceY > center.Y & circumferenceX > center.X - radius; circumferenceX -= 2, circumferenceY-=1)
                {
                    arrayToReturn.Add(new Point(circumferenceX, circumferenceY));
                }
                for (int circumferenceX = center.X - radius, circumferenceY = center.Y; circumferenceX < center.X & circumferenceY > center.Y - radius; circumferenceY -= 2, circumferenceX+=1)
                {
                    arrayToReturn.Add(new Point(circumferenceX, circumferenceY));
                }
            }
            return arrayToReturn;
        }
    }
}
