using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Request : BaseEntity
    {
        public Car Car { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime EndDate { get; set; }

        public int RequestorID { get; set; }

        public User Requestor { get; set; }
    }
}
