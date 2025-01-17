﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApplication
{
    internal class CircleShape : Shape
    {
        public CircleShape(Graphics graphics, bool isFillOn, Color color, int xPos, int yPos, List<string> parameter) : base(graphics, isFillOn, color, xPos, yPos, parameter)
        {
        }

        public override void Validate()
        {
            if (parameterList.Count != 1)
            {
                throw new GPLException("Circle param error");
            }

            Boolean isNumeric = int.TryParse(parameterList[0], out _);
            if (!isNumeric)
            {
                throw new GPLException("Circle param value is not a number.");
            }
        }

        public override void Draw()
        {
            int radius = int.Parse(parameterList[0]);

            if (isFillOn)
            {
                Graphics.FillEllipse(new SolidBrush(color), xPos - radius, yPos - radius, 2 * radius, 2 * radius);
            }
            else
            {
                Graphics.DrawEllipse(new Pen(color), xPos - radius, yPos - radius, 2 * radius, 2 * radius);
            }
        }
    }
}
