using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingManager
{
    public class NormalRectangle : Rectangle
    {
        public override List<Point> Draw(Point diagonalStartPoint, Point diagonalEndPoint)
        {
            List<Point> arrayToReturn = new List<Point>();

            /* one border vertical */
            if (diagonalStartPoint.Y > diagonalEndPoint.Y)
            {
                for (int border = diagonalStartPoint.Y; border >= diagonalEndPoint.Y; border--)
                    arrayToReturn.Add(new Point(diagonalStartPoint.X, border));
                if (diagonalStartPoint.X > diagonalEndPoint.X)
                {
                    for (int border = diagonalStartPoint.X; border >= diagonalEndPoint.X; border--)
                        arrayToReturn.Add(new Point(border, diagonalEndPoint.Y));
                    for (int border = diagonalEndPoint.Y; border <= diagonalStartPoint.Y; border++)
                        arrayToReturn.Add(new Point(diagonalEndPoint.X, border));
                    for (int border = diagonalEndPoint.X; border <= diagonalStartPoint.X; border++)
                        arrayToReturn.Add(new Point(border, diagonalStartPoint.Y));
                }
                else
                {
                    for (int border = diagonalStartPoint.X; border <= diagonalEndPoint.X; border++)
                        arrayToReturn.Add(new Point(border, diagonalEndPoint.Y));
                    for (int border = diagonalEndPoint.Y; border <= diagonalStartPoint.Y; border++)
                        arrayToReturn.Add(new Point(diagonalEndPoint.X, border));
                    for (int border = diagonalEndPoint.X; border >= diagonalStartPoint.X; border--)
                        arrayToReturn.Add(new Point(border, diagonalStartPoint.Y));
                }
            }
            else
            {
                for (int border = diagonalStartPoint.Y; border <= diagonalEndPoint.Y; border++)
                    arrayToReturn.Add(new Point(diagonalStartPoint.X, border));
                if (diagonalStartPoint.X > diagonalEndPoint.X)
                {
                    for (int border = diagonalStartPoint.X; border >= diagonalEndPoint.X; border--)
                        arrayToReturn.Add(new Point(border, diagonalEndPoint.Y));
                    for (int border = diagonalEndPoint.Y; border >= diagonalStartPoint.Y; border--)
                        arrayToReturn.Add(new Point(diagonalEndPoint.X, border));
                    for (int border = diagonalEndPoint.X; border <= diagonalStartPoint.X; border++)
                        arrayToReturn.Add(new Point(border, diagonalStartPoint.Y));
                }
                else
                {
                    for (int border = diagonalStartPoint.X; border <= diagonalEndPoint.X; border++)
                        arrayToReturn.Add(new Point(border, diagonalEndPoint.Y));
                    for (int border = diagonalEndPoint.Y; border >= diagonalStartPoint.Y; border--)
                        arrayToReturn.Add(new Point(diagonalEndPoint.X, border));
                    for (int border = diagonalEndPoint.X; border >= diagonalStartPoint.X; border--)
                        arrayToReturn.Add(new Point(border, diagonalStartPoint.Y));
                }
            }
            return arrayToReturn;
        }//method
    }
}
