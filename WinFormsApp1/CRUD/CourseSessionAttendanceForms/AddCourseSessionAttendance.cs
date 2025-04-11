using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Context;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.CRUD.CourseSessionAttendanceForms
{
    public partial class AddCourseSessionAttendance : Form
    {
        MyContext db;
        public AddCourseSessionAttendance()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrsSession();
            FillCompoBox();

            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string fname = Lbl_Fname.Text;
            string lname = Lbl_Lname.Text;
            if (string.IsNullOrWhiteSpace(fname))
            {
                ErrFName.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lname) || !lname.All(char.IsLetter))
            {
                isValid = false;
                ErrLName.Visible = true;
            }
           
            if (isValid)
            {

                Guid studId = (Guid)comboBox2.SelectedValue;
                Guid crsSessionId = (Guid)comboBox1.SelectedValue;
                CourseSessionAttendance csa = new CourseSessionAttendance
                { 
                    Grade = int.Parse(fname),
                    Notes = lname,
                    CrsSession_ID = crsSessionId,
                    St_ID = studId
                    

                };
                db.CourseSessionAttendances.Add(csa);
                var result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show($"{result} rows affected");
                    Lbl_Fname.Text = "";
                    Lbl_Lname.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillCompoBoxCrsSession()
        {
            db.CourseSessions.Load();
            var courseSessions = db.CourseSessions.Local.ToBindingList();
            comboBox1.DataSource = courseSessions;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "CrsSession_Id";
        }

        private void FillCompoBox()
        {
            db.Students.Load();
            var Students = db.Students.Local.ToBindingList();
            comboBox2.DataSource = Students;
            comboBox2.DisplayMember = "Fname";
            comboBox2.ValueMember = "St_Id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
