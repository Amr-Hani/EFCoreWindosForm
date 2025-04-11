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

namespace WinFormsApp1.CRUD.DepartmentForms
{
    public partial class ShowAllDepartment : Form
    {
        MyContext db;
        public ShowAllDepartment()
        {
            InitializeComponent();
            db = new MyContext();
            var departments = db.Departments.Include(i => i.InsManger).Select(d => new { d.Dept_Name, d.Dept_Location, Manger = $"{d.InsManger.FName} {d.InsManger.LName}" });
            dataGridView1.DataSource = departments.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
