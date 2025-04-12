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
using EFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.CRUD.CourseSessionAttendanceForms
{
    public partial class DeleteCourseSessionAttendence : Form
    {
        MyContext db;
        public DeleteCourseSessionAttendence()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid stId = (Guid)comboBox2.SelectedValue;

                List<CourseSession> crsSs = new List<CourseSession>();
                var coursesEmrolledByStudent = db.CousreStudents.Where(cs => cs.St_ID == stId).ToList();

                var resultQuery = (
                    from s in db.Students
                    where s.St_Id == stId
                    join item in db.CousreStudents on s.St_Id equals item.St_ID
                    join c in db.Courses on item.CourseID equals c.Crs_Id
                    join css in db.CourseSessions on c.Crs_Id equals css.Crs_Id
                    join csa in db.CourseSessionAttendances on css.CrsSession_Id equals csa.CrsSession_ID
                    select new
                    {
                        css.Title,
                        css.CrsSession_Id
                    }
                    ).ToList();
                if (resultQuery != null && resultQuery.Count() > 0)
                {

                    comboBox1.DataSource = resultQuery;
                    comboBox1.DisplayMember = "Title";
                    comboBox1.ValueMember = "CrsSession_Id";
                }
                else
                {
                    comboBox1.DataSource = null;
                }
            }
        }
        private void FillCompoBox()
        {
            db.Students.Load();
            var Students = db.Students.Local.ToBindingList();
            comboBox2.DataSource = Students;
            comboBox2.DisplayMember = "Fname";
            comboBox2.ValueMember = "St_Id";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            Guid stId = (Guid)comboBox2.SelectedValue;
            Guid crsSesionId = (Guid)comboBox1.SelectedValue;

            Guid studId = (Guid)comboBox2.SelectedValue;
            Guid crsSessionId = (Guid)comboBox1.SelectedValue;
            if (crsSessionId == Guid.Empty)
            {
                MessageBox.Show("course setion is requierd");
                return;
            }
            var crsSessionAttendance = db.CourseSessionAttendances.FirstOrDefault(csa => csa.St_ID == stId && csa.CrsSession_ID == crsSessionId);

            db.CourseSessionAttendances.Remove(crsSessionAttendance);
            var result = db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show($"{result} rows affected");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
