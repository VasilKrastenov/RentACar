using System;

namespace Data.Entities
{
    public class Request : BaseEntity
    {
        public int CarID { get; set; }//might need this for later
        
        public Car Car { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime EndDate { get; set; }

        public int RequestorID { get; set; }

        public User Requestor { get; set; }
    }
}
