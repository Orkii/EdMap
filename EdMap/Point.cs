using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdMap {
    class Point {
        public string name { get; private set; }
        public GMapMarker marker { get; private set; }
        public PointLatLng location { get { return marker.Position; } }
        public bool storage { get; private set; }

        private float _weight;
        public float weight { get { if (storage == true) throw new Exception("У склада смотрят вес"); else return _weight; } set { if (storage == true) throw new Exception("У склада смотрят вес"); else _weight = value; } }


        public Point(GMapMarker marker_, string name_, float weight_) {
            marker = marker_;
            name = name_;
            _weight = weight_;
        }
        public Point(GMapMarker marker_, string name_) {
            marker = marker_;
            name = name_;
            storage = true;
        }
        public override string ToString() {
            return name + "\n" + "Вес " + _weight;
        }


    }
}
