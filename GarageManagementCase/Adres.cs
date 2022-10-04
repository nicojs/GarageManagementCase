using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementCase
{
    public class Adres
    {
        public Adres(string straat, int huisnummer, string plaats, string postcode)
        {
            Straat = straat;
            Huisnummer = huisnummer;
            Plaats = plaats;
            Postcode = postcode;
        }

        public string Straat { get; }

        public int Huisnummer { get; }

        public string Plaats { get; }
        public string Postcode { get; }


    }
}
