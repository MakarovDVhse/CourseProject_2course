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
    public partial class AdressSearch : Form
    {
        public void StreetCheck()
        {
            Search.Enabled = false;
            for (int i = 0; i < Program.StreetMas.Count; i++)
            {
                if (StreetFilter.Text == Program.StreetMas[i])
                    Search.Enabled = true;
            }
        }
        public void PaintObject(PixelMap map)
        {
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
            if (StreetFilter.Text != null && StreetFilter.Text != "" && StreetFilter.Text != " " && NumBox.Text != null && NumBox.Text != "" && NumBox.Text != " ")
            {
                Search.Enabled = true;
                StreetCheck();
            }
            else
                Search.Enabled = false;
        }
        public AdressSearch()
        {
            InitializeComponent();
        }

        private void CancelSearch_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void AdressSearch_Load(object sender, EventArgs e)
        {
            StreetFilter.Items.AddRange(Program.StreetMas.ToArray());
            InputCheck();
        }

        private void StreetFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            InputCheck();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Program.SetFindMap();
            var rows = Program.CurrentOpertedDataBase.Tables[2].Select();
            Program.FindID = -1;
            foreach (var row in rows)
            {
                if (row[3].ToString() == StreetFilter.Text && row[4].ToString() == NumBox.Text)
                    Program.FindID = Convert.ToInt32(row[0]);
            }
            if (Program.FindID == -1)
                MessageBox.Show("Ни одного подходящего элемента найдено не было", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                PixelMap map = Program.MapPositionUObj[Convert.ToInt32(Program.FindID)];
                PaintObject(map);
                AdressSearchResult result = new AdressSearchResult();
                result.Show();
                this.Close();
            }
        }
    }
}
