using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementCase
{
    public class Klant
    {
        public string Voornaam { get; }
        public string Achternaam { get; }

        public Adres Adres { get; }

        public string Telefoonnummer { get; }

        public string Email { get; }

        public Klant(string voornaam, string achternaam, Adres adres, string telefoonnummer, string email)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Adres = adres;
            Telefoonnummer = telefoonnummer;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Voornaam} {Achternaam} ({Adres.Straat}, {Adres.Plaats})";
        }
    }
}
