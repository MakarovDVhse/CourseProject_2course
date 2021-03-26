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
    public partial class DrawingChangeObj : Form
    {
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
            Program.MapPositionUObj[Program.uobject.Id] = map;
        }
        public DrawingChangeObj()
        {
            InitializeComponent();
        }

        private void DrawingChangeObj_Load(object sender, EventArgs e)
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
            ChangeObjCon con = new ChangeObjCon();
            con.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MapMain.Refresh();
            Program.ReSetCurrentMap();
            graphics = Graphics.FromImage(Program.CurrentMap);
            MapMain.Image = Program.CurrentMap;
            Painted();
        }

        private void MapMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SolidBrush brush = new SolidBrush(Program.Ucolor);
                CurrentPoint = e.Location;
                graphics.FillRectangle(brush, PreviousPoint.X, PreviousPoint.Y, Math.Abs(CurrentPoint.X - PreviousPoint.X), Math.Abs(CurrentPoint.Y - PreviousPoint.Y));
                MapMain.Invalidate();
            }
            Painted();
        }

        private void MapMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PreviousPoint = e.Location;
            }
        }

        private void Make_Click(object sender, EventArgs e)
        {
            AddPosition();
            MainChangingWindow main = new MainChangingWindow();
            main.Show();
            this.Close();
        }
    }
}
