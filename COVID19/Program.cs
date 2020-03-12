using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID19
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hello World!");
            City.importCity("./Population.txt");
            CityLogistic.ImportLogistic("./City.txt");

            CityLogistic.BFS(12);

            foreach (string a in CityLogistic.infected)
            {
                Console.WriteLine(a);
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
