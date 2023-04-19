﻿namespace Data.Entities
{
    public class Car : BaseEntity
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int PassengerSeats { get; set; }

        public string Description { get; set; }

        public double RentalPrice { get; set; }
    }
}
