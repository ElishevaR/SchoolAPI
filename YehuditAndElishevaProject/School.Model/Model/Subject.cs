using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Model
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Name { get; set; }
        

    }
}
