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

namespace WinFormsApp1.CRUD.InstructorForms
{
    public partial class ShowAllInstructor : Form
    {
        MyContext db;
        public ShowAllInstructor()
        {
            InitializeComponent();
            db = new MyContext();
            db.Instructors.Load();
            ShowAll();
        }

        private void ShowAll()
        {
            dataGridView1.DataSource = db.Instructors.Include(i => i.Department).Select(i => new
            {
                i.FName,
                i.LName,
                i.PhoneNumber,
                DepartmentName = i.Department != null ? i.Department.Dept_Name : "N/A"
            }).ToList();
            dataGridView1.ReadOnly = true;

        }
    }
}
