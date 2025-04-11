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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.CRUD.CourseStudentForms
{
    public partial class DeleteCourseStudent : Form
    {
        MyContext db;
        public DeleteCourseStudent()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrsStudebnt();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this Instructor", "Yes deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                Guid std_Id = (Guid)comboBox1.SelectedValue;
                Guid crs_Id = (Guid)comboBox2.SelectedValue;

                if (std_Id != Guid.Empty && crs_Id != Guid.Empty)
                {
                    var crsStud = db.CousreStudents.FirstOrDefault(cs => cs.St_ID == std_Id && cs.CourseID == crs_Id);
                    if (crsStud != null)
                    {
                        db.CousreStudents.Remove(crsStud);
                        var res = db.SaveChanges();
                        if (res > 0)
                        {
                            MessageBox.Show($"{res} rows affected");
                            comboBox2.DataSource = null;
                            comboBox2.Items.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Course Student Not Found");

                    }
                }
                else
                {
                    MessageBox.Show("Please select Student and Course");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void FillCompoBoxCrsStudebnt()
        {
            db.Students.Load();
            comboBox1.DataSource = db.Students.Local.ToBindingList();
            comboBox1.DisplayMember = "Fname";
            comboBox1.ValueMember = "St_Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                var crs = db.CousreStudents
                    .Include(c => c.Course)
                    .Include(s => s.Student)
                    .Where(cs => cs.St_ID == id)
                    .Select(cs => new { cs.Course.Course_Name, cs.CourseID })
                    .ToArray();
                if (crs.Length > 0)
                {
                    comboBox2.DataSource = crs;
                    comboBox2.DisplayMember = "Course_Name";
                    comboBox2.ValueMember = "CourseID";
                }
                else
                {
                    comboBox2.DataSource = null;
                    comboBox2.Items.Clear();
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
