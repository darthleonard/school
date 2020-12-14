using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class SchoolRecord : BaseRecord
    {
        public int AddressId { get; set; }
        public string Name { get; set; }
    }
}