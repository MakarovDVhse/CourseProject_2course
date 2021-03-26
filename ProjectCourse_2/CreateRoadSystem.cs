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
    public partial class CreateRoadSystem : Form
    {
        public void DeleteandChangeCheck()
        {
            if (Program.CurrentOpertedDataBase.Tables[1].Rows.Count == 0)
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
        public CreateRoadSystem()
        {
            InitializeComponent();
        }

        private void CreateRoadSystem_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = Program.CurrentOpertedDataBase.Tables[1];
            RTable.DataSource = data;
            RTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DeleteandChangeCheck();
        }

        private void оТипахДорогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutR about = new AboutR();
            about.Show();
        }

        private void посмотретьКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
        }

        private void CancelButtonR_Click(object sender, EventArgs e)
        {
            if (Program.Triger2 == 0)
            {
                CreateLandscape landscape = new CreateLandscape();
                landscape.Show();
                this.Close();
            }
            else
            {
                MainChangingWindow main = new MainChangingWindow();
                main.Show();
                this.Close();
            }
        }

        private void AddElem_Click(object sender, EventArgs e)
        {
            Program.road = new RObj();
            AddR add = new AddR();
            add.Show();
            this.Close();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.road = new RObj();
            AddR add = new AddR();
            add.Show();
            this.Close();
        }

        private void DeleteElem_Click(object sender, EventArgs e)
        {
            DeleteR delete = new DeleteR();
            delete.Show();
            this.Close();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteR delete = new DeleteR();
            delete.Show();
            this.Close();
        }

        private void ChangeElem_Click(object sender, EventArgs e)
        {
            ChangeR change = new ChangeR();
            change.Show();
            this.Close();
        }

        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeR change = new ChangeR();
            change.Show();
            this.Close();
        }

        private void ConButtonR_Click(object sender, EventArgs e)
        {           
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }
    }
}
