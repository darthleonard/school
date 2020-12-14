using System;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class StudentClassRecord : BaseRecord
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDte { get; set; }
    }
}