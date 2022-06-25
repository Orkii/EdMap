using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdMap {
    static class Graph {
        private static double ferAddConst = 1;
        private static double evaporation = 0.1;
        private static double ferStart = 0.5;

        private static int iterationCount = 1;

        public static void calculate(Point storage, List<Point> points, float loadСapacity) {
            int count = points.Count + 1;
            double[,] roadLength = new double[count, count];
            bool[] pointPassed = new bool[count];
            

            double[,] ferCount = new double[count, count];
            double[,] reverseLeng = new double[count, count];

            List<int> passedRoad = new List<int>();



            for (int i = 0; i < count; i++) {
                for (int j = 0; j < count; j++) {
                    ferCount[i, j] = ferStart;
                }
            }


            for (int i = 0; i < points.Count; i++) {
                for (int j = 0; j < points.Count; j++) {
                    if (i == j) continue;
                    roadLength[i + 1,j + 1] = OpenStreetMapProvider.Instance.GetRoute(points[i].location, points[j].location, false, false, 15).Distance;
                    reverseLeng[i + 1, j + 1] = 1 / roadLength[i + 1, j + 1];
                }
            }
            for (int i = 1; i < points.Count + 1; i++) {
                roadLength[0, i] = OpenStreetMapProvider.Instance.GetRoute(storage.location, points[i - 1].location, false, false, 15).Distance;
                roadLength[i, 0] = OpenStreetMapProvider.Instance.GetRoute(points[i - 1].location, storage.location, false, false, 15).Distance;
                reverseLeng[0, i ] = 1 / roadLength[0, i];
                reverseLeng[i, 0] = 1 / roadLength[i, 0];
            }



            for (int iteration = 0; iteration < iterationCount; iteration++) {


                int nowP = 0;
                float carWorkload = 0;
                pointPassed[0] = true;
                for (int countPointPassed = 0; countPointPassed < count - 1; countPointPassed++) {
                    double[] roadPercent = new double[count];
                    for (int i = 0; i < count; i++) {
                        if (pointPassed[i] == true) continue;
                        roadPercent[i] = ferCount[nowP, i] * reverseLeng[nowP, i];
                    }


                }

            }


        }
    }
}
