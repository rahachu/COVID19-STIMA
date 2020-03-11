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
        public static Dictionary<KeyValuePair<String, String>, float> val = new Dictionary<KeyValuePair<string, string>, float>();
        public static Dictionary<string, int> timeFirst = new Dictionary<string, int>();



        public static void importLogistic(string dir)
        {
            StreamReader sr = new StreamReader(dir);
            string ns = sr.ReadLine();
            int n = Convert.ToInt32(ns);

            for(int i = 0; i < n; i++)
            {
                string[] a = sr.ReadLine().Split(' ');
                KeyValuePair<string, string> cityPair = new KeyValuePair<string, string>(a[0],a[1]);
                val.Add(cityPair, float.Parse(a[2]));
            }
        }

        public static void generatet()
        {
            timeFirst.Add(City.start, 0);
            while (timeFirst.Count < City.cityCollection.Count)
            {
                foreach (KeyValuePair<KeyValuePair<string, string>, float> pair in val)
                {
                    if (timeFirst.ContainsKey(pair.Key.Key))
                    {
                        int i = 0;
                        while (S(pair.Key.Key, pair.Key.Value) <= 1)
                        {
                            i++;
                        }
                        if (timeFirst.ContainsKey(pair.Key.Value) && timeFirst[pair.Key.Value]>i)
                        {
                            timeFirst[pair.Key.Value] = i;
                        }
                        else
                        {
                            timeFirst.Add(pair.Key.Value, i);
                        }
                    }
                }
            }
        }

        public static int t(string a)
        {
            return timeFirst[a];
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

        public static double S(string a, string b)
        {
            return City.I(a, t(a)) * Tr(a, b);
        }
    }
}
