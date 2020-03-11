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
        Dictionary<KeyValuePair<String, String>, float> val;

        public CityLogistic()
        {
            val = new Dictionary<KeyValuePair<string, string>, float>();
        }

        public void importLogistic(string dir)
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
    }
}
