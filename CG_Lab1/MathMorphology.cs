using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class MathMorphology : MatrixFilter
    {
        public static float[,] mask = new float[,] {
            { 0, 1, 0},
            { 1, 1, 1},
            { 0, 1, 0}
        };
    }
}
