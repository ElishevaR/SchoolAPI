using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Model
{
    [Table("Grade")]
    public class Grade
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public char Level { get; set; }
        public int? TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher TeacherForSubject { get; set; }
    }
}
