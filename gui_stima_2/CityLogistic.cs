using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.Drawing;

namespace gui_stima_2
{
    class CityLogistic
    {
        public static Dictionary<string, List<String>> cityEdge = new Dictionary<string, List<String>>();
        public static Dictionary<KeyValuePair<String, String>, double> val = new Dictionary<KeyValuePair<string, string>, double>();
        public static Dictionary<string, int> timeFirst = new Dictionary<string, int>();
        public static List<string> infected = new List<string>();

        public static void ImportLogistic(string dir)
        {
            StreamReader sr = new StreamReader(dir);
            string ns = sr.ReadLine();
            int n = Convert.ToInt32(ns);
            timeFirst[City.start] = 0;

            for(int i = 0; i < n; i++)
            {
                string[] a = sr.ReadLine().Split(' ');
                if (cityEdge.ContainsKey(a[0]))
                {
                    cityEdge[a[0]].Add(a[1]);
                }
                else
                {
                    List<String> init = new List<String>();
                    init.Add(a[1]);
                    cityEdge.Add(a[0], init);
                }
                val.Add(new KeyValuePair<string, string>(a[0], a[1]), double.Parse(a[2],CultureInfo.InvariantCulture));
            }
        }

        public static void BFS(int Time)
        {
            Queue<string> visiting = new Queue<string>();
            visiting.Enqueue(City.start);
            infected.Add(City.start);

            while (visiting.Count > 0)
            {
                string nowVisit = visiting.Dequeue();
                foreach(string newVisit in cityEdge[nowVisit])
                {
                    if (S(nowVisit, newVisit,Time) > 1)
                    {
                        visiting.Enqueue(newVisit);
                        infected.Add(newVisit);
                        int tFirst = Time;
                            
                        while (S(nowVisit, newVisit, tFirst) > 1)
                        {
                            tFirst--;
                        }
                        timeFirst[newVisit] = tFirst + 1;
                    }
                }
            }
        }

        public static int T(string a)
        {
            return timeFirst[a];
        }

        public static int t(string a,int Time)
        {
            return Time - T(a);
        }

        public static double Tr(string a, string b)
        {
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>(a, b);
            double nilai=0;
            if (val.TryGetValue(temp, out nilai))
            {
                return nilai;
            }
            return nilai;
        }

        public static double S(string a, string b,int time)
        {
            return City.I(a, t(a,time)) * Tr(a, b);
        }

    }
}
