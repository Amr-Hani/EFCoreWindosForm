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

namespace WinFormsApp1.CRUD.CourseForms
{
    public partial class AddCourses : Form
    {
        MyContext db;
        public AddCourses()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBox();
            FillCompoBoxIns();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }

     
        private void AddCourse_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string name = Lbl_Fname.Text;
            string loc = Lbl_Lname.Text;
            if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
            {
                ErrFName.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(loc))
            {
                isValid = false;
                ErrLName.Visible = true;
            }


            if (isValid)
            {
                Guid DeptId = (Guid)comboBox1.SelectedValue;
                Guid insId = (Guid)comboBox2.SelectedValue;
                Course course = new Course
                {
                    Course_Name = name,
                    Duration = int.Parse(loc),
                    Ins_Id = insId,
                    Dept_Id = DeptId
                };
                db.Courses.Add(course);
                FillCompoBoxIns();
                var result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show($"{result} rows affected");
                    Lbl_Fname.Text = "";
                    Lbl_Lname.Text = "";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void FillCompoBox()
        {
            db.Departments.Load();
            var department = db.Departments.Local.ToBindingList();
            comboBox1.DataSource = department.ToArray();
            comboBox1.DisplayMember = "Dept_Name";
            comboBox1.ValueMember = "Dept_Id";
        }
        private void FillCompoBoxIns()
        {
            db.Instructors.Load();
            var instructors = db.Instructors.Local.ToBindingList();
            comboBox2.DataSource = instructors;
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Ins_Id";
        }

        private void Lbl_Fname_TextChanged(object sender, EventArgs e)
        {
            ErrFName.Visible = false;
        }

        private void Lbl_Lname_TextChanged(object sender, EventArgs e)
        {
            ErrLName.Visible = false;
        }

    }
}
