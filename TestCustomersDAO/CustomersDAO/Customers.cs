using System.Collections.Generic;

namespace customersDAO
{
    public class customers
    {
        public int customersId { get; set; }
        public string Name { get; set; }

        public customers() { }

        public customers(int id, string name)
        {
            customersId = id;
            Name = name;
        }

        public List<contacts> contactss { get; } = new List<contacts>();
    }
}