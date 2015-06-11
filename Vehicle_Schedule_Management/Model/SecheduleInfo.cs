using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle_Schedule_Management.Model
{
    public class SecheduleInfo : IEnumerable<SecheduleInfo>
    {
        public string vehicleId { get; set; }
        public string date { get; set; }
        public string bookedShift { get; set; }
        public IEnumerator<SecheduleInfo> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}