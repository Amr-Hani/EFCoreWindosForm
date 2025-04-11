using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class CourseSession
    {
        [Key]   
        public Guid CrsSession_Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [MaxLength(50)]
        public string? Title { get; set; }

        //------------------------------------------ 1:M With Instructor --------------------------------\\
        [ForeignKey(nameof(Instructor))]
        public Guid? Ins_Id { get; set; }
        public virtual Instructor? Instructor { get; set; }


        //------------------------------------------ 1:M With Instructor --------------------------------\\
        [ForeignKey(nameof(Course))]
        public Guid Crs_Id { get; set; }
        public virtual Course? Course { get; set; }

        //----------------------------------------------M:M with CourseSessionAttendance -----------------------------------------------\\
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; }
            = new HashSet<CourseSessionAttendance>();
    }
}
