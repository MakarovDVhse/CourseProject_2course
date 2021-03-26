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
    public partial class ChangeObjCon : Form
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
        public ChangeObjCon()
        {
            InitializeComponent();
        }
        public void ToDrawingUCheck()
        {
            string name = NameBox.Text;
            string type = UFilter.Text;
            string street = StreetFilter.Text;
            string num = NumBox.Text;
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

        private void ChangeObjCon_Load(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[2].Select("Id = " + Program.uobject.Id);
            var row = rows[0];
            NameBox.Text = row[1].ToString();
            UFilter.Text = row[2].ToString();
            StreetFilter.Text = row[3].ToString();
            NumBox.Text = row[4].ToString();
            ExtraInfo.Text = row[5].ToString();
            ToDrawingUCheck();
        }

        private void CancelAddObj_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            ToDrawingUCheck();
        }

        private void UFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDrawingUCheck();
        }

        private void StreetFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDrawingUCheck();
        }

        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            ToDrawingUCheck();
        }

        private void ToDraswingObj_Click(object sender, EventArgs e)
        {
            Program.Ucolor = Program.TypeColor[UFilter.Text];
            var rows = Program.CurrentOpertedDataBase.Tables[2].Select("Id = " + Program.uobject.Id);
            var row = rows[0];
            int index = Program.CurrentOpertedDataBase.Tables[2].Rows.IndexOf(row);
            Program.CurrentOpertedDataBase.Tables[2].Rows[index][1] = NameBox.Text;
            Program.CurrentOpertedDataBase.Tables[2].Rows[index][2] = UFilter.Text;
            Program.CurrentOpertedDataBase.Tables[2].Rows[index][3] = StreetFilter.Text;
            Program.CurrentOpertedDataBase.Tables[2].Rows[index][4] = NumBox.Text;
            Program.CurrentOpertedDataBase.Tables[2].Rows[index][5] = ExtraInfo.Text;
            DrawingChangeObj drawing = new DrawingChangeObj();
            drawing.Show();
            this.Close();
        }
    }
}
