using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ProjectCourse_2
{
    static class Program
    {
        // создание таблиц программой
        public static DataTable MakeLandscape(DataTable ls)
        {
            DataColumn idLS = new DataColumn("Id", typeof(int));
            idLS.Unique = true;
            idLS.AllowDBNull = false;
            idLS.AutoIncrement = true;
            idLS.AutoIncrementSeed = 1;
            idLS.AutoIncrementStep = 1;
            DataColumn NameLS = new DataColumn("Наименование", typeof(string));
            NameLS.AllowDBNull = false;
            DataColumn TypeLS = new DataColumn("Тип", typeof(string));
            TypeLS.AllowDBNull = false;
            DataColumn ExtraInfoLS = new DataColumn("Доп. информация", typeof(string));
            ExtraInfoLS.AllowDBNull = true;
            ls.Columns.Add(idLS);
            ls.Columns.Add(NameLS);
            ls.Columns.Add(TypeLS);
            ls.Columns.Add(ExtraInfoLS);
            ls.PrimaryKey = new DataColumn[] { ls.Columns["Id"] };
            return ls;
        }
        // создание таблиц программой
        public static DataTable MakeRoadSystem(DataTable r)
        {
            DataColumn idR = new DataColumn("Id", typeof(int));
            idR.Unique = true;
            idR.AllowDBNull = false;
            idR.AutoIncrement = true;
            idR.AutoIncrementSeed = 1;
            idR.AutoIncrementStep = 1;
            DataColumn NameR = new DataColumn("Наименование", typeof(string));
            NameR.AllowDBNull = false;
            DataColumn TypeR = new DataColumn("Тип", typeof(string));
            TypeR.AllowDBNull = false;
            DataColumn ExtraInfoR = new DataColumn("Доп. информация", typeof(string));
            ExtraInfoR.AllowDBNull = true;
            r.Columns.Add(idR);
            r.Columns.Add(NameR);
            r.Columns.Add(TypeR);
            r.Columns.Add(ExtraInfoR);
            r.PrimaryKey = new DataColumn[] { r.Columns["Id"] };
            return r;
        }
        // создание таблиц программой
        public static DataTable MakeUrbanObject(DataTable uo)
        {
            DataColumn idUO = new DataColumn("Id", typeof(int));
            idUO.Unique = true;
            idUO.AllowDBNull = false;
            idUO.AutoIncrement = true;
            idUO.AutoIncrementSeed = 1;
            idUO.AutoIncrementStep = 1;
            DataColumn NameUO = new DataColumn("Наименование", typeof(string));
            NameUO.AllowDBNull = false;
            DataColumn TypeUO = new DataColumn("Тип", typeof(string));
            TypeUO.AllowDBNull = false;
            DataColumn StreetUO = new DataColumn("Улица", typeof(string));
            StreetUO.DefaultValue = "-";
            StreetUO.AllowDBNull = false;
            DataColumn StreetNumUO = new DataColumn("Номер", typeof(string));
            StreetNumUO.DefaultValue = "-";
            StreetNumUO.AllowDBNull = false;
            DataColumn ExtraInfoUO = new DataColumn("Доп. информация", typeof(string));
            ExtraInfoUO.AllowDBNull = true;
            uo.Columns.Add(idUO);
            uo.Columns.Add(NameUO);
            uo.Columns.Add(TypeUO);
            uo.Columns.Add(StreetUO);
            uo.Columns.Add(StreetNumUO);
            uo.Columns.Add(ExtraInfoUO);
            uo.PrimaryKey = new DataColumn[] { uo.Columns["Id"] };
            return uo;
        }
        // создание таблиц программой
        public static void MakeDataSet()
        {
            DataTable Landscape = new DataTable();
            DataTable RoadSystem = new DataTable();
            DataTable UrbanObject = new DataTable();

            Landscape = MakeLandscape(Landscape);

            RoadSystem = MakeRoadSystem(RoadSystem);

            UrbanObject = MakeUrbanObject(UrbanObject);

            CurrentOpertedDataBase.Tables.Add(Landscape);
            CurrentOpertedDataBase.Tables.Add(RoadSystem);
            CurrentOpertedDataBase.Tables.Add(UrbanObject);
        }
        // создание таблиц программой
        public static DataTable MakeLType(DataTable ls)
        {
            DataColumn idLS = new DataColumn("Id", typeof(int));
            DataColumn TypeLS = new DataColumn("Тип", typeof(string));            
            ls.Columns.Add(idLS);
            ls.Columns.Add(TypeLS);
            ls.PrimaryKey = new DataColumn[] { ls.Columns["Id"] };
            return ls;
        }
        // создание таблиц программой
        public static DataTable MakeRType(DataTable r)
        {
            DataColumn idR = new DataColumn("Id", typeof(int));          
            DataColumn TypeR = new DataColumn("Тип", typeof(string));           
            r.Columns.Add(idR);
            r.Columns.Add(TypeR);
            r.PrimaryKey = new DataColumn[] { r.Columns["Id"] };
            return r;
        }
        // создание таблиц программой
        public static DataTable MakeUType(DataTable uo)
        {
            DataColumn idUO = new DataColumn("Id", typeof(int));
            DataColumn TypeUO = new DataColumn("Тип", typeof(string));
            TypeUO.AllowDBNull = false;
            uo.Columns.Add(idUO);
            uo.Columns.Add(TypeUO);
            uo.PrimaryKey = new DataColumn[] { uo.Columns["Id"] };
            return uo;
        }
        // создание таблиц программой
        public static void MakeConnecction()
        {
            DataTable LType = new DataTable();
            DataTable RType = new DataTable();
            DataTable UType = new DataTable();

            LType = MakeLType(LType);
            RType = MakeRType(RType);
            UType = MakeUType(UType);

            LType.Rows.Add(new object[] { 1, "Водный объект" });
            LType.Rows.Add(new object[] { 2, "Лесной массив" });

            RType.Rows.Add(new object[] { 1, "Улица" });
            RType.Rows.Add(new object[] { 2, "Проспект" });
            RType.Rows.Add(new object[] { 3, "Шоссе" });

            UType.Rows.Add(new object[] { 1, "Жилищная инфраструктура" });
            UType.Rows.Add(new object[] { 2, "Социальная инфраструктура" });
            UType.Rows.Add(new object[] { 3, "Природная территория" });
            UType.Rows.Add(new object[] { 4, "Производственная инфраструктура" });
            UType.Rows.Add(new object[] { 5, "Коммерческая инфраструктура" });
            UType.Rows.Add(new object[] { 6, "Культурный объект" });

            TypeDataBase.Tables.Add(LType);
            TypeDataBase.Tables.Add(RType);
            TypeDataBase.Tables.Add(UType);

            // Соединение с MS SQL Server Management studio
            //string connecctionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CourseProject_2;Integrated Security=True";
            //string sql = "SELECT * FROM LS_type; SELECT * FROM R_type; SELECT * FROM U_type;";
            //using (SqlConnection connection = new SqlConnection(connecctionString))
            //{
            //    connection.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            //    adapter.Fill(TypeDataBase);
            //    connection.Close();
            //}
        }
        // переменные хранящие позицию объекта на карте
        public static void AddColumn()
        {
            MapPositionLS = new Dictionary<int, PixelMap>();
            MapPositionR = new Dictionary<int, PixelMap>();
            MapPositionUObj = new Dictionary<int, PixelMap>();
        }
        // создание массива для передачи всплывающим спискам в полях 
        public static void MakeTypeMas()
        {
            MakeLSType();
            MakeRType();
            MakeUType();
        }
        public static void MakeLSType()
        {
            LStype = new string[] { TypeDataBase.Tables[0].Rows[0][1].ToString(), TypeDataBase.Tables[0].Rows[1][1].ToString()};
        }
        public static void MakeRType()
        {
            RType = new string[] { TypeDataBase.Tables[1].Rows[0][1].ToString(), TypeDataBase.Tables[1].Rows[1][1].ToString(), TypeDataBase.Tables[1].Rows[2][1].ToString() };
        }
        public static void MakeUType()
        {
            UType = new string[TypeDataBase.Tables[2].Rows.Count];
            for (int i = 0; i < TypeDataBase.Tables[2].Rows.Count; i++)
            {
                UType[i] = TypeDataBase.Tables[2].Rows[i][1].ToString();
            }
        }
        public static void EraseEverything()
        {
            CountryName = null;
            RegionName = null;
            LocalityName = null;
            ExtraInfo = null;
            CurrentOpertedDataBase = null;
            TypeDataBase = null;
            LStype = null;
            RType = null;
            UType = null;
            StreetMas = null;
        }
        public static void SetPreviousMap()
        {
            for (int y = 0; y < CurrentMap.Height; y++)
            {
                for (int x = 0; x < CurrentMap.Width; x++)
                {
                    PreviousMap.SetPixel(x, y, CurrentMap.GetPixel(x, y));
                }
            }
        }
        public static void ReSetCurrentMap()
        {
            for (int y = 0; y < CurrentMap.Height; y++)
            {
                for (int x = 0; x < CurrentMap.Width; x++)
                {
                    CurrentMap.SetPixel(x, y, PreviousMap.GetPixel(x, y));
                }
            }
        }
        public static void SetFindMap()
        {
            for (int y = 0; y < CurrentMap.Height; y++)
            {
                for (int x = 0; x < CurrentMap.Width; x++)
                {
                    FindMap.SetPixel(x, y, CurrentMap.GetPixel(x, y));
                }
            }
        }
        public static void CreateMap()
        {
            CurrentMap = new Bitmap(984, 570);
            PreviousMap = new Bitmap(984, 570);
            FindMap = new Bitmap(984, 570);
        }
        public static void MakeStreetMas()
        {
            StreetMas = new List<string>();
            for (int i = 0; i < CurrentOpertedDataBase.Tables[1].Rows.Count; i++)
            {
                string abb;
                if (CurrentOpertedDataBase.Tables[1].Rows[i][2].ToString() == "Улица")
                    abb = "ул.";
                else if (CurrentOpertedDataBase.Tables[1].Rows[i][2].ToString() == "Проспект")
                    abb = "пр.";
                else
                    abb = "ш.";
                StreetMas.Add(abb + " " + CurrentOpertedDataBase.Tables[1].Rows[i][1].ToString());
            }
        }
        public static void MakeTypeColor()
        {
            TypeColor = new Dictionary<string, Color>();
            TypeColor.Add(UType[0], Color.Gray);
            TypeColor.Add(UType[1], Color.Pink);
            TypeColor.Add(UType[2], Color.Green);
            TypeColor.Add(UType[3], Color.Yellow);
            TypeColor.Add(UType[4], Color.Blue);
            TypeColor.Add(UType[5], Color.Purple);
        }
        public static void MakeHeadersType()
        {
            HeadersType = new string[] { "Ландшафт", "Дорожная система", "Градостроительные объекты" };
        }
        public static void MakeHeaders()
        {
            Headers = new Dictionary<string, int>();
            Headers.Add(HeadersType[0], 0);
            Headers.Add(HeadersType[1], 0);
            Headers.Add(HeadersType[2], 0);
        }
        public static string CountryName;
        public static string RegionName;
        public static string LocalityName;
        public static string ExtraInfo;
        public static DataSet CurrentOpertedDataBase;
        public static DataSet TypeDataBase;
        public static string[] LStype;
        public static string[] RType;
        public static string[] UType;
        public static string[] HeadersType;
        public static LSObj land;
        public static Color LScolor;
        public static RObj road;
        public static Color Rcolor;
        public static UObj uobject;
        public static Color Ucolor;

        public static Dictionary<int, PixelMap> MapPositionLS;
        public static Dictionary<int, PixelMap> MapPositionR;
        public static Dictionary<int, PixelMap> MapPositionUObj;
        public static Bitmap PreviousMap;
        public static Bitmap CurrentMap;
        public static Bitmap FindMap;
        public static string[] NameorID = new string[] { "Id", "Наименование" };
        public static int Triger1;
        public static int Triger2;
        public static List<string> StreetMas;
        public static Dictionary<string, Color> TypeColor;
        public static Dictionary<string, int> Headers;
        public static int FindID;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
