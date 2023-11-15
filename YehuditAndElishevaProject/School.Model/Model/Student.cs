using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(9)]
        public string? TZ { get; set; }
        [MaxLength(10)]
        public string? FirstName { get; set; }
        [MaxLength(20)]
        public string? LastName { get; set; }
        [NotMapped]
        public DateOnly Birthday { get; set; }
        public int? GradeId { get; set; }

        [ForeignKey(nameof(GradeId))]
        public Grade GradeForStutdet { get; set; }
    }
}
