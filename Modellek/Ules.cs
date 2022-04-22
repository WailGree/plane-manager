using System;

namespace PlaneManager.Modellek
{
    class Ules : AdatModel
    {
        public int SzekSzama { get; set; }
        public bool Lefoglalt { get; set; } = false;
        public Utas Utas { get; set; }

        public Ules(int szekSzam)
        {
            Id = Guid.NewGuid();
            SzekSzama = szekSzam;
        }

        public Ules(string[] adat)
        {
            if (adat != null && adat.Length == 3 && Guid.TryParse(adat[0], out Guid id) && int.TryParse(adat[1], out int szekSzama) && bool.TryParse(adat[2], out bool lefoglalt))
            {
                Id = id;
                SzekSzama = szekSzama;
                Lefoglalt = lefoglalt;
            }
        }

        public Ules(Guid id, int szekSzama, bool lefoglalt)
        {
            Id = id;
            SzekSzama = szekSzama;
            Lefoglalt = lefoglalt;
        }
    }
}