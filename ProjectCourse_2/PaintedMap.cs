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
    public partial class PaintedMap : Form
    {
        public PaintedMap()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void PaintedMap_Load(object sender, EventArgs e)
        {
            MapMain.Image = Program.FindMap;
        }
    }
}
