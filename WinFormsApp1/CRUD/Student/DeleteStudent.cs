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

namespace WinFormsApp1.CRUD.Student
{
    public partial class DeleteStudent : Form
    {
        MyContext db;
        public DeleteStudent()
        {
            InitializeComponent();
            db = new MyContext();
            db.Students.Load();
            FillCompoBox();
        }

        private void FillCompoBox()
        {
            var Students = db.Students.Local.ToBindingList();
            comboBox1.DataSource = Students;
            comboBox1.DisplayMember = $"Fname";
            comboBox1.ValueMember = "St_Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteStud_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure delete this Student", "Yes deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                var student = db.Students.Find(id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("this user not found");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
