using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class EmbossFilter : MatrixFilter
    {
        public EmbossFilter()
        {
            kernel = new float[,] {
                        {  0,  1,  0},
                        {  1,  0, -1},
                        {  0, -1,  0}
                    };
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            GrayScaleFilter grayScaleFilter = new GrayScaleFilter();
            Bitmap gsImage = applyFilter(sourceImage, grayScaleFilter.calculateNewPixelColor, worker);

            Bitmap resultImage = applyFilter(gsImage, calculateNewPixelColor, worker);

            return resultImage;
        }

        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            // TODO: make a function of this code block because it occures a few times in this program
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            }

            return Color.FromArgb(
                ((int)resultR + 255*2) / 4,
                ((int)resultG + 255*2) / 4,
                ((int)resultB + 255*2) / 4);
        }
    }
}
