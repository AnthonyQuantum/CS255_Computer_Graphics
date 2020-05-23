﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_Lab1
{
    class Dilation : MathMorphology
    {
        public override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int Width = sourceImage.Width;
            int Height = sourceImage.Height;

            int MH = mask.GetLength(0) / 2;
            int MW = mask.GetLength(1) / 2;

            Color max = Color.Black;
            for (int j = -MH; j <= MH; j++)
            {
                for (int i = -MW; i <= MW; i++)
                {
                    Color pixel = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1),
                                                       Clamp(y + j, 0, sourceImage.Height - 1));
                    int intensity = (int)((pixel.R + pixel.G + pixel.B) / 3.0f);
                    int maxIntensity = (int)((max.R + max.G + max.B) / 3.0f);

                    if (((int)(mask[i + MW, j + MH]) != 0) && (intensity > maxIntensity))
                    {
                        max = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1),
                                                   Clamp(y + j, 0, sourceImage.Height - 1));
                    }
                }
            }

            return max;
        }
    }
}