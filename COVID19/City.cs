﻿using System;
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

        public static double I(string cityName,int tCity)
        {
            int p = P(cityName);
            return  p / (1 + (p - 1)*Math.Pow(2.71828,-0.25*tCity));
        }

    }
}
