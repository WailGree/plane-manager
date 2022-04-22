using System;

namespace PlaneManager.Modellek
{
    internal class Utas : AdatModel
    {
        public string Nev { get; set; }
        public string SzuletesiDatum { get; set; }
        public string Telefonszam { get; set; }
        public string Email { get; set; }

        public Utas(string[] adat)
        {
            if (adat != null && adat.Length == 5)
            {
                if (Guid.TryParse(adat[0], out Guid guid))
                {
                    Id = guid;
                }
                Nev = adat[1];
                SzuletesiDatum = adat[2];
                Telefonszam = adat[3];
                Email = adat[4];
            }
        }

        public Utas(string nev, string szuletesiDatum, string telefonszam, string email)
        {
            Id = Guid.NewGuid();
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            Telefonszam = telefonszam;
            Email = email;
        }
    }
}
