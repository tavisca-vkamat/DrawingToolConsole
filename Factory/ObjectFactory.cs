using DrawingManager;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ObjectFactory
    {
        static public Line GetInstanceHorizontalLine()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(Line), typeof(HorizontalLine));
            Line line = container.Resolve<Line>();
            return line;
        }

        static public Rectangle GetInstanceNormalRectangle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(Rectangle), typeof(NormalRectangle));
            Rectangle rectangle = container.Resolve<Rectangle>();
            return rectangle;
        }

        static public Ellipse GetInstanceCircle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(Ellipse), typeof(Circle));
            Ellipse circle = container.Resolve<Ellipse>();
            return circle;
        }
        
        static public Line GetInstanceVerticalLine()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(Line), typeof(VerticalLine));
            Line line = container.Resolve<Line>();
            return line;
        }
    }
}
