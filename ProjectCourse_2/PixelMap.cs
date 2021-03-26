using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class PixelMap
    {
        public List<Pixel> pixels;
        public PixelMap()
        {
            pixels = new List<Pixel>();
        }
    }
}
