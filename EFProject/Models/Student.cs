using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Student
    {
        [Key]
        public Guid St_Id { get; set; }
        [MaxLength(30)]
        public string? Fname { get; set; }
        [MaxLength(30)]
        public string? Lname { get; set; }
        [MaxLength(15)]
        public string? Phone { get; set; }

        //----------------------------------------------M:M with CourseStudent -----------------------------------------------\\
        public virtual ICollection<CousreStudent> CousreStudents  { get; set; } = new HashSet<CousreStudent>();

        //----------------------------------------------M:M with CourseSessionAttendance -----------------------------------------------\\
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; }
            = new HashSet<CourseSessionAttendance>();
    }
}
