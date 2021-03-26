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
    public partial class AddLS : Form
    {
        public void ToDrawingLSCheck()
        {
            string name = Program.land.Name;
            string type = Program.land.Type;
            if (name != null && type != null && (type == Program.LStype[0] || type == Program.LStype[1]))
            {
                if (name != "" && type != "" && (type == Program.LStype[0] || type == Program.LStype[1]))
                {
                    if (name != " " && type != " " && (type == Program.LStype[0] || type == Program.LStype[1]))
                        ToDraswingLS.Enabled = true;
                    else
                        ToDraswingLS.Enabled = false;
                }
                else
                    ToDraswingLS.Enabled = false;
            }
            else
            {
                ToDraswingLS.Enabled = false;
            }
        }
        public AddLS()
        {
            InitializeComponent();
        }

        private void CancelAddLS_Click(object sender, EventArgs e)
        {
            CreateLandscape landscape = new CreateLandscape();
            landscape.Show();
            this.Close();
        }

        private void AddLS_Load(object sender, EventArgs e)
        {
            NameBox.Text = Program.land.Name;
            LSFilter.Text = Program.land.Type;
            ExtraInfoBox.Text = Program.land.ExtraInfo;
            LSFilter.Items.AddRange(Program.LStype);
            ToDrawingLSCheck();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Program.land.Name = NameBox.Text;
            ToDrawingLSCheck();
        }

        private void LSFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.land.Type = LSFilter.Text;
            ToDrawingLSCheck();
        }

        private void ExtraInfoBox_TextChanged(object sender, EventArgs e)
        {
            Program.land.ExtraInfo = ExtraInfoBox.Text;
        }

        private void ToDraswingLS_Click(object sender, EventArgs e)
        {
            if (LSFilter.Text == Program.LStype[0])
                Program.LScolor = Color.LightBlue;
            else
                Program.LScolor = Color.DarkGreen;
            AddLSToMap addLSToMap = new AddLSToMap();
            addLSToMap.Show();
            this.Close();
        }
    }
}
