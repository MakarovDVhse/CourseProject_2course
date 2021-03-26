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
    public partial class AdressSearchResult : Form
    {
        public AdressSearchResult()
        {
            InitializeComponent();
        }

        private void AdressSearchResult_Load(object sender, EventArgs e)
        {
            var rows = Program.CurrentOpertedDataBase.Tables[2].Select("Id = " + Program.FindID);
            var row = rows[0];
            NameBox.Text = row[1].ToString();
            TypeBox.Text = row[2].ToString();
            StreetBox.Text = row[3].ToString();
            NumBox.Text = row[4].ToString();
            ExtraInfo.Text = row[5].ToString();
        }

        private void CloseSearch_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void ToMap_Click(object sender, EventArgs e)
        {
            PaintedMap map = new PaintedMap();
            map.Show();
            this.Close();
        }
    }
}
