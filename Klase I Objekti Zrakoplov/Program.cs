using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_Objekti_Zrakoplov
{
    class Program
    {
        static void Main(string[] args)
        {


            Zrakoplov zrakoplov = new Zrakoplov();
            zrakoplov.SetNaziv("Airbus");
            zrakoplov.SetDosegLeta(6000);
            zrakoplov.SetSnagaMotoraU_kW(2000);

            Console.WriteLine("Zrakoplov x380:");
            Console.WriteLine(zrakoplov.Ispis());

            Zrakoplov zrakoplov2 = new Zrakoplov("Cessna Skycatcher", 870, 75);

            Console.WriteLine("Zrakoplov C162:");
            Console.WriteLine(zrakoplov2.Ispis());

            Zrakoplov zrakoplov3 = new Zrakoplov("Pilatus", 1333, 1200);

            Console.WriteLine("Zrakoplov C162:");
            Console.WriteLine(zrakoplov2.Ispis());

            Console.ReadKey();
        }


    }

    class Zrakoplov
    {

        string naziv;
        int dosegLeta;
        double snagaMotoraU_kW;

    
        public void SetNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void SetDosegLetaUKma(int dosegLetaUKm)
        {
            this.dosegLeta = dosegLetaUKm;
        }
        public void SetSnagaMotoraU_kW(double snagaMotoraU_kW)
        {
            this.snagaMotoraU_kW = snagaMotoraU_kW;
        }


        public string GetNaziv()
        {
            return this.naziv;
        }
        public int GetDosegLeta()
        {
            return this.dosegLeta;
        }
        public double GetSnagaMotoraU_kW()
        {
            return this.snagaMotoraU_kW;
        }


        public string Ispis()
        {
            string ispis = ("Naziv: " + this.GetNaziv()
                    + "\r\nDosegLeta:" + this.GetDosegLeta() + "Km"
                    + "\r\nSnagaMotora:" + this.GetSnagaMotoraU_kW() + "kW"
                    );
            return ispis;
        }


        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, int dosegLeta, double snagaMotoraU_kW)
        {
            this.naziv = naziv;
            this.dosegLeta = dosegLeta;
            this.snagaMotoraU_kW = snagaMotoraU_kW;

        }


    }
}