using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Crud.Models
{
    public class Destination
    {
        public int ID { get; set; }

        [Display(Name = "Destination Name")]

        [Required(ErrorMessage = "Destination Name is required")]
        public string Destination_Name { get; set; }

        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Arrival_Date { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [CustomValidation(typeof(Destination), "DepartureDateValidation")]


        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }

        [CustomValidation(typeof(Destination), "BreakfastBillValidation")]

        [Display(Name = "Has Breakfast")]
        public bool Has_breakfast { get; set; }

        [Range(1, 195, ErrorMessage = "Bill must be between $1 and $999")]
        [Column(TypeName = "decimal(18, 2)")]

        [Display(Name = "Total Bill")]
        public decimal Bill { get; set; }

      
        public int CountryId { get; set; }

        public Country Country { get; set; }

        [Phone(ErrorMessage = "Please provide a valid US phone number")]
        [StringLength(11, MinimumLength =9)]
        [Display(Name = "Contact No")]
        public string ResortPhone { get; set; }

        [EmailAddress(ErrorMessage = "Please provide a valid email address")]
        [Required(ErrorMessage = "Email is required")]

        [Display(Name = "Destination Email")]
        public string EmailAddress { get; set; }

        public static ValidationResult DepartureDateValidation(DateTime? Departure_Date, ValidationContext context)
        {
            var destination = context.ObjectInstance as Destination;
            if (Departure_Date.Value.Date > destination.Arrival_Date)
            {
                return ValidationResult.Success;
            }
            string errorMessage = $"Departure date must be a date on or before Arrival Date";
            return new ValidationResult(errorMessage);
        }

        public static ValidationResult BreakfastBillValidation(bool? Has_breakfast, ValidationContext context)
        {
            // GET THE ENTIRE MODEL FROM THE VALIDATION CONTEXT
            var instance = context.ObjectInstance as Destination;
            if(Has_breakfast == true && !String.IsNullOrEmpty(instance.Bill.ToString()))
            {
                return ValidationResult.Success;
            }
            string errorMessage = $"Add Bill only when breakfast is taken";
            return new ValidationResult(errorMessage);
        }


    }
}
