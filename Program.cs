using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tubes2
{

    class City
    {

        public string name;
        public int population;
        public int dayStart;
        public bool tular = false;
        private readonly Dictionary<KeyValuePair<City, City>, double> tr;

        City(string name, int population, int chance, bool tular)
        {
            this.name = name;
            this.population = population;
        }


        public string GetName()
        {
            return this.name;
        }

        public int GetPop()
        {
            return this.population;
        }


        public double I(int totalWaktu)
        {
            double infected;
            double e = 2.71828;

            infected = this.population / (1 + Math.Pow(((this.population - 1) * e), 0.25 * totalWaktu));
            return infected;
            //            double ketularan;
            //           ketularan = A.population / (1 + Math.Pow(((A.population - 1) * e), 0.25 * totalWaktu));
            //            return ketularan;

        }

        public static int t(int T, int startDay)
        {
            return T - startDay;
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
    }






}
