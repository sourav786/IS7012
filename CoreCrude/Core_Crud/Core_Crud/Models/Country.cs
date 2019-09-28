using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_Crud.Models
{
    public class Country
    {
        public int ID { get; set; }

        [StringLength(27)]
        public string Name { get; set; }

        public ICollection<Destination> Destinations { get; set; }
    }
}