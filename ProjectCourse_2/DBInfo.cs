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
    public partial class DBInfo : Form
    {
        public void CrButtonCheck()
        {
            string cn = Program.CountryName;
            string rn = Program.RegionName;
            string ln = Program.LocalityName;
            if (cn != null && rn != null && ln != null)
            {
                if (cn != "" && rn != "" && ln != "")
                {
                    if (cn != " " && rn != " " && ln != " ")
                        CrButton.Enabled = true;
                    else
                        CrButton.Enabled = false;
                }
                else
                    CrButton.Enabled = false;
            }
            else
            {
                CrButton.Enabled = false;
            }
        }
        public DBInfo()
        {
            InitializeComponent();
        }

        private void DBInfo_Load(object sender, EventArgs e)
        {
            CountryBox.Text = Program.CountryName;
            RegionBox.Text = Program.RegionName;
            NameBox.Text = Program.LocalityName;
            ExtraInfoBox.Text = Program.ExtraInfo;
            CrButtonCheck();
        }

        private void CountryBox_TextChanged(object sender, EventArgs e)
        {
            Program.CountryName = CountryBox.Text;
            CrButtonCheck();
        }

        private void RegionBox_TextChanged(object sender, EventArgs e)
        {
            Program.RegionName = RegionBox.Text;
            CrButtonCheck();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Program.LocalityName = NameBox.Text;
            CrButtonCheck();
        }

        private void ExtraInfoBox_TextChanged(object sender, EventArgs e)
        {
            Program.ExtraInfo = ExtraInfoBox.Text;
        }

        private void CrButton_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }
    }
}
