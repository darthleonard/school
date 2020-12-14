using System;
using schoolapi.Base.Models;

namespace schoolapi.Models
{
    public class ReportRecord : BaseRecord
    {
        public int StudentId { get; set; }
        public DateTime xDate { get; set; }
        public string Content { get; set; }
        public string Comments { get; set; }
    }
}