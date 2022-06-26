using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdMap {
    static class Graph {
        //private static double ferAddConst = 0.001;
        //private static double evaporation = 0.000001;
        //private static double ferStart = 0.5;
        //private static int iterationCount = 100000;


        private static int maxAddThreadLoad = 2;

        public static double minFer = 0.05;
        public static double maxFer = 2.0;
        public static double ferAddConst = 0.5;
        public static double evaporation = 0.002;
        public static double ferStart = 10;
        public static int    iterationCount = 100000;
        public static double lengSignificance = 0.001;

        private static Form1 form;
        private static GMapOverlay overlay;


        private static double[,] roadLength;
        private static double[,] ferCount;
        private static double[,] reverseLeng;
        private static List<int> passedRoad;
        private static List<int> shortest;
        private static double totalDistance;

        private static int threadGoing;

        public static void connectForm(Form1 item) {
            form = item;
        }
        public static void connectOverlay(GMapOverlay item) {
            overlay = item;
        }


        private static List<Point> p;
        private static void load(int ind) {
          
        }

        public static List<Point> calculate(Point storage, List<Point> points, float loadСapacity) {
            p = points;
            int count = points.Count + 1;
            roadLength = new double[count, count];
            ferCount = new double[count, count];
            reverseLeng = new double[count, count];
            passedRoad = new List<int>();
            //shortest = new List<int>();
            double shortestD = double.MaxValue;
            totalDistance = 0;

            form.setTextLabel("Просчет длин всех дорог: ");
            form.setMaxProgressBar(count * (count - 1) /* + iterationCount*/);
            form.setProgressBar(0);
            for (int i = 0; i < count; i++) {
                for (int j = 0; j < count; j++) {
                    ferCount[i, j] = ferStart;
                }
            }

            for (int i = 0; i < points.Count; i++) {

                //Thread t = new param
                //ThreadWithState tws = new ThreadWithState(i);
                //Thread t = new Thread(new ThreadStart(tws.ThreadProc));
                //threadGoing++;
                //t.Start();

                for (int j = 0; j < points.Count; j++) {
                    if (i == j) continue;
                    roadLength[i + 1,j + 1] = OpenStreetMapProvider.Instance.GetRoute(points[i].location, points[j].location, false, false, 15).Distance;
                    //reverseLeng[i + 1, j + 1] = 1 / roadLength[i + 1, j + 1];
                    totalDistance += roadLength[i + 1, j + 1];
                    form.incrementProgressBar(1);
                }
            }
            for (int i = 1; i < points.Count + 1; i++) {


                roadLength[0, i] = OpenStreetMapProvider.Instance.GetRoute(storage.location, points[i - 1].location, false, false, 15).Distance;
                totalDistance += roadLength[0, i];
                form.incrementProgressBar(1);

                roadLength[i, 0] = OpenStreetMapProvider.Instance.GetRoute(points[i - 1].location, storage.location, false, false, 15).Distance;
                totalDistance += roadLength[i, 0];
                form.incrementProgressBar(1);

            }


            for (int i = 0; i < count; i++) {
                for (int j = 0; j < count; j++) {
                    if (i == j) continue;
                    reverseLeng[i, j] = totalDistance / roadLength[i, j] * lengSignificance;

                }
            }

            form.setTextLabel("Поиск кратчайшего пути: ");
            form.setMaxProgressBar(iterationCount);
            form.setProgressBar(0);

            for (int iteration = 0; iteration < iterationCount; iteration++) {
                //Debug.WriteLine("Итерация № " + iteration);
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
                            if (ferCount[i, j] < minFer) ferCount[i, j] = minFer;
                        }
                    }

                    int prevPoint = 0;
                    for (int i = 1; i < passedRoad.Count; i++) {
                        ferCount[prevPoint, passedRoad[i]] += ferAddConst / totalLength * totalDistance;
                        if (ferCount[prevPoint, passedRoad[i]] > maxFer) ferCount[prevPoint, passedRoad[i]] = maxFer;
                        prevPoint = passedRoad[i];
                    }
                }
                form.incrementProgressBar(1);

                List<Point> list = new List<Point>();
                foreach (int a in passedRoad) {
                    //Console.WriteLine(a);
                    if (a == 0) list.Add(storage);
                    else list.Add(points[a - 1]);
                }



                if (iteration % 1000 == 0) {


                    try {
                        overlay.Clear();
                    }
                    catch { goto skip; }
                    Point p = list[0];
                    //form.setLabel4(iteration.ToString());
                    double leng = 0;
                    for (int i = 1; i < passedRoad.Count; i++) {
                        MapRoute r = OpenStreetMapProvider.Instance.GetRoute(p.location, list[i].location, false, false, 15);
                        overlay.Routes.Add(new GMapRoute(r));
                        leng += r.Distance;
                        p = list[i];
                        //form.setLabel4(label4.Text + p.name + " ");
                    }
                    form.setLabel4(iteration.ToString() + " " + leng.ToString());
                skip:;
                }
                if (totalLength < shortestD) {
                    shortestD = totalLength;
                    shortest = passedRoad;
                    passedRoad = new List<int>();
                } 
            }
            /////

            List<Point> ret = new List<Point>();
            foreach (int a in shortest) {
                //Console.WriteLine(a);
                if (a == 0) ret.Add(storage);
                else ret.Add(points[a - 1]);
            }
            Thread.Sleep(700);
            return ret;

        }



        class ThreadWithState {
            private int  ind;
            public ThreadWithState(int ind_) {
                ind = ind_;
            }
            public void ThreadProc() {
                for (int j = 0; j < p.Count; j++) {
                    if (ind == j) continue;
                    //if (p[ind] == null) throw new Exception();
                    //if (p[j] == null) throw new Exception();
                    MapRoute ro = OpenStreetMapProvider.Instance.GetRoute(p[ind].location, p[j].location, false, false, 15);
                    if (ro == null) {
                        roadLength[ind + 1, j + 1] = double.MaxValue / 2;
                        Debug.WriteLine("NaN");
                    }
                    else {
                        roadLength[ind + 1, j + 1] = ro.Distance;
                        totalDistance += roadLength[ind + 1, j + 1];
                    }
                    //reverseLeng[i + 1, j + 1] = 1 / roadLength[i + 1, j + 1];
                    
                    form.incrementProgressBar(1);
                    Thread.Sleep(50);
                }
                threadGoing--;
            }

        }
    }
}
