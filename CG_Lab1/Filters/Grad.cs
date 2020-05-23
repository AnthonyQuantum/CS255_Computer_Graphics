using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class Grad : MathMorphology
    {
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Dilation dilation = new Dilation();
            Bitmap dilImage = applyFilter(sourceImage, dilation.calculateNewPixelColor, worker);

            Erosion erosion = new Erosion();
            Bitmap erImage = applyFilter(sourceImage, erosion.calculateNewPixelColor, worker);

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                // ???
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color dilPixel = dilImage.GetPixel(i, j);
                    Color erPixel = erImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, Color.FromArgb(
                        Clamp(dilPixel.R - erPixel.R, 0, 255),
                        Clamp(dilPixel.G - erPixel.G, 0, 255),
                        Clamp(dilPixel.B - erPixel.B, 0, 255)
                    ));
                }
            }

            return resultImage;
        }
    }
}
