using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Context;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.CRUD.CourseStudentForms
{
    public partial class ShowAllCourseStudent : Form
    {
        MyContext db;
        public ShowAllCourseStudent()
        {
            InitializeComponent();
            db = new MyContext();
            var crsStudent = db.CousreStudents
                .Include(c=>c.Course)
                .Include(s=>s.Student)
                .Select(cs=>new {StudentName = $"{cs.Student.Fname} {cs.Student.Lname}" ,cs.Course.Course_Name })
                .ToList();
            dataGridView1.DataSource = crsStudent;
        }
    }
}
