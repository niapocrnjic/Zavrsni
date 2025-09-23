using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public static class Admin
    {
        public static void UnosUdatoteku(string zapis)
        {
            StreamWriter sw=new StreamWriter("zivotinje.txt",true);
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
                linija = linija.Replace("|"," ");
                lstStr.Add(linija);
                linija=sr.ReadLine();
            }
                sr.Close();
    
            return lstStr;
        }
    }
}
