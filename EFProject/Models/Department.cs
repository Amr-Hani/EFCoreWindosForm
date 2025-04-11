using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Department
    {
        [Key]
        public Guid Dept_Id { get; set; }

        [MaxLength(50)]
        public string? Dept_Name { get; set; }
        [MaxLength(100)]
        public string? Dept_Location { get; set; }

        //---------------------------------1-M Cours --------------------------\\
        public virtual ICollection<Course> Courses {  get; set; } = new HashSet<Course>();

        //---------------------------------1-M Instructor --------------------------\\
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        //---------------------------------1-1 Instructor --------------------------\\
        public Guid? Manger_id { get; set; }
        public virtual Instructor? InsManger { get; set; }
    }
}
