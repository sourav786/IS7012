using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Crud.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string Destination_Name { get; set; }
        public DateTime Arrival_Date { get; set; }
        public DateTime Departure_Date { get; set; }
        public bool Has_breakfast { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bill { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

    }
}
