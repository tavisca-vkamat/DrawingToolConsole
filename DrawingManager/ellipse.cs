using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingManager
{
    public abstract class Ellipse
    {
        public abstract List<Point> Draw(Point center, int radius);
    }
}
