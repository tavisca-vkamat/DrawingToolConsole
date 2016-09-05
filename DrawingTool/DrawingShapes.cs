using DrawingManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class DrawingShapes
    {
        public static char[][] AddShapeToWindow(char[][] windowArea, List<Point> lineCoordinates)
        {
            char[][] window = windowArea;
            for (int lineLength = 0; lineLength < lineCoordinates.Count; lineLength++)
                window[lineCoordinates[lineLength].Y][lineCoordinates[lineLength].X] = '*';

            return windowArea;
        }

        public static char[][] SetBorder(char[][] windowArea, int width, int height)
        {
            char[][] window = windowArea;

            window[0] = new char[width];
            for (int cursor = 0; cursor < width; cursor++)
                window[0][cursor] = '\'';

            for (int cursor = 1; cursor < height; cursor++)
            {
                window[cursor] = new char[width];
                window[cursor][0] = '\'';
                for (int blankSpace = 1; blankSpace < width - 1; blankSpace++)
                    window[cursor][blankSpace] = ' ';
                window[cursor][width - 1] = '\'';
            }
            for (int cursor = 0; cursor < width; cursor++)
                window[height - 1][cursor] = '\'';

            return window;
        }


        public static void DrawWindow(char[][] window)
        {
            for (int row = 0; row < window.Length; row++)
            {
                for (int column = 0; column < window[0].Length; column++)
                    Console.Write(window[row][column]);
                Console.WriteLine();
            }
        }
    }
}
