using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPLApplication
{
    internal class CommandParser
    {
        private Graphics Graphics;
        private bool isFillOn = false;
        private Color color= Color.Black;
        private int xPos = 0;
        private int yPos = 0;

        public CommandParser(Graphics graphics) {
            this.Graphics = graphics;
        }
        public void AllCommandParser(String singleLineCodeVal, String multipleLineCodeVal, Boolean isSyntaxCheckOnly) {
            String ProcessCMD = getInputCommand(singleLineCodeVal, multipleLineCodeVal);

            string[] ProcessCMDByLine = ProcessCMD.Split(
                new string[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            foreach (string cmdByLine in ProcessCMDByLine)
            {
                if (!String.IsNullOrEmpty(cmdByLine))
                {
                    runCmd(cmdByLine);
                }
                   
            }

            
        }

        private void runCmd(string cmdByLine)
        {
            //splitting whole command into command and parameter section
            int firstSpaceIndex = cmdByLine.Trim().IndexOf(" ");
            string cmdPartOnly;
            List<String> parameterList = new List<String>();
            if (firstSpaceIndex > 0)
            {
                cmdPartOnly = cmdByLine.Substring(0, firstSpaceIndex);
                //splitting paramater into arraylist
                string parameterPartOnly = cmdByLine.Substring(firstSpaceIndex + 1);
                if (!String.IsNullOrEmpty(parameterPartOnly))
                {
                    string[] parameterSplits = parameterPartOnly.Split(',');
                    foreach (string parameterSplit in parameterSplits)
                    {
                        if (!String.IsNullOrEmpty(parameterSplit.Trim()))
                        {
                            parameterList.Add(parameterSplit);
                        }

                    }
                }
            }
            else
            {
                cmdPartOnly = cmdByLine;
            }
            cmdPartOnly = cmdPartOnly.ToLower().Trim();

           Shape shape = null;

            if (cmdPartOnly.StartsWith("rectangle"))
            {

                shape = new RectangleShape(Graphics, isFillOn, color, xPos, yPos, parameterList);
                shape.Validate();
                shape.Draw();

            }
            else if (cmdPartOnly.StartsWith("circle"))
            {

                shape = new CircleShape(Graphics, isFillOn, color, xPos, yPos, parameterList);
                shape.Validate();
                shape.Draw();

            }
            else if (cmdPartOnly.StartsWith("drawto"))
            {
                shape = new DrawToShape(Graphics, isFillOn, color, xPos, yPos, parameterList);
                shape.Validate();
                shape.Draw();

            }
            else if (cmdPartOnly.StartsWith("moveto"))
            {
                if (parameterList.Count != 2)
                {
                    throw new GPLException("Moveto param error");
                }

                this.xPos = int.Parse(parameterList[0]);
                this.yPos = int.Parse(parameterList[1]);
            }
            else if (cmdPartOnly.StartsWith("triangle"))
            {

                shape = new TriangleShape(Graphics, isFillOn, color, xPos, yPos, parameterList);
                shape.Validate();
                shape.Draw();

            }
            else if (cmdPartOnly.StartsWith("clear"))
            {
                Graphics.Clear(System.Drawing.SystemColors.ActiveCaption);
            }
            else if (cmdPartOnly.StartsWith("reset"))
            {
                AllCommandParser(cmdPartOnly, "clear", false);
                this.xPos = 0;
                this.yPos = 0;
                this.color = Color.Black;


            }
            else if (cmdPartOnly.StartsWith("pen"))
            {
                if (parameterList.Count != 1)
                {
                    throw new GPLException("Pen param error");
                }
                String colorName = (string)parameterList[0];
                this.color = Color.FromName(colorName);
            }
            else if (cmdPartOnly.StartsWith("fill"))
            {
                if (parameterList.Count != 1)
                {
                    throw new GPLException("Fill param error");
                }

                String fillOn = (string)parameterList[0];
                if (fillOn.ToLower().Trim().Equals("on"))
                {
                    this.isFillOn = true;
                }
                else
                {
                    this.isFillOn = false;
                }

               
            }
            else
            {
                throw new GPLException("Cmd error");
            }
        }

        public String getInputCommand(String singleLineCodeVal, String multipleLineCodeVal)
        {

            if (String.IsNullOrEmpty(singleLineCodeVal))
            {
                if (String.IsNullOrEmpty(multipleLineCodeVal))
                {
                    throw new GPLException("no command pass");
                }
                return multipleLineCodeVal;
            }
            return singleLineCodeVal;
        }
    }
}
