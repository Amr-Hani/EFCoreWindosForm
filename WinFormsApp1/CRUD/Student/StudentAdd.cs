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

namespace WinFormsApp1.CRUD.Student
{
    public partial class StudentAdd : Form
    {
        MyContext db;
        public StudentAdd()
        {
            InitializeComponent();
            db = new MyContext();
            ErrFName.Visible = false;
            ErrLName.Visible = false;
            ErrPhone.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
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
                EFProject.Models.Student std = new EFProject.Models.Student
                {
                    Fname = Lbl_Fname.Text,
                    Lname = Lbl_Lname.Text,
                    Phone = Lbl_Phone.Text,
                };
                db.Students.Add(std);
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

        private void Lbl_Phone_TextChanged(object sender, EventArgs e)
        {
            ErrPhone.Visible = false;
        }

        private void Lbl_Lname_TextChanged(object sender, EventArgs e)
        {
            ErrLName.Visible = false;
        }

        private void Lbl_Fname_TextChanged(object sender, EventArgs e)
        {
           ErrFName.Visible = false;
        }

    }
}
