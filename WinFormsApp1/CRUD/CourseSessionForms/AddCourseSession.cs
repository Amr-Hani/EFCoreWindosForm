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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.CRUD.CourseSessionForms
{
    public partial class AddCourseSession : Form
    {
        MyContext db;
        public AddCourseSession()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrs();
            FillCompoBoxIns();
            ErrFName.Visible = false;
        }

        private void AddCourse_Click_1(object sender, EventArgs e)
        {
            bool isValid = true;
            string name = Lbl_Fname.Text;
            if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
            {
                ErrFName.Visible = true;
                isValid = false;
            }


            if (isValid)
            {
                Guid insId = (Guid)comboBox2.SelectedValue;
                Guid corsId = (Guid)comboBox3.SelectedValue;
               
                CourseSession crsSes = new CourseSession
                {
                    Title = name,
                    Date = DateTime.Now,
                    Ins_Id = insId,
                    Crs_Id = corsId,
                };
                db.CourseSessions.Add(crsSes);
                FillCompoBoxIns();
                var result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show($"{result} rows affected");
                    Lbl_Fname.Text = "";
                }
            }
        }


        private void FillCompoBoxCrs()
        {
            db.Courses.Load();
            var crss = db.Courses.Local.ToBindingList();
            comboBox3.DataSource = crss;
            comboBox3.DisplayMember = "Course_Name";
            comboBox3.ValueMember = "Crs_Id";
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
