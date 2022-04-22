using System;

namespace PlaneManager.Modellek
{
    internal class Rendeles : AdatModel
    {
        public Jarat Jarat { get; set; }
        public Utas Utas { get; set; }
        public Ules ules { get; set; }
        public Jegy Jegy { get; set; }

        public Rendeles(Jarat jarat, Utas utas, Ules ules)
        {
            Id = Guid.NewGuid();
            Jarat = jarat;
            Utas = utas;
            this.ules = ules;
        }

        public Rendeles(string[] adat)
        {

        }

        public void JegyLetrehozasa()
        {
            var ticket = new Jegy(Id, ules.SzekSzama);
            Jegy = ticket;
            Program.Jegyek.Add(ticket);
        }


    }
}
