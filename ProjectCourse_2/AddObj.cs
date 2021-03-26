using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCourse_2
{
    public partial class AddObj : Form
    {
        public void StreetCheck()
        {
            ToDraswingObj.Enabled = false;
            for (int i = 0; i < Program.StreetMas.Count; i++)
            {
                if (StreetFilter.Text == Program.StreetMas[i])
                    ToDraswingObj.Enabled = true;
            }
        }
        public void ToDrawingUObjCheck()
        {
            string name = Program.uobject.Name;
            string type = Program.uobject.Type;
            string street = Program.uobject.Street;
            string num = Program.uobject.Num;
            if (name != null && type != null && street != null && num != null && (type == Program.UType[0] || type == Program.UType[1] || type == Program.UType[2] || type == Program.UType[3] || type == Program.UType[4] || type == Program.UType[5]))
            {
                if (name != "" && type != "" && street != "" && num != "" && (type == Program.UType[0] || type == Program.UType[1] || type == Program.UType[2] || type == Program.UType[3] || type == Program.UType[4] || type == Program.UType[5]))
                {
                    if (name != " " && type != " " && street != " " && num != " " && (type == Program.UType[0] || type == Program.UType[1] || type == Program.UType[2] || type == Program.UType[3] || type == Program.UType[4] || type == Program.UType[5]))
                    {
                        ToDraswingObj.Enabled = true;
                        StreetCheck();
                    }
                    else
                        ToDraswingObj.Enabled = false;
                }
                else
                    ToDraswingObj.Enabled = false;
            }
            else
            {
                ToDraswingObj.Enabled = false;
            }
        }
        public AddObj()
        {
            InitializeComponent();
        }

        private void AddObj_Load(object sender, EventArgs e)
        {
            NameBox.Text = Program.uobject.Name;
            UFilter.Text = Program.uobject.Type;
            StreetFilter.Text = Program.uobject.Street;
            Num.Text = Program.uobject.Num;
            ExtraInfo.Text = Program.uobject.ExtraInfo;
            UFilter.Items.AddRange(Program.UType);
            StreetFilter.Items.AddRange(Program.StreetMas.ToArray());
            StreetFilter.AllowDrop = false;
            ToDrawingUObjCheck();
        }

        private void ToDraswingObj_Click(object sender, EventArgs e)
        {
            Program.Ucolor = Program.TypeColor[UFilter.Text];
            AddObjToMap addObjToMap = new AddObjToMap();
            addObjToMap.Show();
            this.Close();
        }

        private void CancelAddObj_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Program.uobject.Name = NameBox.Text;
            ToDrawingUObjCheck();
        }

        private void UFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.uobject.Type = UFilter.Text;
            ToDrawingUObjCheck();
        }

        private void StreetFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.uobject.Street = StreetFilter.Text;
            ToDrawingUObjCheck();
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {
            Program.uobject.Num = Num.Text;
            ToDrawingUObjCheck();
        }

        private void ExtraInfo_TextChanged(object sender, EventArgs e)
        {
            Program.uobject.ExtraInfo = ExtraInfo.Text;
        }
    }
}
