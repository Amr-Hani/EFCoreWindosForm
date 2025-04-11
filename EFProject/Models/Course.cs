using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Course
    {
        [Key]
        public Guid Crs_Id { get; set; }
        public int? Duration { get; set; }
        public string? Course_Name { get; set; }

        //----------------------------1:M with Instructor---------------------------------------------//

        [ForeignKey("Instructors")]
        public Guid? Ins_Id { get; set; }
        public virtual Instructor Instructors { get; set; } = null!;

        //------------------------------------1:M CourseSession------------------------------------------//
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

        //----------------------------1:M with Department---------------------------------------------//

        [ForeignKey("Department")]
        public Guid? Dept_Id { get; set; }
        public virtual Department Department { get; set; } = null!;


        //----------------------------------------------M:M with CourseStudent -----------------------------------------------//
        public virtual ICollection<CousreStudent> CousreStudents { get; set; } = new HashSet<CousreStudent>();

    }
}
