using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Models
{
    [PrimaryKey("St_ID", "CourseID")]
    public class CousreStudent
    {
        //--------------------------------------1:M with Course-------------------------------------------------------//
        [ForeignKey("Course")]
        public Guid CourseID { get; set; }
        public virtual Course? Course { get; set; }

        //--------------------------------------1:M with Student-------------------------------------------------------//
        [ForeignKey("Student")]
        public Guid St_ID { get; set; }
        public virtual Student? Student { get; set; }

    }
}
