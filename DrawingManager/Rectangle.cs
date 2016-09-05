using System.Collections.Generic;

namespace DrawingManager
{
    public abstract class Rectangle
    {
        public abstract List<Point> Draw(Point diagonalStartPoint, Point diagonalEndPoint);
    }
}
