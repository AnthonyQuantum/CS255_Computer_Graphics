using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter(int size)
        {
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] = i == j ? (1.0f / size) : 0;
                }
            }
        }
    }
}
