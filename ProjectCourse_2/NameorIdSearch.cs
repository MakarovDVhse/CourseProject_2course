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
    public partial class NameorIdSearch : Form
    {
        public void PaintObject(PixelMap map)
        {
            Program.SetFindMap();
            int index = 0;
            for (int y = 0; y < Program.CurrentMap.Height; y++)
            {
                for (int x = 0; x < Program.CurrentMap.Width; x++)
                {
                    if (map.pixels[index].color != Color.White)
                        Program.FindMap.SetPixel(x, y, Color.Red);
                    index++;
                }
            }
        }
        public void InputCheck()
        {
            int x;
            if (Input.Text != null && Input.Text != "" && Input.Text != " " && (Filter.Text == Program.NameorID[0] || Filter.Text == Program.NameorID[1]) && (HeadersFilter.Text == Program.HeadersType[0] || HeadersFilter.Text == Program.HeadersType[1] || HeadersFilter.Text == Program.HeadersType[2]))
            {
                if (Filter.Text == Program.NameorID[0] && int.TryParse(Input.Text, out x) || Filter.Text == Program.NameorID[1])
                    SearchNId.Enabled = true;
                else
                    SearchNId.Enabled = false;
            }
            else
                SearchNId.Enabled = false;
        }
        public NameorIdSearch()
        {
            InitializeComponent();
        }

        private void NameorIdSearch_Load(object sender, EventArgs e)
        {
            HeadersFilter.Items.AddRange(Program.HeadersType);
            Filter.Items.AddRange(Program.NameorID);
            InputCheck();
        }

        private void CancelSearchNId_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void HeadersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void SearchNId_Click(object sender, EventArgs e)
        {
            Program.SetFindMap();
            if (HeadersFilter.Text == Program.HeadersType[0])
            {
                var rows = Program.CurrentOpertedDataBase.Tables[0].Select("[" + Filter.Text + "] = '" + Input.Text + "'");
                if (rows.Length == 0)
                    MessageBox.Show("Ни одного подходящего элемента найдено не было", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    var row = rows[0];
                    PixelMap map = Program.MapPositionLS[Convert.ToInt32(row[0])];
                    PaintObject(map);
                    Program.FindID = Convert.ToInt32(row[0]);
                    NameorIdSearchResultLS result = new NameorIdSearchResultLS();
                    result.Show();
                    this.Close();
                }
            }
            else if (HeadersFilter.Text == Program.HeadersType[1])
            {
                var rows = Program.CurrentOpertedDataBase.Tables[1].Select("[" + Filter.Text + "] = '" + Input.Text + "'");
                if (rows.Length == 0)
                    MessageBox.Show("Ни одного подходящего элемента найдено не было", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else 
                {
                    var row = rows[0];
                    PixelMap map = Program.MapPositionR[Convert.ToInt32(row[0])];
                    PaintObject(map);
                    Program.FindID = Convert.ToInt32(row[0]);
                    NameorIdSearchResultR result = new NameorIdSearchResultR();
                    result.Show();
                    this.Close();
                }
            }
            else
            {
                var rows = Program.CurrentOpertedDataBase.Tables[2].Select("[" + Filter.Text + "] = '" + Input.Text + "'");
                if (rows.Length == 0)
                    MessageBox.Show("Ни одного подходящего элемента найдено не было", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else 
                {
                    var row = rows[0];
                    PixelMap map = Program.MapPositionUObj[Convert.ToInt32(row[0])];
                    PaintObject(map);
                    Program.FindID = Convert.ToInt32(row[0]);
                    NameorIdSearchResultObj result = new NameorIdSearchResultObj();
                    result.Show();
                    this.Close();
                }
            }
        }
    }
}
