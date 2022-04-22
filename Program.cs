using System;
using System.IO;
using System.Windows.Forms;
using PlaneManager.Modellek;
using PlaneManager.Oldalak;
using System.ComponentModel;
using System.Text;

namespace PlaneManager
{
    internal static class Program
    {
        private enum Adattipus
        {
            Jarat,
            Utas,
            Rendeles,
            Jegy
        }

        // Save Data globally
        // Using BindingList instead of List will make it possible, to update DataGridView on change of data. With simple List it will NOT fire event/update view.
        public static BindingList<Utas> Utasok { get; set; } = new BindingList<Utas>();
        public static BindingList<Jarat> Jaratok { get; set; } = new BindingList<Jarat>();
        public static BindingList<Jegy> Jegyek { get; set; } = new BindingList<Jegy>();
        public static BindingList<Rendeles> Rendelesek { get; set; } = new BindingList<Rendeles>();

        public static readonly string _utasokFajl = "utasok.csv";
        public static readonly string _jaratokFajl = "jaratok.csv";
        public static readonly string _jegyekFajl = "jegyek.csv";
        public static readonly string _rendelesekFajl = "rendelesek.csv";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static void AdatokBetoltese()
        {
            AdatTipusBetoltese(_utasokFajl, Adattipus.Utas);
            AdatTipusBetoltese(_jaratokFajl, Adattipus.Jarat);
            AdatTipusBetoltese(_jegyekFajl, Adattipus.Jegy);
            AdatTipusBetoltese(_rendelesekFajl, Adattipus.Rendeles);
        }

        private static void AdatTipusBetoltese(string filenev, Adattipus adattipus)
        {
            foreach (var line in File.ReadAllLines(filenev))
            {
                var data = line.Split(';');
                if (adattipus == Adattipus.Utas)
                {
                    Utasok.Add(new Utas(data));
                }
                else if (adattipus == Adattipus.Jarat)
                {
                    Jaratok.Add(new Jarat(data));
                }
                else if (adattipus == Adattipus.Rendeles)
                {
                    Rendelesek.Add(new Rendeles(data));
                }
                else if (adattipus == Adattipus.Jegy)
                {
                    Jegyek.Add(new Jegy(data));
                }
            }
        }

        public static void OsszesAdatMentése()
        {
            UtasokMentese();
            JaratokMentese();
            JegyekMentese();
        }

        public static void UtasLetrehozasa(string name, string birthdate, string phonenumber, string email)
        {
            Utasok.Add(new Utas(name, birthdate, phonenumber, email));
        }

        public static void UtasokMentese()
        {

            if (File.Exists(_utasokFajl)) File.Delete(_utasokFajl);
            using (var sw = new StreamWriter(_utasokFajl))
            {
                foreach (var utas in Utasok)
                {
                    sw.WriteLine($"{utas.Id};{utas.Nev};{utas.SzuletesiDatum};{utas.Telefonszam};{utas.Email}");
                }
            }
        }

        public static void UtasokBetoltese()
        {
            if (File.Exists(_utasokFajl))
            {
                Utasok.Clear();
                AdatTipusBetoltese(_utasokFajl, Adattipus.Utas);
            }
        }

        public static void JaratLetrehozasa(string nev, int meret, DateTime indulasIdeje, DateTime erkezesIdeje, string indulohely, string cel)
        {
            Jaratok.Add(new Jarat(nev, meret, indulasIdeje, erkezesIdeje, indulohely, cel));
        }
        public static void JaratokMentese()
        {
            if (File.Exists(_jaratokFajl)) File.Delete(_jaratokFajl);
            using (var sw = new StreamWriter(_jaratokFajl))
            {
                foreach (var jarat in Jaratok)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"{jarat.Id};{jarat.Nev};{jarat.Meret};");
                    if (jarat.Meret > 0)
                    {
                        foreach (var seat in jarat.Ulesek)
                        {
                            sb.Append($"{seat.Id};{seat.SzekSzama};{seat.Lefoglalt};");
                        }
                    }
                    sb.Append($"{jarat.IndulasIdeje};{jarat.ErkezesIdeje};{jarat.Indulohely};{jarat.Cel}");
                    sw.WriteLine(sb);
                }
            }
        }

        public static void JaratokBetoltese()
        {
            if (File.Exists(_jaratokFajl))
            {
                Jaratok.Clear();
                AdatTipusBetoltese(_jaratokFajl, Adattipus.Jarat);
            }
        }
        public static void RendelesekMentese()
        {
            if (File.Exists(_rendelesekFajl)) File.Delete(_rendelesekFajl);
            using (var sw = new StreamWriter(_rendelesekFajl))
            {
                foreach (var rendeles in Rendelesek)
                {
                    sw.WriteLine($"{rendeles.Id};{rendeles.Jarat};{rendeles.Utas};{rendeles.ules};{rendeles.Jegy}");
                }
            }
        }

        public static void JegyekMentese()
        {
            if (File.Exists(_jegyekFajl)) File.Delete(_jegyekFajl);
            using (var sw = new StreamWriter(_jegyekFajl))
            {
                foreach (var ticket in Jegyek)
                {
                    sw.WriteLine($"{ticket.Id};{ticket.RendelesID};{ticket.SzekSzama}");
                }
            }
        }

        public static void JegyekBetoltese()
        {
            if (File.Exists(_jegyekFajl))
            {
                Jegyek.Clear();
                AdatTipusBetoltese(_jegyekFajl, Adattipus.Jegy);
            }
        }
    }
}
