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

namespace WinFormsApp1.CRUD.CourseSessionAttendanceForms
{
    public partial class ShowAllCourseSesionAttendance : Form
    {
        MyContext db;
        public ShowAllCourseSesionAttendance()
        {
            InitializeComponent();
            db = new MyContext();
            var csa = db.CourseSessionAttendances.Include(cs=>cs.CourseSession).Include(s=>s.Student).Select(csa=>new {csa.Student.Fname,csa.CourseSession.Title,csa.Grade,csa.Notes}).ToArray();
            dataGridView1.DataSource = csa;
        }
    }
}
