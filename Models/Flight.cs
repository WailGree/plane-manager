using System;

namespace PlaneManager.Models
{
    internal class Flight : DataModel
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public Flight(string[] data)
        {
            if (data != null)
            {
                if (Guid.TryParse(data[0], out Guid id))
                {
                    Id = id;
                }
                Name = data[0];
                if (int.TryParse(data[1], out int size))
                {
                    Size = size;
                }
                else
                {
                    Size = 0;
                }
            }
        }
    }
}
