using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab1
{
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();

            float[,] mask = MathMorphology.mask;
            int maskSize = mask.GetLength(0);

            String[] lines = new String[maskSize];
            for (int i = 0; i < maskSize; i++)
            {
                String line = "";
                for (int j = 0; j < maskSize; j++)
                {
                    line += (int)mask[i, j];
                }
                lines[i] = line;
            }
            textBox.Lines = lines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: show error message if line length != number of lines or if any wrong character found
            Close();
        }

        public String[] getLines()
        {
            return textBox.Lines;
        }
    }
}
