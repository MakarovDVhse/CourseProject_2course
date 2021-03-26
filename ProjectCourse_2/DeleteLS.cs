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
    public partial class DeleteLS : Form
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
                    Delete.Enabled = true;
                else
                    Delete.Enabled = false;
            }
            else
                Delete.Enabled = false;
        }
        public DeleteLS()
        {
            InitializeComponent();
        }

        private void DeleteLS_Load(object sender, EventArgs e)
        {
            InputCheck();
            LSfilter.Items.AddRange(Program.NameorID);
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

        private void Delete_Click(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[0].Select("[" + LSfilter.Text + "] = '" + Input.Text + "'");
            if (rows.Length == 0)
                MessageBox.Show("Ни одного подходящего элемента найдено не было", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var row in rows)
                {
                    PixelMap map = Program.MapPositionLS[Convert.ToInt32(row[0])];
                    ClearObject(map);
                    Program.MapPositionLS.Remove(Convert.ToInt32(row[0]));
                    Program.CurrentOpertedDataBase.Tables[0].Rows.Remove(row);
                }
                MessageBox.Show("Все подходящие элементы удалены", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
