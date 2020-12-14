using schoolapi.Base;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class StudentRecord : BaseRecord
    {
        public ArchaosSexType Gender { get; set; }
        public string Name { get; set; }
    }
}