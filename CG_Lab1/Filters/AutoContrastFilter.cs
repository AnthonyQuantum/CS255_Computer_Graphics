using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class AutoContrastFilter : Filters
    {
        private Color max;
        private Color min;
        public AutoContrastFilter(Bitmap sourceImage)
        {
            int maxR = 0;
            int maxG = 0;
            int maxB = 0;
            int minR = 255;
            int minG = 255;
            int minB = 255;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color pixel = sourceImage.GetPixel(i, j);
                    if (pixel.R > maxR) maxR = pixel.R;
                    if (pixel.G > maxG) maxG = pixel.G;
                    if (pixel.B > maxB) maxB = pixel.B;
                    if (pixel.R < minR) minR = pixel.R;
                    if (pixel.G < minG) minG = pixel.G;
                    if (pixel.B < minB) minB = pixel.B;
                }
            }

            max = Color.FromArgb(maxR, maxG, maxB);
            min = Color.FromArgb(minR, minG, minB);
        }

        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(calculateOneChannelColor(sourceColor.R, max.R, min.R),
                                               calculateOneChannelColor(sourceColor.G, max.G, min.G),
                                               calculateOneChannelColor(sourceColor.B, max.B, min.B));

            return resultColor;
        }

        protected int calculateOneChannelColor(int actual, int max, int min)
        {
            return 255 * (actual - min) / (max - min);
        }
    }
}
