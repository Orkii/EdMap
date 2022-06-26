using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            storageButtonAdd.BackColor = Color.Red;
            points = new List<Point>();
            label2.Text = "";
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
            Graph.connectForm(this);
            Thread thread = new Thread(doAlgorithm);
            thread.Start();
        }
        private void doAlgorithm() {
            List<Point> list = Graph.calculate(storage, points, 50);
            Point p = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                MapRoute r = OpenStreetMapProvider.Instance.GetRoute(p.location, list[i].location, false, false, 15);
                roads.Routes.Add(new GMapRoute(r));
                p = list[i];
            }
        }

        public void setProgressBar(int value)
        {//Менять текст прогресса из другого потока
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(setProgressBar), new object[] { value });
                return;
            }
            progressBar1.Value = value;
        }
        public void setMaxProgressBar(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(setMaxProgressBar), new object[] { value });
                return;
            }
            progressBar1.Maximum = value;
        }
        public void incrementProgressBar(int i = 0)
        {//Менять текст прогресса из другого потока
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(incrementProgressBar), new object[] { i });
                return;
            }
            progressBar1.Increment(1);
        }
        public void setTextLabel(string value)
        {//Менять текст прогресса из другого потока
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(setTextLabel), new object[] { value });
                return;
            }
            label2.Text = value;
        }

        private void gMapControl1_OnMapClick(PointLatLng pointClick, MouseEventArgs e) {
            if (addMark == true) {

                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                GMapMarker mark = new GMarkerGoogle(point, GMarkerGoogleType.red);//широта, долгота, тип маркера
                mark.ToolTipText = "Точка № " + (points.Count + 1).ToString();
                points.Add(new Point(mark, mark.ToolTipText, 1));
                treeView1.BeginUpdate();
                treeView1.Nodes.Add(new TreeNode(mark.ToolTipText));

                treeView1.EndUpdate();
                drawMarkers();
            }
            else if (addStorage) {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                GMapMarker mark = new GMarkerGoogle(point, GMarkerGoogleType.green_dot);//широта, долгота, тип маркера
                mark.ToolTipText = "Склад";
                int i = 0;
                storage = new Point(mark, mark.ToolTipText, 1);
                drawMarkers();

            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            addMark = !addMark;
            addStorage = false;
            if (addMark == true) {
                addButton.BackColor = Color.Green;
                storageButtonAdd.BackColor = Color.Red;
            }
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
            treeView1.Nodes.Clear();
            if (storage != null) {
                markers.Markers.Add(storage.marker);
                treeView1.Nodes.Add(new TreeNode(storage.name));
            }
            foreach (Point a in points) {
                markers.Markers.Add(a.marker);
                treeView1.Nodes.Add(new TreeNode(a.name));
            }



        }

        private void storageButtonAdd_Click(object sender, EventArgs e) {
            addStorage = !addStorage;
            addMark = false;
            if (addStorage == true) {
                storageButtonAdd.BackColor = Color.Green;
                addButton.BackColor = Color.Red;
            }
            else storageButtonAdd.BackColor = Color.Red;
        }

        
/*        private void gMapControl1_OnMarkerEnter(GMapMarker item) {
            //Нужно когда наводят на маркер поменять ему цвет

            //Console.WriteLine("IN");
            //tempMark = new GMarkerGoogle(item.Position, GMarkerGoogleType.blue);//широта, долгота, тип маркера
            //tempMark.ToolTipText = item.ToolTipText;
            //drawMarkers(); 



        }
*/
/*        private void gMapControl1_OnMarkerLeave(GMapMarker item) {
            //Тут вернуть обратно
            //Console.WriteLine("OUT");

            //item.IsVisible = true;
            //tempMark.Dispose();
            //tempMark = null;
            
            //drawMarkers();


        }*/ 
    }
}
