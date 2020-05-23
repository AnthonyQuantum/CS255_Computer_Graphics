using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CG_Lab1
{
    class Opening : MathMorphology
    {
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Erosion erosion = new Erosion();
            Bitmap erImage = applyFilter(sourceImage, erosion.calculateNewPixelColor, worker);

            Dilation dilation = new Dilation();
            Bitmap resultImage = applyFilter(erImage, dilation.calculateNewPixelColor, worker);

            return resultImage;
        }
    }
}
