using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class MapPosition
    {
        public int id;
        public Bitmap map;
        public MapPosition(int key, Bitmap m)
        {
            id = key;
            map = m;
        }
        public MapPosition()
        {
            id = 0;
            map = null;
        }
    }
}
