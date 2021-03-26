using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourse_2
{
    [Serializable]
    public class UObj
    {
        public int Id;
        public string Name;
        public string Type;
        public string Street;
        public string Num;
        public string ExtraInfo;
        public UObj()
        {
            Id = 0;
            Name = null;
            Type = null;
            Street = null;
            Num = null;
            ExtraInfo = null;
        }
        public UObj(int key, string n, string t, string s, string num, string ei)
        {
            Id = key;
            Name = n;
            Type = t;
            Street = s;
            Num = num;
            ExtraInfo = ei;
        }
    }
}
