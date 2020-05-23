using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class MedianFilter : Filters
    {
        protected int radius;
        public MedianFilter(int radius)
        {
            this.radius = radius;
        }

        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color[] neighborPixels = new Color[(radius * 2 + 1) * (radius * 2 + 1)];

            int i = 0;
            for (int l = -radius; l <= radius; l++)
            {
                for (int k = -radius; k <= radius; k++)
                { 
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    neighborPixels[i++] = sourceImage.GetPixel(idX, idY);
                }
            }

            neighborPixels = neighborPixels.OrderBy(px => (int)((px.R + px.G + px.B) / 3.0f)).ToArray();

            return neighborPixels[neighborPixels.Length / 2];
        }
    }
}
