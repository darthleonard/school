using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class FamilyMemberRecord : BaseRecord
    {
        public int FamilyId { get; set; }
        public int ParentId { get; set; }
        public int StudentId { get; set; }
        public int ParentOrStudentMember { get; set; }
    }
}