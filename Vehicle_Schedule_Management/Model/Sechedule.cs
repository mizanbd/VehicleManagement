using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle_Schedule_Management.Model
{
    public class Sechedule
    {
        public int Id { get; set; }
        public string vehicleId { get; set; }
        public string date { get; set; }
        public string shift { get; set; }
        public string bookedBy { get; set; }

        public string address { get; set; }
    }
}