using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class Closing : MathMorphology
    {
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Dilation dilation = new Dilation();
            Bitmap dilImage = applyFilter(sourceImage, dilation.calculateNewPixelColor, worker);

            Erosion erosion = new Erosion();
            Bitmap resultImage = applyFilter(dilImage, erosion.calculateNewPixelColor, worker);

            return resultImage;
        }
    }
}
