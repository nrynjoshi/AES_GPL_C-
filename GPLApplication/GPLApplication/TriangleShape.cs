using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApplication
{
    internal class TriangleShape : Shape
    {
        public TriangleShape(Graphics graphics, bool isFillOn, Color color, int xPos, int yPos, List<string> parameter) : base(graphics, isFillOn, color, xPos, yPos, parameter)
        {
        }

        public override void Validate()
        {
            if (parameterList.Count != 2)
            {
                throw new GPLException("Triangle param error");
            }
        }

        public override void Draw()
        {
            int x = int.Parse(parameterList[0]);
            int y = int.Parse(parameterList[1]);
            int size = 100;

            Point p = new Point(xPos, yPos);
            if (isFillOn)
            {
                Graphics.FillPolygon(Brushes.Aquamarine, new Point[] { p, new Point(x, y * 2), new Point(x + size, y * 2) });
            }
            else
            {
                Graphics.FillPolygon(Brushes.Aquamarine, new Point[] { p, new Point(x, y * 2), new Point(x + size, y * 2) });
            }
        }
    }
}
