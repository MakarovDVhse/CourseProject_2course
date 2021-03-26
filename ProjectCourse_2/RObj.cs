using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class RObj
    {
        public int Id;
        public string Name;
        public string Type;
        public string ExtraInfo;
        public RObj()
        {
            Id = 0;
            Name = null;
            Type = null;
            ExtraInfo = null;
        }
        public RObj(int key, string n, string t, string ei)
        {
            Id = key;
            Name = n;
            Type = t;
            ExtraInfo = ei;
        }
    }
}
