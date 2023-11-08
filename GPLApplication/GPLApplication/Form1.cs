using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPLApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtnClick(object sender, EventArgs e)
        {
            Graphics graphics = displayArea.CreateGraphics();
            CommandParser commandParser = new CommandParser(graphics);
            commandParser.AllCommandParser(singleLineCode.Text, multipleLineCode.Text, false);
        }

        private void syntaxBtnClick(object sender, EventArgs e)
        {
            Graphics graphics = displayArea.CreateGraphics();
            CommandParser commandParser = new CommandParser(graphics);
            commandParser.AllCommandParser(singleLineCode.Text, multipleLineCode.Text, true);
        }

        //save to file
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string saveFileLocation = saveFileDialog1.FileName;
            CommandParser commandParser = new CommandParser(null);
            File.WriteAllText(saveFileLocation, commandParser.getInputCommand(singleLineCode.Text, multipleLineCode.Text));
        }
        //read from file
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string readFileLocation = openFileDialog1.FileName;
            string cmdReadFromFile = File.ReadAllText(readFileLocation);
            multipleLineCode.Text = cmdReadFromFile;
        }

        private void multipleLineCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayArea_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
