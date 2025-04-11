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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.CRUD.DepartmentForms
{
    public partial class AddDepartment : Form
    {
        MyContext db;
        public AddDepartment()
        {
            InitializeComponent();
            db = new MyContext();
            db.Instructors.Load();
            FillCompoBoxIns();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox2.SelectedValue;
                Instructor instructor = db.Instructors.Find(id);
                Lbl_Phone.Text = instructor.FName;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void AddDept_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string name = Lbl_Fname.Text;
            string loc = Lbl_Lname.Text;
            Guid id = (Guid)comboBox2.SelectedValue;
            if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
            {
                ErrFName.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(loc) || !loc.All(char.IsLetter))
            {
                isValid = false;
                ErrLName.Visible = true;
            }


            if (isValid)
            {
                Department dept = new Department
                {
                    Dept_Name = name,
                    Dept_Location = loc,
                    Manger_id = (Guid)comboBox2.SelectedValue,

                };
                var manager = db.Departments.FirstOrDefault(i => i.Manger_id == (Guid)comboBox2.SelectedValue);
                if (manager != null)
                {
                    MessageBox.Show("This Manager Manage a Department!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isValid = false;
                }
                else
                {
                    db.Departments.Add(dept);
                    FillCompoBoxIns();
                    var result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show($"{result} rows affected");
                        Lbl_Fname.Text = "";
                        Lbl_Lname.Text = "";
                        Lbl_Phone.Text = "";
                    }
                }
            }
        }

        private void FillCompoBoxIns()
        {
            var instructors = db.Instructors.Local.ToBindingList();
            comboBox2.DataSource = instructors;
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Ins_Id";
        }

        private void Lbl_Lname_TextChanged(object sender, EventArgs e)
        {
            ErrFName.Visible = false;
        }

        private void Lbl_Fname_TextChanged(object sender, EventArgs e)
        {
            ErrLName.Visible = false;
        }
    }
}
