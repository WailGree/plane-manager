using System;

namespace PlaneManager.Models
{
    internal class Ticket : DataModel
    {
        public bool IsPurchased { get; set; } = false;

        public Ticket(string[] data)
        {
            if (data != null)
            {
                Id = Guid.Parse(data[0]);
            }
        }
    }
}
