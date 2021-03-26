using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCourse_2
{
    public partial class MainChangingWindow : Form
    {
        public Bitmap CopyToMap(PixelMap map)
        {
            Bitmap bitmap = new Bitmap(984, 570);
            int index = 0;
            for (int y = 0; y < Program.CurrentMap.Height; y++)
            {
                for (int x = 0; x < Program.CurrentMap.Width; x++)
                {
                    bitmap.SetPixel(x, y, map.pixels[index].color);
                    index++;
                }
            }
            return(bitmap);
        }
        public PixelMap CopyToPixelMap(Bitmap bitmap)
        {
            PixelMap map = new PixelMap();
            for (int y = 0; y < Program.CurrentMap.Height; y++)
            {
                for (int x = 0; x < Program.CurrentMap.Width; x++)
                {
                    map.pixels.Add(new Pixel(x, y, bitmap.GetPixel(x, y)));
                }
            }
            return (map);
        }
        public void Search()
        {
            if (Program.CurrentOpertedDataBase.Tables[0].Rows.Count == 0 && Program.CurrentOpertedDataBase.Tables[1].Rows.Count == 0 && Program.CurrentOpertedDataBase.Tables[2].Rows.Count == 0)
            {
                изменениеЛандшафтаToolStripMenuItem.Enabled = false;
                поАдресуToolStripMenuItem.Enabled = false;
            }
        }
        public void StreetCheck()
        {
            if (Program.StreetMas.Count == 0)
            {
                Add.Enabled = false;
            }
            else
            {
                Add.Enabled = true;
            }
        }
        public void DeleteandChangeCheck()
        {
            if (Program.CurrentOpertedDataBase.Tables[2].Rows.Count == 0)
            {
                Delete.Enabled = false;
                Change.Enabled = false;
            }
            else
            {
                Delete.Enabled = true;
                Change.Enabled = true;
            }
        }
        public MainChangingWindow()
        {
            InitializeComponent();
        }

        private void изменениеЛандшафтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Triger1 = 1;
            CreateLandscape landscape = new CreateLandscape();
            landscape.Show();
            this.Close();
        }

        private void изменениеДорожнойСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Triger2 = 1;
            CreateRoadSystem roadSystem = new CreateRoadSystem();
            roadSystem.Show();
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.Show();
        }

        private void оТипахГрадостроительныхОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutObj about = new AboutObj();
            about.Show();
        }

        private void посмотретьКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
        }

        private void MainChangingWindow_Load(object sender, EventArgs e)
        {
            Program.MakeStreetMas();
            DataTable data = new DataTable();
            data = Program.CurrentOpertedDataBase.Tables[2];
            UTable.DataSource = data;
            UTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DeleteandChangeCheck();
            StreetCheck();
            Search();
        }

        private void допИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBInfo info = new DBInfo();
            info.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Program.uobject = new UObj();
            AddObj add = new AddObj();
            add.Show();
            this.Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            ChangeObj obj = new ChangeObj();
            obj.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteObj obj = new DeleteObj();
            obj.Show();
            this.Close();
        }

        private void элементЛандшафтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameorIdSearch search = new NameorIdSearch();
            search.Show();
            this.Close();
        }

        private void поАдресуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdressSearch search = new AdressSearch();
            search.Show();
            this.Close();
        }

        private void новаяБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CountryName = "";
            Program.RegionName = "";
            Program.LocalityName = "";
            Program.ExtraInfo = "";
            Program.CurrentOpertedDataBase = new DataSet();
            Program.TypeDataBase = new DataSet();
            Program.MakeConnecction();
            Program.MakeDataSet();
            Program.AddColumn();
            Program.MakeTypeMas();
            Program.CreateMap();
            Program.MakeTypeColor();
            Program.MakeHeadersType();
            Program.MakeHeaders();
            DBCreation dB = new DBCreation();
            dB.Show();
            this.Close();           
        }

        private void сохранитьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile sf = new SaveFile();
            sf.CountryName = Program.CountryName;
            sf.RegionName = Program.RegionName;
            sf.LocalityName = Program.LocalityName;
            sf.ExtraInfo = Program.ExtraInfo;
            sf.CurrentMap = Program.CurrentMap;
            sf.MLS = new MapPosition[Program.MapPositionLS.Count];
            sf.landscape = new LSObj[Program.MapPositionLS.Count];
            sf.MR = new MapPosition[Program.MapPositionR.Count];
            sf.roadsystem = new RObj[Program.MapPositionR.Count];
            sf.MUObj = new MapPosition[Program.MapPositionR.Count];
            sf.urbanobjects = new UObj[Program.MapPositionR.Count];
            for (int i = 0; i < Program.MapPositionLS.Count; i++)
            {
                Bitmap map = CopyToMap(Program.MapPositionLS[Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[0].Rows[i][0])]);
                sf.MLS[i] = new MapPosition(Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[0].Rows[i][0]), map);
                sf.landscape[i] = new LSObj(Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[0].Rows[i][0]), Program.CurrentOpertedDataBase.Tables[0].Rows[i][1].ToString(), Program.CurrentOpertedDataBase.Tables[0].Rows[i][2].ToString(), Program.CurrentOpertedDataBase.Tables[0].Rows[i][3].ToString());
            }
            for (int i = 0; i < Program.MapPositionR.Count; i++)
            {
                Bitmap map = CopyToMap(Program.MapPositionR[Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[1].Rows[i][0])]);
                sf.MR[i] = new MapPosition(Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[1].Rows[i][0]), map);
                sf.roadsystem[i] = new RObj(Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[1].Rows[i][0]), Program.CurrentOpertedDataBase.Tables[1].Rows[i][1].ToString(), Program.CurrentOpertedDataBase.Tables[1].Rows[i][2].ToString(), Program.CurrentOpertedDataBase.Tables[1].Rows[i][3].ToString());
            }
            for (int i = 0; i < Program.MapPositionUObj.Count; i++)
            {
                Bitmap map = CopyToMap(Program.MapPositionUObj[Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[2].Rows[i][0])]);
                sf.MUObj[i] = new MapPosition(Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[2].Rows[i][0]), map);
                sf.urbanobjects[i] = new UObj(Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[2].Rows[i][0]), Program.CurrentOpertedDataBase.Tables[2].Rows[i][1].ToString(), Program.CurrentOpertedDataBase.Tables[2].Rows[i][2].ToString(), Program.CurrentOpertedDataBase.Tables[2].Rows[i][3].ToString(), Program.CurrentOpertedDataBase.Tables[2].Rows[i][4].ToString(), Program.CurrentOpertedDataBase.Tables[2].Rows[i][5].ToString());
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Binary files (*.bin)|*.bin";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Сохранение отменено", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {              
                BinaryFormatter binary = new BinaryFormatter();
                string filename = saveFile.FileName;
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    binary.Serialize(fs, sf);
                    MessageBox.Show("Файл сохранён", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void загрузитьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Binary files (*.bin)|*.bin";
            if (open.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Загрузка отменена", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                BinaryFormatter binary = new BinaryFormatter();
                string filename = open.FileName;
                SaveFile LoadedSave = null;
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    LoadedSave = (SaveFile)binary.Deserialize(fs);
                    MessageBox.Show("Файл открыт", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Program.CreateMap();
                Program.CountryName = LoadedSave.CountryName;
                Program.RegionName = LoadedSave.RegionName;
                Program.LocalityName = LoadedSave.LocalityName;
                Program.ExtraInfo = LoadedSave.ExtraInfo;
                Program.CurrentMap = LoadedSave.CurrentMap;
                Program.TypeDataBase = new DataSet();
                Program.CurrentOpertedDataBase = new DataSet();
                Program.MakeDataSet();
                Program.MakeConnecction();
                Program.AddColumn();
                for (int i = 0; i < LoadedSave.MLS.Length; i++)
                {
                    PixelMap map = CopyToPixelMap(LoadedSave.MLS[i].map);
                    Program.MapPositionLS.Add(LoadedSave.MLS[i].id, map);
                    Program.CurrentOpertedDataBase.Tables[0].Rows.Add(LoadedSave.landscape[i].Id, LoadedSave.landscape[i].Name, LoadedSave.landscape[i].Type, LoadedSave.landscape[i].ExtraInfo);
                }
                if (Program.MapPositionLS.Count != 0)
                    Program.CurrentOpertedDataBase.Tables[0].Columns[0].AutoIncrementSeed = Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[0].Rows[Program.MapPositionLS.Count - 1][0]);
                for (int i = 0; i < LoadedSave.MR.Length; i++)
                {
                    PixelMap map = CopyToPixelMap(LoadedSave.MR[i].map);
                    Program.MapPositionR.Add(LoadedSave.MR[i].id, map);
                    Program.CurrentOpertedDataBase.Tables[1].Rows.Add(LoadedSave.roadsystem[i].Id, LoadedSave.roadsystem[i].Name, LoadedSave.roadsystem[i].Type, LoadedSave.roadsystem[i].ExtraInfo);
                }
                if (Program.MapPositionR.Count != 0)
                    Program.CurrentOpertedDataBase.Tables[1].Columns[0].AutoIncrementSeed = Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[1].Rows[Program.MapPositionR.Count - 1][0]);
                for (int i = 0; i < LoadedSave.MUObj.Length; i++)
                {
                    PixelMap map = CopyToPixelMap(LoadedSave.MUObj[i].map);
                    Program.MapPositionUObj.Add(LoadedSave.MUObj[i].id, map);
                    Program.CurrentOpertedDataBase.Tables[2].Rows.Add(LoadedSave.urbanobjects[i].Id, LoadedSave.urbanobjects[i].Name, LoadedSave.urbanobjects[i].Type, LoadedSave.urbanobjects[i].Street, LoadedSave.urbanobjects[i].Num, LoadedSave.urbanobjects[i].ExtraInfo);
                }
                if (Program.MapPositionUObj.Count != 0)
                    Program.CurrentOpertedDataBase.Tables[2].Columns[0].AutoIncrementSeed = Convert.ToInt32(Program.CurrentOpertedDataBase.Tables[2].Rows[Program.MapPositionUObj.Count - 1][0]);
                Program.MakeTypeMas();
                Program.MakeTypeColor();
                Program.MakeHeadersType();
                Program.MakeHeaders();
                MainChangingWindow main = new MainChangingWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
