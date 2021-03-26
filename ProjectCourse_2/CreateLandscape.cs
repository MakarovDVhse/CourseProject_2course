using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace ProjectCourse_2
{
    public partial class CreateLandscape : Form
    {
        public void DeleteandChangeCheck()
        {
            if (Program.CurrentOpertedDataBase.Tables[0].Rows.Count == 0)
            {
                DeleteElem.Enabled = false;
                ChangeElem.Enabled = false;
                изменитьЗаписьToolStripMenuItem.Enabled = false;
                удалитьЗаписьToolStripMenuItem.Enabled = false;
            }
            else
            {
                DeleteElem.Enabled = true;
                ChangeElem.Enabled = true;
                изменитьЗаписьToolStripMenuItem.Enabled = true;
                удалитьЗаписьToolStripMenuItem.Enabled = true;
            }
        }
        public CreateLandscape()
        {
            InitializeComponent();
        }

        private void CreateLandscape_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = Program.CurrentOpertedDataBase.Tables[0];
            LSTable.DataSource = data;
            LSTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DeleteandChangeCheck();
        }

        private void оТипахЛандшафтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutLS about = new AboutLS();
            about.Show();
        }

        private void посмотретьКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
        }

        private void AddElem_Click(object sender, EventArgs e)
        {
            Program.land = new LSObj();
            AddLS add = new AddLS();
            add.Show();
            this.Close();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.land = new LSObj();
            AddLS add = new AddLS();
            add.Show();
            this.Close();
        }

        private void CancelButtonLS_Click(object sender, EventArgs e)
        {
            if (Program.Triger1 == 0)
            {
                DBCreation dB = new DBCreation();
                dB.Show();
                this.Close();
            }
            else
            {
                MainChangingWindow main = new MainChangingWindow();
                main.Show();
                this.Close();
            }
        }

        private void DeleteElem_Click(object sender, EventArgs e)
        {
            DeleteLS delete = new DeleteLS();
            delete.Show();
            this.Close();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteLS delete = new DeleteLS();
            delete.Show();
            this.Close();
        }

        private void ChangeElem_Click(object sender, EventArgs e)
        {
            ChangeLS change = new ChangeLS();
            change.Show();
            this.Close();
        }

        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLS change = new ChangeLS();
            change.Show();
            this.Close();
        }

        private void ConButtonLS_Click(object sender, EventArgs e)
        {
            if (Program.Triger1 == 0)
            {
                CreateRoadSystem roadSystem = new CreateRoadSystem();
                roadSystem.Show();
                this.Close();
            }
            else
            {
                MainChangingWindow main = new MainChangingWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
