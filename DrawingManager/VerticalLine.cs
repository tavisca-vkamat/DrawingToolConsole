using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingManager
{
    public class VerticalLine : Line
    {
        public override List<Point> Draw(Point startPoint, Point endPoint)
        {
            List<Point> arrayToReturn = new List<Point>();

            if (startPoint.X == endPoint.X)
            {
                for (int yCoordinate = startPoint.Y; yCoordinate <= endPoint.Y; yCoordinate++)
                {
                    arrayToReturn.Add(new Point(startPoint.X, yCoordinate));
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
