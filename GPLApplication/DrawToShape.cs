﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApplication
{
    internal class DrawToShape : Shape
    {
        public DrawToShape(Graphics graphics, bool isFillOn, Color color, int xPos, int yPos, List<string> parameter) : base(graphics, isFillOn, color, xPos, yPos, parameter)
        {
        }

        public override void Validate()
        {
            if (parameterList.Count != 2)
            {
                throw new GPLException("DrawTo param error");
            }

            Boolean isNumeric1 = int.TryParse(parameterList[0], out _);
            if (!isNumeric1)
            {
                throw new GPLException("DrawTo param first value is not a number.");
            }

            Boolean isNumeric2 = int.TryParse(parameterList[1], out _);
            if (!isNumeric2)
            {
                throw new GPLException("DrawTo param second value is not a number.");
            }
        }

        public override void Draw()
        {
            int xPoint = int.Parse(parameterList[0]);
            int yPoint = int.Parse(parameterList[1]);

            Graphics.DrawLine(new Pen(color), new PointF(xPos, yPos), new PointF(xPoint, yPoint));

        }
    }
}
