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

namespace WinFormsApp1.CRUD.CourseStudentForms
{
    public partial class AddCourseStudent : Form
    {
        MyContext db;
        public AddCourseStudent()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrs();
            FillCompoBox();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }


        private void FillCompoBoxCrs()
        {
            db.Courses.Load();
            var crss = db.Courses.Local.ToBindingList();
            comboBox3.DataSource = crss;
            comboBox3.DisplayMember = "Course_Name";
            comboBox3.ValueMember = "Crs_Id";
        }

        private void FillCompoBox()
        {
            db.Students.Load();
            var students = db.Students.Local.ToBindingList();
            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "Fname";
            comboBox1.ValueMember = "St_Id";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Guid studentId = (Guid)comboBox1.SelectedValue;
            Guid coursetId = (Guid)comboBox3.SelectedValue;

            var student = db.Students.Find(studentId);
            var course = db.Courses.Find(coursetId);
            MessageBox.Show(course.Course_Name);
            MessageBox.Show(student.Fname);

            if (student == null) 
            {
                flag = true;
                ErrFName.Visible = true;
            }
            else
            {
                ErrFName.Visible = false;
            }

            if (course == null)
            {
                flag = true;
                ErrLName.Visible = true;
            }
            else
            {
                ErrLName.Visible = false;
            }



            if (flag)
            {
                MessageBox.Show("Please select Course And Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var oldCousreStudents = db.CousreStudents
                .FirstOrDefault(sc => sc.St_ID == studentId && sc.CourseID == coursetId);

            if (oldCousreStudents != null)
            {
                MessageBox.Show("This Student Is Alredy found in this Course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newCousreStudents = new CousreStudent
            {
                St_ID = studentId,
                CourseID = coursetId,
            };

            db.CousreStudents.Add(newCousreStudents);
            var res = db.SaveChanges();
            MessageBox.Show($"{res} row affected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
