using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class VerticalWavesFilter : Filters
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = Clamp((int)(x + 20 * Math.Sin((2 * Math.PI * x) / 30)), 1, sourceImage.Width-1);
            Color resultColor = sourceImage.GetPixel(newX, y);

            return resultColor;
        }
    }
}
