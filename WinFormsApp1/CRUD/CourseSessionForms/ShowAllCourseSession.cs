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

namespace WinFormsApp1.CRUD.CourseSessionForms
{
    public partial class ShowAllCourseSession : Form
    {
        MyContext db;
        public ShowAllCourseSession()
        {
            InitializeComponent();
            db = new MyContext();
            var courses = db.CourseSessions
                .Include(i=>i.Instructor)
                .Include(i=>i.Course)
                .Select(c => new {c.Date,c.Title,c.Course.Course_Name,c.Instructor.FName})
                .ToList();
            dataGridView1.DataSource = courses;
        }
    }
}
