using System;

namespace PlaneManager.Modellek
{
    internal class Jarat : AdatModel
    {
        public string Nev { get; set; }
        public int Meret { get; set; }
        public Ules[] Ulesek { get; set; }
        public DateTime IndulasIdeje { get; set; }
        public DateTime ErkezesIdeje { get; set; }
        public string Indulohely { get; set; }
        public string Cel { get; set; }


        public Jarat(string[] adat)
        {
            if (adat != null && adat.Length >= 7 && Guid.TryParse(adat[0], out Guid id) && int.TryParse(adat[2], out int size) && DateTime.TryParse(adat[3 + size * 3], out DateTime indulasIdeje) && DateTime.TryParse(adat[3 + size * 3 + 1], out DateTime erkezesIdeje))
            {
                Id = id;
                Nev = adat[1];
                Meret = size;

                if (Meret > 0)
                {
                    Ulesek = new Ules[Meret];
                    int ulesIndex = 0;
                    for (int x = 3; x <= (1 + Meret * 3); x += 3)
                    {
                        Ulesek[ulesIndex] = new Ules(new string[] { adat[x], adat[x + 1], adat[x + 2] });
                        ulesIndex++;
                    }
                }
                else
                {
                    Ulesek = new Ules[0];
                }

                IndulasIdeje = indulasIdeje;
                ErkezesIdeje = erkezesIdeje;
                Indulohely = adat[3 + Meret * 3 + 2];
                Cel = adat[3 + Meret * 3 + 3];
            }
        }

        public Jarat(string nev, int meret, DateTime indulasIdeje, DateTime arrivalDate, string indulohely, string cel)
        {
            Id = Guid.NewGuid();
            Nev = nev;
            Meret = meret;
            Ulesek = new Ules[Meret];
            for (int i = 0; i < Meret; i++)
            {
                Ulesek[i] = new Ules(i + 1);
            }
            IndulasIdeje = indulasIdeje;
            ErkezesIdeje = arrivalDate;
            Indulohely = indulohely;
            Cel = cel;
        }
    }
}
