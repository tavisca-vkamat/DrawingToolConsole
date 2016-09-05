using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingManager
{
    public abstract class Line
    {
        public abstract List<Point> Draw(Point startPoint, Point endPoint);
    }
}
