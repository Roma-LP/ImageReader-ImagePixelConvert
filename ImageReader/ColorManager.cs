using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReader
{
    internal class ColorManager
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public byte A { get; private set; }
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }

        public ColorManager(int x, int y, byte a, byte r, byte g, byte b)
        {
            X = x;
            Y = y;
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public ColorManager(int x, int y, Color color) : this(x, y, color.A, color.R, color.G, color.B)
        {
        }

        public void SavePixelARGB(Color color)
        {
            A = color.A;
            R = color.R;
            G = color.G;
            B = color.B;
        }
    }
}