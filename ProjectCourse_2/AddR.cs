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
    
    public partial class AddR : Form
    {
        public void ToDrawingRCheck()
        {
            string name = Program.road.Name;
            string type = Program.road.Type;
            if (name != null && type != null && (type == Program.RType[0] || type == Program.RType[1] || type == Program.RType[2]))
            {
                if (name != "" && type != "" && (type == Program.RType[0] || type == Program.RType[1] || type == Program.RType[2]))
                {
                    if (name != " " && type != " " && (type == Program.RType[0] || type == Program.RType[1] || type == Program.RType[2]))
                        ToDraswingR.Enabled = true;
                    else
                        ToDraswingR.Enabled = false;
                }
                else
                    ToDraswingR.Enabled = false;
            }
            else
            {
                ToDraswingR.Enabled = false;
            }
        }
        public AddR()
        {
            InitializeComponent();
        }

        private void AddR_Load(object sender, EventArgs e)
        {
            NameBox.Text = Program.road.Name;
            RFilter.Text = Program.road.Type;
            ExtraInfoBox.Text = Program.road.ExtraInfo;
            RFilter.Items.AddRange(Program.RType);
            ToDrawingRCheck();
        }

        private void CancelAddR_Click(object sender, EventArgs e)
        {
            CreateRoadSystem landscape = new CreateRoadSystem();
            landscape.Show();
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Program.road.Name = NameBox.Text;
            ToDrawingRCheck();
        }

        private void RFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.road.Type = RFilter.Text;
            ToDrawingRCheck();
        }

        private void ExtraInfoBox_TextChanged(object sender, EventArgs e)
        {
            Program.road.ExtraInfo = ExtraInfoBox.Text;
        }

        private void ToDraswingR_Click(object sender, EventArgs e)
        {
            Program.Rcolor = Color.Black;
            AddRToMap addRToMap = new AddRToMap();
            addRToMap.Show();
            this.Close();
        }
    }
}
