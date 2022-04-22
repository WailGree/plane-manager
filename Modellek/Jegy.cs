using System;

namespace PlaneManager.Modellek
{
    internal class Jegy : AdatModel
    {
        public Guid RendelesID { get; set; }
        public int SzekSzama { get; set; }


        public Jegy(Guid orderId, int seatNumber)
        {
            Id = Guid.NewGuid();
            RendelesID = orderId;
            SzekSzama = seatNumber;
        }

        public Jegy(string[] data)
        {
            if (data != null && data.Length == 2)
            {
                Id = Guid.Parse(data[0]);
                RendelesID = Guid.Parse(data[1]);
                SzekSzama = Convert.ToInt32(data[2]);
            }
        }
    }
}
