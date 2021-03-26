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
    public partial class ChangeLSCon : Form
    {
        public ChangeLSCon()
        {
            InitializeComponent();
        }
        public void ToDrawingLSCheck()
        {
            string name = Name1.Text;
            string type = Type.Text;
            if (name != null && type != null && (type == "Водный объект" || type == "Лесной массив"))
            {
                if (name != "" && type != "" && (type == "Водный объект" || type == "Лесной массив"))
                {
                    if (name != " " && type != " " && (type == "Водный объект" || type == "Лесной массив"))
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

        private void ChangeLSCon_Load(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[0].Select("Id = " + Program.land.Id);
            var row = rows[0];
            Name1.Text = row[1].ToString();
            Type.Text = row[2].ToString();
            ExtraInfo.Text = row[3].ToString();
            Type.Items.AddRange(Program.LStype);
            ToDrawingLSCheck();
        }

        private void CancelChange_Click(object sender, EventArgs e)
        {
            CreateLandscape landscape = new CreateLandscape();
            landscape.Show();
            this.Close();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            ToDrawingLSCheck();
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDrawingLSCheck();
        }

        private void ToDraswingLS_Click(object sender, EventArgs e)
        {
            if (Type.Text == Program.LStype[0])
                Program.LScolor = Color.LightBlue;
            else
                Program.LScolor = Color.DarkGreen;
            var rows = Program.CurrentOpertedDataBase.Tables[0].Select("Id = " + Program.land.Id);
            var row = rows[0];
            int index = Program.CurrentOpertedDataBase.Tables[0].Rows.IndexOf(row);
            Program.CurrentOpertedDataBase.Tables[0].Rows[index][1] = Name1.Text;
            Program.CurrentOpertedDataBase.Tables[0].Rows[index][2] = Type.Text;
            Program.CurrentOpertedDataBase.Tables[0].Rows[index][3] = ExtraInfo.Text;
            DrawingChangeLS drawing = new DrawingChangeLS();
            drawing.Show();
            this.Close();
        }
    }
}
