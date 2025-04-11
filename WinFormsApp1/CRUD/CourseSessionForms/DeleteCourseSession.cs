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

namespace WinFormsApp1.CRUD.CourseSessionForms
{
    public partial class DeleteCourseSession : Form
    {
        MyContext db;
        public DeleteCourseSession()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBoxCrsSession();
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

        private void AddCourse_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this Instructor", "Yes deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                var crsSission = db.CourseSessions.Find(id);
                if (crsSission != null)
                {
                    db.CourseSessions.Remove(crsSission);
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
    }
}
