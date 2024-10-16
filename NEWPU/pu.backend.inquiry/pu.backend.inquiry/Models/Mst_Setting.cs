using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace pu.backend.inquiry.Models
{
    public class Mst_Setting
    {
        public Int64 Id { get; set; }
        [Key]
        public string Category { get; set; }
        [Key]
        public string SubCategory { get; set; }
        [Key]
        public string Code { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string UpdatedBy { get; set; }
        public int IntValue { get; set; }
        public DateTime DateValue { get; set; }
        public TimeOnly TimeValue { get; set; }
    }
}
