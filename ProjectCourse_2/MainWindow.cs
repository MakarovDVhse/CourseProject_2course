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
    public partial class MainWindow : Form
    {
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateDB_Click(object sender, EventArgs e)
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
            DBCreation dbCreation = new DBCreation();
            dbCreation.Show();
        }

        private void DownloadDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
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
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
