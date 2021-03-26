using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class LSObj
    {
        public int Id;
        public string Name;
        public string Type;
        public string ExtraInfo;
        public LSObj()
        {
            Id = 0;
            Name = null;
            Type = null;
            ExtraInfo = null;
        }
        public LSObj(int key, string n, string t, string ei)
        {
            Id = key;
            Name = n;
            Type = t;
            ExtraInfo = ei;
        }
    }
}
