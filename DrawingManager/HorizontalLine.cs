using System;
using System.Collections.Generic;

namespace DrawingManager
{
    public class HorizontalLine : Line
    {
        public override List<Point> Draw(Point startPoint, Point endPoint)
        {
            List<Point> arrayToReturn = new List<Point>();

            if(startPoint.Y == endPoint.Y)
            {
                for(int xCoordinate=startPoint.X; xCoordinate <= endPoint.X; xCoordinate++)
                {
                    arrayToReturn.Add(new Point(xCoordinate,startPoint.Y));
                }
            }
            else
            {
                arrayToReturn = null;
                throw new Exception("Co-ordinate values not for horizontal line");
            }
            return arrayToReturn;
        }
    }
}
