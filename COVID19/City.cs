using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID19
{
    class City
    {
        public Dictionary<string, int> cityCollection;
        public string start;

        //constructor
        public City()
        {
            cityCollection = new Dictionary<string, int>();
        }

        public void importCity(string dir)
        {
            StreamReader sr = new StreamReader(dir);
            string[] readed = sr.ReadLine().Split(' ');
            int n = int.Parse(readed[0]);
            start = readed[1];
            for(int i = 0;i < n; i++)
            {
                string[] temp = sr.ReadLine().Split(' ');
                cityCollection.Add(temp[0], int.Parse(temp[1]));
            }
        }
    }
}
