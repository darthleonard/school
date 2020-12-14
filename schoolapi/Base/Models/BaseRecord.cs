using System;
using System.ComponentModel.DataAnnotations;

namespace schoolapi.Base.Models
{
    public class BaseRecord
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime LastModDate { get; set; } = DateTime.Now;
    }
}