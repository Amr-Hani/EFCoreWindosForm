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
using EFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.CRUD.DepartmentForms
{
    public partial class DeleteDepartment : Form
    {
        MyContext db;
        public DeleteDepartment()
        {
            InitializeComponent();
            db = new MyContext();
            FillCompoBox();
        }

        private void DeleteDepartmnet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this Instructor", "Yes deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Guid id = (Guid)comboBox1.SelectedValue;
                Department dept = db.Departments.Find(id);
                if (dept != null)
                {
                    db.Departments.Remove(dept);
                    var res = db.SaveChanges();
                    if (res > 0)
                    {
                        MessageBox.Show($"{res} rows affected");
                    }
                }
                else
                {
                    MessageBox.Show("this Instructor not found");
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
