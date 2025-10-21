using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public static class Admin
    {
        public static void UnosUdatoteku(string zapis)
        {
            StreamWriter sw = new StreamWriter("zivotinje.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }

        public static List<string> Svi()
        {
            List<string> lstStr = new List<string>();

            StreamReader sr = new StreamReader("zivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                linija = linija.Replace("|", " ");
                lstStr.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();

            return lstStr;
        }

        public static List<string> Vrsta(string vrsta)
        {
            List<string> lstVrsta = new List<string>();
            StreamReader sr = new StreamReader("zivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] razlomljena = linija.Split('|');
                if (razlomljena[1]==vrsta)
                {

                    lstVrsta.Add(linija);
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            return lstVrsta;
        }
        public static List<Zivotinja> listaSvihZivotinja()
        {
            List<Zivotinja> lstZiv = new List<Zivotinja>();
            StreamReader sr = new StreamReader("zivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] razlomljena = linija.Split('|');
                Zivotinja z = new Zivotinja(razlomljena[0], razlomljena[1], razlomljena[2], razlomljena[3]);
                lstZiv.Add(z);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lstZiv;

        }
        public static List<string> Udomitelji()
        {
            List<string> lstU=new List<string>();
            StreamReader sr = new StreamReader("udomitelji.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                linija=linija.Replace("|", " ");
                lstU.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lstU;
        }
        public static void SpremiUdomitelje(string linija)
        {
            StreamWriter sw = new StreamWriter("udomitelji.txt", true);
            sw.WriteLine(linija);
            sw.Close();
        }
       public static int PoVrsti(string vrsta)
        {
            int broj = 0;
            StreamReader sr = new StreamReader("zivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] razlomljena = linija.Split('|');
                if (razlomljena[1] == vrsta)
                {
                    broj++;
                }
                linija = sr.ReadLine();
            }
 
            return broj;
        }
        public static double ProsjecnaDob()
        {
            double suma = 0;
            int br = 0;
            double prosjek = 0;
            StreamReader sr = new StreamReader("zivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] razlomljena = linija.Split('|');
                string dob=razlomljena[4];
                int Dob = int.Parse(dob);
                suma = suma + Dob;
                br++;
                linija = sr.ReadLine();
            }
            sr.Close();
             prosjek = suma / br;
            return prosjek;
        }
        public static int BrojVrste(string vrsta)
        {
            int broj = 0;
            StreamReader sr = new StreamReader("zivotinje.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] razlomljena = linija.Split('|');
                if (razlomljena[1] == vrsta)
                {
                    broj++;
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            return broj;
        }
    }
}
