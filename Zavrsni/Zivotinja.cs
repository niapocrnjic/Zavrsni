using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public class Zivotinja
    {
        public string Ime { get; set; }
        public string Vrsta { get; set; }
        public string Pasmina { get; set; }
        public string Dob { get; set; }
        public Zivotinja(string ime, string vrsta, string pasmina, string dob)
        {
            Ime = ime;
            Vrsta = vrsta;
            Pasmina = pasmina;
            Dob = dob;
        }

    }
}
