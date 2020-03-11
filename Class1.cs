using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl;
using Microsoft.Msagl.GraphViewerGdi;

namespace Tubes2
{
	public class CityConnection
	{
        private readonly Dictionary<KeyValuePair<City, City>, double> tr;
        public readonly Dictionary<City, List<City>> graph;
        public Graph Graph;
        public Dictionary<string, City> StrToCity;


        public CityConnection()
		{

		}

        public double Tr(City A, City B)
        {
            return tr[new KeyValuePair<City, City>(A, B)];
        }

        public bool S(City A, City B)
        {
            double hasil;
            hasil = (double)(A.I(A.dayStart) * Tr(A, B));
            if (hasil > 1)
            {
                B.tular = true;
            }
            return hasil > 1;
        }

        public void T(City A)
        {
            int time;
            time = (int)(20 / (A.population * Tr(this, A)));
            A.dayStart = time;
        }

        public void AddEdge(City A, City B, double P)
        {
            if (!graph.ContainsKey(A))
            {
                graph.Add(A, new List<City>());
            }
            if (!graph.ContainsKey(B))
            {
                graph.Add(B, new List<City>());
            }
            Graph.AddEdge(A.GetName(), B.GetName());
            graph[A].Add(B);
            tr.Add(new KeyValuePair<City, City>(A, B), P);
        }


        public void GenerateGraph()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Rakha Fadhilah\Desktop\Belajar\semester_4\stima\COVID19-STIMA\City.txt");
            string city = System.IO.File.ReadAllText(@"C:\Users\Rakha Fadhilah\Desktop\Belajar\semester_4\stima\COVID19 - STIMA\Population");

            string[] words = text.Split(' ');
            string[] city1 = city.Split(' ');
            bool IsFirst = true;


            foreach (string word in city1)
            {

            }

            foreach (string word in text)
            {
                if (IsFirst)
                {
                    IsFirst = false;
                }
                else
                {


                }

            }
        }
    }
}