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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.CRUD.InstructorForms
{
    public partial class DeleteInstructor : Form
    {
        MyContext db;
        public DeleteInstructor()
        {
            InitializeComponent();
            db = new MyContext();
            db.Instructors.Load();
            FillCompoBoxIns();
        }

        private void DeleteIns_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DialogResult result = MessageBox.Show("Are you sure delete this Instructor", "Yes deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Guid id = (Guid)comboBox2.SelectedValue;
                    Instructor instructor = db.Instructors.Find(id);
                    if (instructor != null)
                    {
                        db.Instructors.Remove(instructor);
                        var res = db.SaveChanges();
                        if (res > 0)
                        {
                            MessageBox.Show($"{result} rows affected");
                        }
                    }
                    else
                    {
                        MessageBox.Show("this Instructor not found");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void FillCompoBoxIns()
        {
            var instructors = db.Instructors.Local.ToBindingList();
            comboBox2.DataSource = instructors;
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Ins_Id";
        }
    }
}
