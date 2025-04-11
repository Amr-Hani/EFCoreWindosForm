using EFProject.Context;
using EFProject.Models;
using EFProjectDesign.CRUD.Student;
using Microsoft.EntityFrameworkCore;

namespace EFProjectDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void student_Click(object sender, EventArgs e)
        {

            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }
    }
}
