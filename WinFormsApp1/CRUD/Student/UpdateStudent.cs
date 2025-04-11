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
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.CRUD.Student
{
    public partial class UpdateStudent : Form
    {
        MyContext db;
        public UpdateStudent()
        {
            InitializeComponent();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
            ErrPhone.Visible = false;
            db = new MyContext();
            db.Students.Load();
            FillCompoBox();

        }

        private void UpdateStude_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string fname = Lbl_Fname.Text;
            string lname = Lbl_Lname.Text;
            string phone = Lbl_Phone.Text;
            if (string.IsNullOrWhiteSpace(fname) || !fname.All(char.IsLetter))
            {
                ErrFName.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lname) || !lname.All(char.IsLetter))
            {
                isValid = false;
                ErrLName.Visible = true;
            }
            if (!Regex.IsMatch(phone, @"^01[0125]\d{8}$"))
            {
                isValid = false;
                ErrPhone.Visible = true;
            }

            if (isValid)
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                var student = db.Students.Find(id);
                student.Fname = fname;
                student.Lname = lname;
                student.Phone = phone;
                db.Students.Update(student);
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

        private void Lbl_Fname_TextChanged(object sender, EventArgs e)
        {
            ErrPhone.Visible = false;
        }

        private void Lbl_Lname_TextChanged(object sender, EventArgs e)
        {
            ErrLName.Visible = false;

        }

        private void Lbl_Phone_TextChanged(object sender, EventArgs e)
        {
            ErrFName.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDataIntoField();
        }

        private void AddDataIntoField()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                //MessageBox.Show(id.ToString());
                EFProject.Models.Student student = db.Students.Find(id);
                Lbl_Fname.Text = student.Fname;
                Lbl_Lname.Text = student.Lname;
                Lbl_Phone.Text = student.Phone;
            }
        }

        private void FillCompoBox()
        {
            db.Departments.Load();
            var department = db.Departments.Local.ToBindingList();
            comboBox1.DataSource = department;
            comboBox1.DisplayMember = "Dept_Name";
            comboBox1.ValueMember = "Dept_Id";
            //MessageBox.Show(department[0].Dept_Name);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
