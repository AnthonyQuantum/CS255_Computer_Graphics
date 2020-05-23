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
    public partial class Form1 : Form
    {
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);

                pictureBox.Image = image;
                pictureBox.Refresh();
            }
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox.Image = image;
                pictureBox.Refresh();
            }
            progressBar.Value = 0;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void brightenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightenFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter(SobelFilter.Type.X);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter(SobelFilter.Type.Y);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorldFilter(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void autoContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new AutoContrastFilter(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EmbossFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void verticalWavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new VerticalWavesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void size5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Dilation();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Erosion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void changeStructuralElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();

            String[] textBoxLines;
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                textBoxLines = prompt.getLines();
            } else return;

            int maskSize = textBoxLines.Length;
            float[,] newMask = new float[maskSize, maskSize];
            
            for (int i = 0; i < textBoxLines.Length; i++)
            {
                for (int j = 0; j < textBoxLines[i].Length; j++)
                {
                    newMask[i, j] = textBoxLines[i][j] - '0';
                }
            }

            MathMorphology.mask = newMask;
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Opening();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Closing();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Grad();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter(3);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
