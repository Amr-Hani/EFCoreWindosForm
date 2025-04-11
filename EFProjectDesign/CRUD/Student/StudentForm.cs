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

namespace EFProjectDesign.CRUD.Student
{
    public partial class StudentForm : Form
    {
        MyContext db;
        Guid studentId;

        public StudentForm()
        {
            InitializeComponent();
            db = new MyContext();
            db.Students.Load();
            var students = db.Students.Local.ToBindingList();
            dataGridView1.DataSource = students;
            UnShowForm();
            comboBox1.Visible = false;
            saveDelete.Visible = false;
            saveUpdate.Visible = false;
            saveAdd.Visible = false;
        }
        private void deleteStudent_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            var students = db.Students.Local.ToBindingList();
            comboBox1.Items.Clear();
            foreach (var student in students)
            {
                comboBox1.Items.Add(student.Fname + " " + student.Lname);
            }
            dataGridView1.Visible = false;
            saveDelete.Visible = true;
            saveUpdate.Visible = false;
            saveAdd.Visible = false;
            UnShowForm();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            saveDelete.Visible = false;
            comboBox1.Visible = false;
            saveUpdate.Visible = false;
            saveAdd.Visible = true;
            UnShowGrid();
            ShowForm();
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            saveDelete.Visible = false;
            saveUpdate.Visible = true;
            saveAdd.Visible = false;
            comboBox1.Visible = true;
            var students = db.Students.Local.ToBindingList();
            comboBox1.Items.Clear();
            foreach (var student in students)
            {
                comboBox1.Items.Add(student.Fname + " " + student.Lname);
            }
            comboBox1.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    // الحصول على الطالب الذي تم اختياره
                    var selectedStudent = students[comboBox1.SelectedIndex];

                    // تحديث الحقول بالقيم المختارة
                    FName.Text = selectedStudent.Fname;
                    LName.Text = selectedStudent.Lname;
                    Phone.Text = selectedStudent.Phone;
                    studentId = selectedStudent.St_Id;
                }
            };

            UnShowGrid();
            ShowForm();
        }

        private void bshowStudent_Click(object sender, EventArgs e)
        {
            saveDelete.Visible = false;
            saveUpdate.Visible = false;
            saveAdd.Visible = false;
            comboBox1.Visible = false;
            ShowGrid();
            UnShowForm();
        }

       

        private void UnShowForm()
        {

            FName.Visible = false;
            LName.Visible = false;
            Phone.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void ShowForm()
        {
            FName.Visible = true;
            LName.Visible = true;
            Phone.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void UnShowGrid()
        {
            dataGridView1.Visible = false;
        }

        private void ShowGrid()
        {
            dataGridView1.Visible = true;
        }

        private void saveUpdate_Click_1(object sender, EventArgs e)
        {
            var student = db.Students.Find(studentId);

            student.Fname = FName.Text;
            student.Lname = LName.Text;
            student.Phone = Phone.Text;
           

            db.Students.Update(student);
            MessageBox.Show(student.Lname);
            

            db.SaveChanges();
            MessageBox.Show("fdsfgdsfds");

            //RefreshStudentList();
        }
        private void RefreshStudentList()
        {
            var students = db.Students.ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void saveDelete_Click_1(object sender, EventArgs e)
        {
            var student = db.Students.Find(studentId);
            db.Students.Remove(student);
            db.SaveChanges();

        }

        private void saveAdd_Click_1(object sender, EventArgs e)
        {
            db.Students.Add(new EFProject.Models.Student
            {
                Fname = FName.Text,
                Lname = LName.Text,
                Phone = Phone.Text,
            });
            db.SaveChanges();
        }
    }
}
