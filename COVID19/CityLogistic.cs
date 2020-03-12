using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID19
{
    class CityLogistic
    {

        public static Dictionary<string, string[]> cityEdge = new Dictionary<string, string[]>();
        public static Dictionary<KeyValuePair<String, String>, float> val = new Dictionary<KeyValuePair<string, string>, float>();
        public static Dictionary<string, int> timeFirst = new Dictionary<string, int>();



        public static void ImportLogistic(string dir)
        {
            StreamReader sr = new StreamReader(dir);
            string ns = sr.ReadLine();
            int n = Convert.ToInt32(ns);
            timeFirst[City.start] = 0;

            for(int i = 0; i < n; i++)
            {
                string[] a = sr.ReadLine().Split(' ');
                KeyValuePair<string, string> cityPair = new KeyValuePair<string, string>(a[0],a[1]);
                cityEdge[a[0]].Append(a[1]);
                val.Add(cityPair, float.Parse(a[2]));
            }
        }

        public static void BFS(int Time)
        {
            string[] infected = { City.start };
            Queue<string> visiting = new Queue<string>();
            visiting.Enqueue(City.start);

            while (visiting.Count > 0)
            {
                string nowVisit = visiting.Dequeue();
                foreach(string newVisit in cityEdge[nowVisit])
                {
                    visiting.Enqueue(newVisit);
                    if (S(nowVisit, newVisit,Time) > 1)
                    {
                        infected.Append(newVisit);
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
            float nilai=0;
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

        public float getTr(string from, string to)
        {
            return val[new KeyValuePair<string,string>(from,to)];
        }



    }
}
