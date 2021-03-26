using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class Pixel
    {
        public int x;
        public int y;
        public Color color;
        public Pixel(int a, int b, Color cl)
        {
            x = a;
            y = b;
            color = cl;
        }
    }
}
