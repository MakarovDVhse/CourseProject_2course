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
    public partial class DBCreation : Form
    {
        public void CrButtonChecck()
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
        public DBCreation()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.EraseEverything();
            this.Close();
        }

        private void CountryBox_TextChanged(object sender, EventArgs e)
        {
            Program.CountryName = CountryBox.Text;
            CrButtonChecck();
        }

        private void RegionBox_TextChanged(object sender, EventArgs e)
        {
            Program.RegionName = RegionBox.Text;
            CrButtonChecck();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Program.LocalityName = NameBox.Text;
            CrButtonChecck();
        }

        private void DBCreation_Load(object sender, EventArgs e)
        {
            CountryBox.Text = Program.CountryName;
            RegionBox.Text = Program.RegionName;
            NameBox.Text = Program.LocalityName;
            ExtraInfoBox.Text = Program.ExtraInfo;
            CrButtonChecck();
        }

        private void ExtraInfoBox_TextChanged(object sender, EventArgs e)
        {
            Program.ExtraInfo = ExtraInfoBox.Text;
        }

        private void CrButton_Click(object sender, EventArgs e)
        {
            Program.Triger1 = 0;
            Program.Triger2 = 0;
            CreateLandscape createLandscape = new CreateLandscape();
            createLandscape.Show();
            this.Close();
        }
    }
}
