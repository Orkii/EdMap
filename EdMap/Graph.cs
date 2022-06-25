using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdMap {
    class Graph {
        List<Point> list;
        double[,] roadLength;
        public Graph() {
            list = new List<Point>();
        }
    }
}
