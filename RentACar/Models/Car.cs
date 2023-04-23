using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Car : BaseEntity
    {
        [Required(ErrorMessage ="Manufacturer required")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Model required")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Model year required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Passenger seats number required")]
        public int PassengerSeats { get; set; }

        [DefaultValue(null)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Rental price per day required")]
        public double RentalPrice { get; set; }
    }
}
