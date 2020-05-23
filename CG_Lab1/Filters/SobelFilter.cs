using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Lab1
{
    class SobelFilter : MatrixFilter
    {
        public enum Type
        {
            X,
            Y
        }
        public SobelFilter(Type type = Type.X)
        {
            switch (type)
            {
                case Type.Y:
                    kernel = new float [,] {
                        { -1, -2, -1},
                        {  0,  0,  0},
                        {  1,  2,  1}
                    };
                    break;
                case Type.X:
                    kernel = new float[,] {
                        { -1,  0,  1},
                        { -2,  0,  2},
                        { -1,  0,  1}
                    };
                    break;
            }
        }
    }
}
