using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class SepiaFilter : Filters
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
            int k = 42;
            Color resultColor = Color.FromArgb(Clamp((int)(intensity + 2 * k), 0, 255),
                                               Clamp((int)(intensity + 0.5 * k), 0, 255),
                                               Clamp((int)(intensity - 1 * k), 0, 255));

            return resultColor;
        }
    }
}
