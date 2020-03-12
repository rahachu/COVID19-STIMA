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
        public static Dictionary<string, int> cityCollection = new Dictionary<string, int>();
        public static Dictionary<string, int> cityDayStart = new Dictionary<string, int>();
        public static string start;



        public static void importCity(string dir)
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

        public static int P(string cityName)
        {
            return cityCollection[cityName];
        }

        public void DayStart(string name,int dayStart)
        {
            cityDayStart.Add("A", 0);
            if (!name.Equals("A"))
            {
                cityDayStart.Add(name, dayStart);
            }
        }

        public static int getDayStart(string name)
        {
            return cityDayStart[name];
        }


        public static double I(string Name,int totalDay)
        {
            return P(Name) / (1 + (P(Name) - 1) * Math.Exp(-0.25 *(totalDay- getDayStart(Name))));
        }



    }
}
