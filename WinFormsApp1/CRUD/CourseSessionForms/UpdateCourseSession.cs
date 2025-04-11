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
    public partial class UpdateCourseSession : Form
    {
        MyContext db;
        public UpdateCourseSession()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrsSession();
            FillCompoBoxIns();
            FillCompoBoxCrs();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            MessageBox.Show("amr");
            string name = Lbl_Fname.Text;
            DateTime date = DateTime.Now;
            if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
            {
                ErrFName.Visible = true;
                isValid = false;
            }
            if (dateTimePicker1.Value != null)
            {
                date = dateTimePicker1.Value;
                ErrLName.Visible = false;
            }
            else
            {
                isValid = false;
                ErrLName.Visible = true;
                MessageBox.Show("error");
            }
            if (isValid)
            {
                Guid crsSess = (Guid)comboBox1.SelectedValue;
                Guid insId = (Guid)comboBox2.SelectedValue;
                Guid corsId = (Guid)comboBox3.SelectedValue;

                CourseSession crsSession = db.CourseSessions.Find(crsSess);
                crsSession.Crs_Id = corsId;
                crsSession.Ins_Id = insId;
                crsSession.Title = name;
                crsSession.Date = date;
                MessageBox.Show(name);
                db.CourseSessions.Update(crsSession);

                FillCompoBoxIns();
                var result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show($"{result} rows affected");
                    Lbl_Fname.Text = "";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void FillCompoBoxCrsSession()
        {
            db.CourseSessions.Load();
            var courseSessions = db.CourseSessions.Local.ToBindingList();
            comboBox1.DataSource = courseSessions;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "CrsSession_Id";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                CourseSession crs = db.CourseSessions.Find(id);
                Lbl_Fname.Text = crs.Title;
                dateTimePicker1.Value = crs.Date;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
