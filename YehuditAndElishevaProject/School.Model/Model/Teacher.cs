using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Model
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(9)]
        public string? TZ { get; set; }
        [MaxLength(20)]
        public string? FirstName { get; set; }
        [MaxLength(20)]
        public string? LastName { get; set; }
        public int Experience { get; set; }
        public int? SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject SubjectForGrade { get; set; }
    }
}
