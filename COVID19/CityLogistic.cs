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
        Dictionary<KeyValuePair<string, string>, float> val;

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

        public float getTr(string from, string to)
        {
            return val[new KeyValuePair<string,string>(from,to)];
        }


        public float S(string from, string to, int dayLeft)
        {
            //𝑆(𝐴,𝐵) = 𝐼(𝑃(𝐴),𝑡(𝐴)) × 𝑇𝑟(𝐴,𝐵)
            return I(from, dayLeft) * getTr(from,to);  
        }


    }
}
