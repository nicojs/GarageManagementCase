using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementCase
{
    public class KlantRepository
    {
        private List<Klant> _klanten = new List<Klant>();


        public void AddKlant(Klant klant)
        {
            _klanten.Add(klant);
        }

        public List<Klant> SearchKlant(string naam)
        {
            var searchResult = new List<Klant>();
            foreach (var klant in _klanten)
            {
                if ($"{klant.Voornaam} {klant.Achternaam}".Contains(naam))
                {
                    searchResult.Add(klant);
                }
            }
            return searchResult;
        }

        public Klant[] AllKlanten
        {
            get
            {
                var klanten = new Klant[_klanten.Count];
                _klanten.CopyTo(klanten);
                return klanten;
            }
        }
    }
}
