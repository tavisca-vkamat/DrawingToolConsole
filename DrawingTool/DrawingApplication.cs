using System;
using log4net;
using log4net.Config;
using Factory;
using DrawingManager;
using System.Collections.Generic;

namespace DrawingTool
{
    class DrawingApplication
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static Point GetPoint(string coordinates)
        {
            string[] xAndy = coordinates.Split(',');
            Point point = new Point(int.Parse(xAndy[0]),int.Parse(xAndy[1]));
            return point;
        }

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            logger.Debug("Programm starts ");
            int userChoice;
            char[][] windowArea = new char[32][];
            windowArea = DrawingShapes.SetBorder(windowArea, 132, 32);
            Console.SetWindowSize(150,40);
            do
            {
                /* Menu for user */
                Console.Write("\n\n---------------MENU---------------\n1.Horizontal Line\n2.Vertical Line\n3.Circle\n4.Rectangle\n5.Exit\nEnter Choice: ");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("Window width (129*29)\n");

                switch (userChoice)
                {
                    case 1:/* Line drawing horizontal */
                        try
                        {
                            Line line = ObjectFactory.GetInstanceHorizontalLine();
                            
                            Console.Write("Enter start point of line (x1,y1): ");
                            Point startPoint = GetPoint(Console.ReadLine());

                            Console.Write("Enter start point of line (x2,y2): ");
                            Point endPoint = GetPoint(Console.ReadLine());

                            List<Point> lineCoordinates = line.Draw(startPoint, endPoint);
                            windowArea = DrawingShapes.AddShapeToWindow(windowArea,lineCoordinates);

                            DrawingShapes.DrawWindow(windowArea);

                            logger.Info("line draw successful");
                        }
                        catch (Exception exception)
                        {
                            logger.Error("in horizontal line Draw exception: " + exception.ToString());
                        }
                        break;
                    case 2:/* line drawing vertical */
                        try
                        {
                            Line line = ObjectFactory.GetInstanceVerticalLine();

                            Console.Write("Enter start point of line (x1,y1): ");
                            Point startPoint = GetPoint(Console.ReadLine());

                            Console.Write("Enter start point of line (x2,y2): ");
                            Point endPoint = GetPoint(Console.ReadLine());

                            List<Point> lineCoordinates = line.Draw(startPoint, endPoint);
                            windowArea = DrawingShapes.AddShapeToWindow(windowArea, lineCoordinates);

                            DrawingShapes.DrawWindow(windowArea);

                            logger.Info("line draw successful");
                        }
                        catch (Exception exception)
                        {
                            logger.Error("in vertical line Draw exception: " + exception.ToString());
                        }
                        break;

                    case 3:/* Circle drawing */
                        try
                        {
                            Ellipse circle = ObjectFactory.GetInstanceCircle();
                            Console.Write("Enter center (x,y): ");
                            Point center = GetPoint(Console.ReadLine());
                            Console.Write("Enter radius: ");
                            int radius = int.Parse(Console.ReadLine());

                            List<Point> circumference = circle.Draw(center,radius);
                            windowArea = DrawingShapes.AddShapeToWindow(windowArea,circumference);

                            DrawingShapes.DrawWindow(windowArea);

                            logger.Info("line draw successful");
                        }
                        catch (Exception exception)
                        {
                            logger.Error("in circle Draw exception: " + exception.ToString());
                        }

                        break;

                    case 4:/* Rectangle drawing */
                        try
                        {
                            Rectangle rectangle = ObjectFactory.GetInstanceNormalRectangle();

                            Console.Write("Enter start point of diagonal (x1,y1): ");
                            Point startPoint = GetPoint(Console.ReadLine());

                            Console.Write("Enter end point of diagonal (x2,y2): ");
                            Point endPoint = GetPoint(Console.ReadLine());

                            List<Point> rectangleCoordinates = rectangle.Draw(startPoint,endPoint);

                            windowArea = DrawingShapes.AddShapeToWindow(windowArea,rectangleCoordinates);

                            DrawingShapes.DrawWindow(windowArea);

                            logger.Info("rectangle draw successful");
                        }
                        catch (Exception exception)
                        {
                            logger.Error("in rectangle Draw exception: " + exception.ToString());
                        }
                        break;
                    case 5:/* Exit */
                        Console.WriteLine("\nThank you come again!!!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            }
            while (userChoice!=5);
        }
    }
}

