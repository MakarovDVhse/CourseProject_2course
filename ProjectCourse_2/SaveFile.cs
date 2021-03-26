using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class SaveFile
    {
        public string CountryName;
        public string RegionName;
        public string LocalityName;
        public string ExtraInfo;
        public Bitmap CurrentMap;
        public MapPosition[] MLS;
        public MapPosition[] MR;
        public MapPosition[] MUObj;
        public LSObj[] landscape;
        public RObj[] roadsystem;
        public UObj[] urbanobjects;
    }
}
