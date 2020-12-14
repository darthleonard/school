using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class StudentParentRecord : BaseRecord
    {
        public int StudentId { get; set; }
        public int ParentId { get; set; }
    }
}