using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApplication
{
    internal class RectangleShape : Shape
    {
        public RectangleShape(Graphics graphics, bool isFillOn, Color color, int xPos, int yPos, List<string> parameter) : base(graphics, isFillOn, color, xPos, yPos, parameter)
        {
        }

        public override void Validate()
        {
            if (parameterList.Count != 2)
            {
                throw new GPLException("Rectangle param error");
            }
        }

        public override void Draw()
        {
            int Length = int.Parse(parameterList[0]);
            int Width = int.Parse(parameterList[1]);

            if (isFillOn)
            {
                Graphics.FillRectangle(new SolidBrush(color), xPos, yPos, Length, Width);
            }
            else
            {
                Graphics.DrawRectangle(new Pen(color), xPos, yPos, Length, Width);
            }
        }
    }
}
