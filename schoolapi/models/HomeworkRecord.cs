using System;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class HomeworkRecord : BaseRecord
    {
        public int StudentId { get; set; }
        public DateTime xDate { get; set; }
        public int Content { get; set; }
        public int Grade { get; set; }
        public string SomeDetails { get; set; }
    }
}