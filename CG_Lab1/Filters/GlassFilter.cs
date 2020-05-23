using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class GlassFilter : Filters
    {
        private Random rand;

        public GlassFilter()
        {
            rand = new Random();
        }
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = Clamp((int)(x + (rand.Next(0, 2) - 0.5) * 10), 1, sourceImage.Width-1);
            int newY = Clamp((int)(y + (rand.Next(0, 2) - 0.5) * 10), 1, sourceImage.Height-1);
            Color resultColor = sourceImage.GetPixel(newX, newY);

            return resultColor;
        }
    }
}
