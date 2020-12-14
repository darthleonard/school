using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class FamilyRecord : BaseRecord
    {
        public int HeadOfFamilyParentId { get; set; }
        public string FamilyName { get; set; }
    }
}