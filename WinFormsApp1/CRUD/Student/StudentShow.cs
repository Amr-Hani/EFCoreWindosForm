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
    public partial class StudentShow : Form
    {
        public StudentShow()
        {
            InitializeComponent();
            MyContext db = new MyContext();
            db.Students.Load();
            var students = db.Students.Local.ToBindingList();
            dataGridView1.DataSource = students;

        }
    }
}
