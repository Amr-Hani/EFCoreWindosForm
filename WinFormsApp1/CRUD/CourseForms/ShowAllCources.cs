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

namespace WinFormsApp1.CRUD.CourseForms
{
    public partial class ShowAllCources : Form
    {
        MyContext db;
        public ShowAllCources()
        {
            InitializeComponent();
            db = new MyContext();
            var courses = db.Courses
                .Include(i => i.Instructors)
                .Include(d => d.Department)
                .Select(c=> new { c.Course_Name,c.Duration,c.Department.Dept_Name , c.Instructors.FName})
                .ToArray();
            dataGridView1.DataSource = courses;
        }
    }
}
