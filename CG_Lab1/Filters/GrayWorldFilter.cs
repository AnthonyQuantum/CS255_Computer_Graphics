using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class GrayWorldFilter : Filters
    {
        private Color mean;
        private int avg;
        public GrayWorldFilter(Bitmap sourceImage)
        {
            long sumR = 0;
            long sumG = 0;
            long sumB = 0;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color pixel = sourceImage.GetPixel(i, j);
                    sumR += pixel.R;
                    sumG += pixel.G;
                    sumB += pixel.B;
                }
            }

            long pixelCount = sourceImage.Width * sourceImage.Height;
            mean = Color.FromArgb((int)(sumR / pixelCount),
                                  (int)(sumG / pixelCount),
                                  (int)(sumB / pixelCount));
            avg = (mean.R + mean.G + mean.B) / 3;
        }

        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R * avg / mean.R, 0, 255),
                                               Clamp(sourceColor.G * avg / mean.G, 0, 255),
                                               Clamp(sourceColor.B * avg / mean.B, 0, 255));

            return resultColor;
        }
    }
}
