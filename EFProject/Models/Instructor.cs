using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Instructor
    {
        [Key]
        public Guid Ins_Id { get; set; }
        [MaxLength(20)]
        public string? FName { get; set; }
        [MaxLength(20)]
        public string? LName { get; set; }
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        //------------------------------------1:M Course------------------------------------------//
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        //------------------------------------1:M CourseSession------------------------------------------//
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

        //------------------------------------1:M Department------------------------------------------//
        [ForeignKey(nameof(Department))]
        public Guid? Dept_id { get; set; }
        public virtual Department? Department { get; set; }

        //------------------------------------1:1 Department------------------------------------------//
        public virtual Department? MangedDepartment { get; set; }

    }
}
