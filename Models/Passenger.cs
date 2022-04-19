using System;

namespace PlaneManager.Models
{
    internal class Passenger : DataModel
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Passenger(string[] data)
        {
            if (data != null && data.Length == 5)
            {
                if (Guid.TryParse(data[0], out Guid guid))
                {
                    Id = guid;
                }
                Name = data[1];
                BirthDate = data[2];
                PhoneNumber = data[3];
                Email = data[4];
            }
        }

        public Passenger(string name, string birthdate, string phonenumber, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            BirthDate = birthdate;
            PhoneNumber = phonenumber;
            Email = email;
        }
    }
}
