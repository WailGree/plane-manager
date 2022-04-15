using System;

namespace PlaneManager.Models
{
    internal class Plane : DataModel
    {
        public string Name { get; set; }

        public Plane(string[] data)
        {
            if (data != null)
            {
                if (Guid.TryParse(data[0], out Guid id))
                {
                    Id = id;
                }
                Name = data[1];
            }
        }
    }
}
