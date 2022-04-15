namespace PlaneManager.Models
{
    internal class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Plane(string[] data)
        {
            if (data != null)
            {
                if (int.TryParse(data[0], out int id))
                {
                    Id = id;

                }
                Name = data[1];
            }
        }
    }
}
