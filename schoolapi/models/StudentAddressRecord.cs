using System;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class StudentAddressRecord : BaseRecord
    {
        public int StudentId { get; set; }
        public int AddressId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string AddressDetail { get; set; }
    }
}