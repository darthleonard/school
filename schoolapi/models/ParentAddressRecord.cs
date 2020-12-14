using System;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class ParentAddressRecord : BaseRecord
    {
        public int ParentId { get; set; }
        public int AddressId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}