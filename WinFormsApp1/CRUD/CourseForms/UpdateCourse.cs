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
    public partial class UpdateCourse : Form
    {
        MyContext db;
        public UpdateCourse()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBox();
            FillCompoBoxIns();
            FillCompoBoxCrs();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }

        private void lblDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amr");
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
                Guid crsId = (Guid)comboBox3.SelectedValue;
                var course = db.Courses.Find(crsId);
                if (course != null)
                {
                MessageBox.Show(crsId.ToString());
                    course.Course_Name = name;
                    course.Duration = int.Parse(loc);
                    course.Ins_Id = insId;
                    course.Dept_Id = DeptId;
                    db.Courses.Update(course);
                    FillCompoBoxIns();
                    var result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show($"{result} rows affected");
                        Lbl_Fname.Text = "";
                        Lbl_Lname.Text = "";
                        lblDepartment.Text = "";
                        lblInsrtuctor.Text = "";
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void lblInsrtuctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Lname_TextChanged(object sender, EventArgs e)
        {
            ErrFName.Visible = false;
        }

        private void Lbl_Fname_TextChanged(object sender, EventArgs e)
        {
            ErrLName.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox2.SelectedValue;
                Instructor instructor = db.Instructors.Find(id);
                lblInsrtuctor.Text = instructor.FName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                Department dept = db.Departments.FirstOrDefault(d => d.Dept_Id == id);
                lblDepartment.Text = dept.Dept_Name;
            }
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
        private void FillCompoBoxCrs()
        {
            db.Courses.Load();
            var crss = db.Courses.Local.ToBindingList();
            comboBox3.DataSource = crss;
            comboBox3.DisplayMember = "Course_Name";
            comboBox3.ValueMember = "Crs_Id";
        }

        private void UpdateCourse_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox3.SelectedValue;
                //Department dept = db.Departments.FirstOrDefault(d => d.Dept_Id == id);
                var courses = db.Courses.Include(i => i.Instructors).Include(d => d.Department).FirstOrDefault(c => c.Crs_Id == id);
                Lbl_Fname.Text = courses.Course_Name;
                Lbl_Lname.Text = courses.Duration.ToString();

                if (courses.Instructors != null)
                {
                    lblInsrtuctor.Text = courses.Instructors.FName;
                }
                else
                {
                    lblInsrtuctor.Text = "";
                }

                if (courses.Department != null)
                {
                    lblDepartment.Text = courses.Department.Dept_Name;
                }
                else
                {
                    lblDepartment.Text = "";
                }
                //var instractor = db.Instructors.Find(dept.Manger_id);
                //if (instractor != null)

                //{
                //    Lbl_Phone.Text = dept.InsManger.FName;
                //    //Lbl_Phone.Text = instractor.FName + " " + instractor.LName;
                //}
                //else
                //{
                //    Lbl_Phone.Text = "";
                //}
            }
        }

    }
}
