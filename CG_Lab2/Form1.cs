using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab2
{
    public partial class Form1 : Form
    {
        Bin bin;
        View view;
        bool loaded;
        int currentLayer;
        int FrameCount;
        DateTime NextFPSUpdate;
        bool needReload;

        public Form1()
        {
            InitializeComponent();

            bin = new Bin();
            view = new View();
            NextFPSUpdate = DateTime.Now.AddSeconds(1);
            loaded = false;
            currentLayer = 0;
            needReload = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                loaded = true;
                resize();
                trackBar1.Maximum = Bin.Z - 1;
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (quadsRadioButton.Checked)
                {
                    view.DrawQuads(currentLayer, tfMinTrackBar.Value, tfWidthTrackBar.Value);
                }
                else if (quadStripRadioButton.Checked)
                {
                    view.DrawQuadStrip(currentLayer, tfMinTrackBar.Value, tfWidthTrackBar.Value);
                }
                else if (textureRadioButton.Checked)
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer, tfMinTrackBar.Value, tfWidthTrackBar.Value);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    view.DrawTexture();
                }
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value - 1;

            if (textureRadioButton.Checked)
            {
                needReload = true;
            }
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps: {0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        private void textureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (textureRadioButton.Checked)
            {
                needReload = true;
            }
        }

        private void tfMinTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (textureRadioButton.Checked)
            {
                needReload = true;
            }
        }

        private void tfWidthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (textureRadioButton.Checked)
            {
                needReload = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void resize()
        {
            if (!loaded) return;

            int newWidth = Size.Width - glControl1.Location.X;
            int newHeight = Size.Height - glControl1.Location.Y;

            glControl1.Width = newWidth;
            glControl1.Height = newHeight;

            float aspectRatio = (float)Bin.X / Bin.Y;

            if ((float)newWidth / newHeight > aspectRatio)
            {
                newWidth = (int)(newHeight * aspectRatio);
            }
            else if ((float)newWidth / newHeight < aspectRatio)
            {
                newHeight = (int)(newWidth / aspectRatio);
            }

            view.SetupView(newWidth, newHeight);
        }
    }
}
