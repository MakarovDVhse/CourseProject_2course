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
    public partial class ChangeLS : Form
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
            if (Input.Text != null && Input.Text != "" && Input.Text != " " && (LSfilter.Text == Program.NameorID[0] || LSfilter.Text == Program.NameorID[1]))
            {
                if (LSfilter.Text == Program.NameorID[0] && int.TryParse(Input.Text, out x) || LSfilter.Text == Program.NameorID[1])
                    Change.Enabled = true;
                else
                    Change.Enabled = false;
            }
            else
                Change.Enabled = false;
        }
        public ChangeLS()
        {
            InitializeComponent();
        }

        private void ChangeLS_Load(object sender, EventArgs e)
        {
            LSfilter.Items.AddRange(Program.NameorID);
            InputCheck();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CreateLandscape landscape = new CreateLandscape();
            landscape.Show();
            this.Close();
        }

        private void LSfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[0].Select("[" + LSfilter.Text + "] = '" + Input.Text + "'");
            if (rows.Length == 0)
                MessageBox.Show("Ни одного подходящего элемента найдено не было", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var row = rows[0];
                PixelMap map = Program.MapPositionLS[Convert.ToInt32(row[0])];
                ClearObject(map);
                Program.land = new LSObj();
                Program.land.Id = Convert.ToInt32(row[0]);
                ChangeLSCon con = new ChangeLSCon();
                con.Show();
                this.Close();
            }
        }
    }
}
