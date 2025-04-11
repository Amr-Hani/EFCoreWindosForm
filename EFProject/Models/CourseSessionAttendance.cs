using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Models
{
    [PrimaryKey("St_ID", "CrsSession_ID")]
    public class CourseSessionAttendance
    {
        public int? Grade { get; set; }
        [MaxLength(100)]
        public string? Notes { get; set; }

        //--------------------------------------1:M with Student-------------------------------------------------------//
        [ForeignKey("Student")]
        public Guid St_ID { get; set; }
        public virtual Student? Student { get; set; }

        //--------------------------------------1:M with CrsSession-------------------------------------------------------//
        [ForeignKey("CourseSession")]
        public Guid CrsSession_ID { get; set; }
        public virtual CourseSession? CourseSession { get; set; }


    }
}
