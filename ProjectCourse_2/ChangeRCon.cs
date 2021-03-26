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
    public partial class ChangeRCon : Form
    {
        public void ToDrawingRCheck()
        {
            string name = NameBox.Text;
            string type = RFilter.Text;
            if (name != null && type != null && (type == "Улица" || type == "Проспект" || type == "Шоссе"))
            {
                if (name != "" && type != "" && (type == "Улица" || type == "Проспект" || type == "Шоссе"))
                {
                    if (name != " " && type != " " && (type == "Улица" || type == "Проспект" || type == "Шоссе"))
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
        public ChangeRCon()
        {
            InitializeComponent();
        }

        private void ChangeRCon_Load(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[1].Select("Id = " + Program.road.Id);
            var row = rows[0];
            NameBox.Text = row[1].ToString();
            RFilter.Text = row[2].ToString();
            ExtraInfo.Text = row[3].ToString();
            RFilter.Items.AddRange(Program.LStype);
            ToDrawingRCheck();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            ToDrawingRCheck();
        }

        private void RFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDrawingRCheck();
        }

        private void CancelChangeR_Click(object sender, EventArgs e)
        {
            CreateRoadSystem roadSystem = new CreateRoadSystem();
            roadSystem.Show();
            this.Close();
        }

        private void ToDraswingR_Click(object sender, EventArgs e)
        {
            Program.Rcolor = Color.Black;
            var rows = Program.CurrentOpertedDataBase.Tables[1].Select("Id = " + Program.road.Id);
            var row = rows[0];
            int index = Program.CurrentOpertedDataBase.Tables[1].Rows.IndexOf(row);
            Program.CurrentOpertedDataBase.Tables[1].Rows[index][1] = NameBox.Text;
            Program.CurrentOpertedDataBase.Tables[1].Rows[index][2] = RFilter.Text;
            Program.CurrentOpertedDataBase.Tables[1].Rows[index][3] = ExtraInfo.Text;
            DrawingChangeR drawing = new DrawingChangeR();
            drawing.Show();
            this.Close();
        }
    }
}
