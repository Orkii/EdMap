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
        private static double ferAddConst = 0.1;
        private static double evaporation = 0.001;
        private static double ferStart = 0.5;

        private static int iterationCount = 1000;

        public static List<Point> calculate(Point storage, List<Point> points, float loadСapacity) {
            int count = points.Count + 1;
            double[,] roadLength = new double[count, count];
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
                Console.WriteLine("Итерация № " + iteration);
                passedRoad.Clear();
                int nowP = 0;
                passedRoad.Add(0);
                float carWorkload = 0;
                bool[] pointPassed = new bool[count];
                pointPassed[0] = true;
                double totalLength = 0;

                for (int countPointPassed = 0; countPointPassed < count - 1; countPointPassed++) {
                    double[] roadPercent = new double[count];

                    double totalP = 0;
                    for (int i = 0; i < count; i++) {
                        if (pointPassed[i] == true) continue;
                        if (i == nowP) continue;
                        roadPercent[i] = ferCount[nowP, i] * reverseLeng[nowP, i];
                        totalP += roadPercent[i];
                    }
                    for (int i = 0; i < count; i++) {
                        roadPercent[i] /= totalP;
                    }
                    Random a = new Random();
                    double rand = a.NextDouble();
                    int nextP = 0;
                    for (int i = 0; i < count; i++) {
                        rand -= roadPercent[i];
                        if (rand <= 0) {
                            nextP = i;
                            break;
                        }
                    }
                    if (nextP == 0) throw new Exception("Не найдено следующей точки");
                    pointPassed[nextP] = true;
                    totalLength += roadLength[nowP, nextP];
                    passedRoad.Add(nextP);
                    nowP = nextP;
                }//Прошли точки
                totalLength += roadLength[nowP, 0];
                passedRoad.Add(0);
                {
                    for (int i = 0; i < count; i++) {
                        for (int j = 0; j < count; j++) {
                            ferCount[i, j] -= evaporation;
                            if (ferCount[i, j] < 0) ferCount[i, j] = 0;
                        }
                    }
                
                    int prevPoint = 0;
                    for (int i = 1; i < passedRoad.Count; i++) {
                        ferCount[prevPoint, passedRoad[i]] += ferAddConst / totalLength;
                        prevPoint = passedRoad[i];
                    }
                }
            }
            /////

            List<Point> ret = new List<Point>();
            foreach(int a in passedRoad) {
                Console.WriteLine(a);
                if (a == 0) ret.Add(storage);
                else ret.Add(points[a - 1]);
            }

            return ret;
            
        }
    }
}
