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
    public partial class DrawingChangeLS : Form
    {
        bool IsClicked = false;
        Point CurrentPoint;
        Point PreviousPoint;
        Graphics graphics;
        public void Painted()
        {
            Make.Enabled = false;
            for (int y = 0; y < Program.CurrentMap.Height; y++)
            {
                for (int x = 0; x < Program.CurrentMap.Width; x++)
                {
                    if (Program.CurrentMap.GetPixel(x, y) != Program.PreviousMap.GetPixel(x, y))
                        Make.Enabled = true;
                }
            }
        }
        public void AddPosition()
        {
            PixelMap map = new PixelMap();
            for (int y = 0; y < Program.CurrentMap.Height; y++)
            {
                for (int x = 0; x < Program.CurrentMap.Width; x++)
                {
                    if (Program.CurrentMap.GetPixel(x, y) == Program.PreviousMap.GetPixel(x, y))
                    {
                        map.pixels.Add(new Pixel(x, y, Color.White));
                    }
                    else
                    {
                        map.pixels.Add(new Pixel(x, y, Program.CurrentMap.GetPixel(x, y)));
                    }
                }
            }
            Program.MapPositionLS[Program.land.Id] = map;
        }
        public DrawingChangeLS()
        {
            InitializeComponent();
        }

        private void DrawingChangeLS_Load(object sender, EventArgs e)
        {
            Program.SetPreviousMap();
            graphics = Graphics.FromImage(Program.CurrentMap);
            MapMain.Image = Program.CurrentMap;
            Painted();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MapMain.Refresh();
            Program.ReSetCurrentMap();
            graphics = Graphics.FromImage(Program.CurrentMap);
            MapMain.Image = Program.CurrentMap;
            ChangeLSCon con = new ChangeLSCon();
            con.Show();
            this.Close();
        }

        private void MapMain_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            Painted();
        }

        private void MapMain_MouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            CurrentPoint = e.Location;
        }

        private void MapMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                PreviousPoint = CurrentPoint;
                CurrentPoint = e.Location;
                MakePaint();
            }
        }
        private void MakePaint()
        {
            Pen pen = new Pen(Program.LScolor, 25);
            graphics.DrawLine(pen, PreviousPoint, CurrentPoint);
            MapMain.Image = Program.CurrentMap;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MapMain.Refresh();
            Program.ReSetCurrentMap();
            graphics = Graphics.FromImage(Program.CurrentMap);
            MapMain.Image = Program.CurrentMap;
            Painted();
        }

        private void Make_Click(object sender, EventArgs e)
        {
            AddPosition();
            CreateLandscape landscape = new CreateLandscape();
            landscape.Show();
            this.Close();
        }
    }
}
