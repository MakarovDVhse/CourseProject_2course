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
    public partial class ChangeObj : Form
    {
        public void ClearObject(PixelMap map)
        {
            int index = 0;
            for (int y = 0; y < Program.CurrentMap.Height; y++)
            {
                for (int x = 0; x < Program.CurrentMap.Width; x++)
                {
                    if (map.pixels[index].color != Color.White)
                        Program.CurrentMap.SetPixel(x, y, Color.White);
                    index++;
                }
            }
        }
        public void InputCheck()
        {
            int x;
            if (Input.Text != null && Input.Text != "" && Input.Text != " " && (UFilter.Text == Program.NameorID[0] || UFilter.Text == Program.NameorID[1]))
            {
                if (UFilter.Text == Program.NameorID[0] && int.TryParse(Input.Text, out x) || UFilter.Text == Program.NameorID[1])
                    Change.Enabled = true;
                else
                    Change.Enabled = false;
            }
            else
                Change.Enabled = false;
        }
        public ChangeObj()
        {
            InitializeComponent();
        }

        private void ChangeObj_Load(object sender, EventArgs e)
        {
            UFilter.Items.AddRange(Program.NameorID);
            InputCheck();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void UFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[2].Select("[" + UFilter.Text + "] = '" + Input.Text + "'");
            if (rows.Length == 0)
                MessageBox.Show("Ни одного подходящего элемента найдено не было", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var row = rows[0];
                PixelMap map = Program.MapPositionUObj[Convert.ToInt32(row[0])];
                ClearObject(map);
                Program.uobject = new UObj();
                Program.uobject.Id = Convert.ToInt32(row[0]);
                ChangeObjCon con = new ChangeObjCon();
                con.Show();
                this.Close();
            }
        }
    }
}
