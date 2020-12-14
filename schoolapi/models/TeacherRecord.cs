using schoolapi.Base;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class TeacherRecord : BaseRecord
    {
        public int SchoolId { get; set; }
        public ArchaosSexType Gender { get; set; }
        public string Name { get; set; }
    }
}