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
using Microsoft.IdentityModel.Tokens;

namespace WinFormsApp1.CRUD.DepartmentForms
{
    public partial class UpdateDepartment : Form
    {
        MyContext db;
        Department selectedDept;
        public UpdateDepartment()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBox();
            FillCompoBoxIns();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
        }

        private void UpdateDepartmnet_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string fname = Lbl_Fname.Text;
            string lname = Lbl_Lname.Text;
            //string phone = Lbl_Phone.Text;
            if (string.IsNullOrWhiteSpace(fname) || !fname.All(char.IsLetter))
            {
                ErrFName.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lname))
            {
                isValid = false;
                ErrLName.Visible = true;
            }


            if (isValid)
            {
                Guid id = (Guid)comboBox1.SelectedValue;

                Guid? managerId = (Guid)comboBox2.SelectedValue;

                //var ins = db.Instructors.FirstOrDefault(i=>i.FName == Lbl_Phone.Text.Trim());
                //MessageBox.Show($"{ins.FName}");
                var department = db.Departments.Find(id);
                department.Dept_Name = fname;
                department.Dept_Location = lname;
                department.Manger_id = managerId != null ? managerId : null;
                var manager = db.Departments.FirstOrDefault(i => i.Manger_id == managerId);
                if (manager != null)
                {
                    MessageBox.Show("This Manager Manage a Department!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isValid = false;
                }
                else
                {
                    db.Departments.Update(department);
                    FillCompoBoxIns();
                    FillCompoBox();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Lbl_Fname_TextChanged(object sender, EventArgs e)
        {
            ErrFName.Visible = false;
        }

        private void Lbl_Lname_TextChanged(object sender, EventArgs e)
        {
            ErrLName.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                //Department dept = db.Departments.FirstOrDefault(d => d.Dept_Id == id);
                Department dept = db.Departments.Include(i => i.InsManger).FirstOrDefault(d => d.Dept_Id == id);
                selectedDept = dept;
                Lbl_Fname.Text = dept.Dept_Name;
                Lbl_Lname.Text = dept.Dept_Location;
                var instractor = db.Instructors.Find(dept.Manger_id);
                if (instractor != null)

                {
                    Lbl_Phone.Text = dept.InsManger.FName;
                    //Lbl_Phone.Text = instractor.FName + " " + instractor.LName;
                }
                else
                {
                    Lbl_Phone.Text = "";
                }
            }
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

        private void FillCompoBox()
        {
            db.Departments.Load();
            //var departments = db.Departments.Include(i => i.InsManger).Where(i=>i.Manger_id == i.InsManger.Ins_Id);

            var department = db.Departments.Local.ToBindingList();
            comboBox1.DataSource = department.ToArray();
            comboBox1.DisplayMember = "Dept_Name";
            comboBox1.ValueMember = "Dept_Id";
            //MessageBox.Show(department[0].Dept_Name);
        }
        private void FillCompoBoxIns()
        {
            db.Instructors.Load();
            var instructors = db.Instructors.Local.ToBindingList();
            comboBox2.DataSource = instructors;
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Ins_Id";
        }
    }
}
