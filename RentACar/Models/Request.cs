using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Request : BaseEntity
    {
        //public int CarID { get; set; } //might need this for later

        [Required(ErrorMessage = "Car required")]
        public Car Car { get; set; }

        [Required(ErrorMessage = "Starting date required")]
        public DateTime StartingDate { get; set; }

        [Required(ErrorMessage = "End date required")]
        public DateTime EndDate { get; set; }

        public int RequestorID { get; set; }

        [Required(ErrorMessage = "User required")]
        public User Requestor { get; set; }
    }
}
