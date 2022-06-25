using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EdMap {
    public partial class Form1 : Form {
        List<Point> points;
        Point storage;
        GMapOverlay markers;
        GMapOverlay roads;
        bool addMark;
        bool addStorage;
        int choseP = 0;
        Point mouseDownPos;
        public Form1() {
            InitializeComponent();
            addMark = false;
            addButton.BackColor = Color.Red;
            points = new List<Point>();
        }
        private void gMapControl1_Load_1(object sender, EventArgs e) {
            //Буква
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            //gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 


            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;


            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 15; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(54.7249055, 55.9454618);// точка в центре карты при открытии (центр России)
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы

            markers = new GMapOverlay("markers");
            gMapControl1.Overlays.Add(markers);

            roads = new GMapOverlay("road");
            gMapControl1.Overlays.Add(roads);
        }

        private void getPathButton_Click(object sender, EventArgs e) {
            Graph.calculate(storage, points, 50);

        }

        private void gMapControl1_OnMapClick(PointLatLng pointClick, MouseEventArgs e) {

            if (addMark == true) {

                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                GMapMarker mark = new GMarkerGoogle(point, GMarkerGoogleType.red);//широта, долгота, тип маркера
                mark.ToolTipText = "Точка № " + (points.Count + 1).ToString();
                points.Add(new Point(mark, mark.ToolTipText, 1));

                drawMarkers();
            }
            else if (addStorage) {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                GMapMarker mark = new GMarkerGoogle(point, GMarkerGoogleType.green_dot);//широта, долгота, тип маркера
                mark.ToolTipText = "Склад";
                storage = new Point(mark, mark.ToolTipText, 1);
                drawMarkers();
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            addMark = !addMark;
            addStorage = false;
            if (addMark == true) addButton.BackColor = Color.Green;
            else addButton.BackColor = Color.Red;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {

        }

        private void clearButton_Click(object sender, EventArgs e) {
            points.Clear();
            markers.Clear();
            roads.Clear();
            treeView1.Nodes.Clear();
            storage = null;
        }


        private void drawMarkers() {
            markers.Clear();
            if (storage != null) markers.Markers.Add(storage.marker);
            foreach (Point a in points) {
                markers.Markers.Add(a.marker);
            }
            if (tempMark != null) markers.Markers.Add(tempMark);
        }

        private void storageButtonAdd_Click(object sender, EventArgs e) {
            addStorage = !addStorage;
            addMark = false;
            addButton.BackColor = Color.Red;
        }

        GMapMarker tempMark;
        private void gMapControl1_OnMarkerEnter(GMapMarker item) {
            //Нужно когда наводят на маркер поменять ему цвет
            Console.WriteLine("IN");
            //tempMark = new GMarkerGoogle(item.Position, GMarkerGoogleType.blue);//широта, долгота, тип маркера
            //tempMark.ToolTipText = item.ToolTipText;
            
            //drawMarkers();

        }

        private void gMapControl1_OnMarkerLeave(GMapMarker item) {
            //Тут вернуть обратно
            Console.WriteLine("OUT");

            //item.IsVisible = true;
            //tempMark.Dispose();
            //tempMark = null;
            
            //drawMarkers();


        }
    }
}
