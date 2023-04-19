using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    class Car : BaseEntity
    {
        public Car()
        {

        }

        public Manufacturer Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int PassengerSeats { get; set; }

        public string Description { get; set; }

        public double RentalPrice { get; set; }
    }
}
