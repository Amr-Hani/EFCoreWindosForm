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

namespace WinFormsApp1.CRUD.CourseForms
{
    public partial class DeleteCourse : Form
    {
        MyContext db;
        public DeleteCourse()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrs();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this Instructor", "Yes deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Guid? id = (Guid)comboBox3.SelectedValue;
                var course = db.Courses.Find(id);

                if (course != null)
                {
                    db.Remove(course);
                    var res = db.SaveChanges();
                    if (res > 0)
                    {
                        MessageBox.Show($"{res} rows affected");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void FillCompoBoxCrs()
        {
            db.Courses.Load();
            var crss = db.Courses.Local.ToBindingList();
            comboBox3.DataSource = crss;
            comboBox3.DisplayMember = "Course_Name";
            comboBox3.ValueMember = "Crs_Id";
        }

        private void Courses_Click(object sender, EventArgs e)
        {

        }
    }
}
