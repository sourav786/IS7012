using System.Collections.Generic;

namespace Core_Crud.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Destination> Destinations { get; set; }
    }
}