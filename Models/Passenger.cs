namespace PlaneManager.Models
{
    internal class Passenger
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public Passenger(string[] data)
        {
            if (data != null && data.Length == 4)
            {
                Name = data[0];
                BirthDate = data[1];
                PhoneNumber = data[2];
                Email = data[3];
            }
        }

        public Passenger(string name, string birthdate, string phonenumber, string email)
        {
            Name = name;
            BirthDate = birthdate;
            PhoneNumber = phonenumber;
            Email = email;
        }
    }
}
