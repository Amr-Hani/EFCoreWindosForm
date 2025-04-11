using WinFormsApp1.CRUD.CourseForms;
using WinFormsApp1.CRUD.CourseSessionAttendanceForms;
using WinFormsApp1.CRUD.CourseSessionForms;
using WinFormsApp1.CRUD.CourseStudentForms;
using WinFormsApp1.CRUD.DepartmentForms;
using WinFormsApp1.CRUD.InstructorForms;
using WinFormsApp1.CRUD.Student;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Navigate(string? table, string? operation)
        {
            // here maek switch case

            //MessageBox.Show($"go to table : {table} and make : {operation}");
            switch (table)
            {
                case "Student":
                    NavigateToStudent(operation);
                    break;
                case "Instructor":
                    NavigateToInstructor(operation);
                    break;
                case "Department":
                    NavigateToDepartment(operation);
                    break;
                case "Courses":
                    NavigateToCourse(operation);
                    break;
                case "CourseSession":
                    NavigateToCourseSession(operation);
                    break;
                case "CourseStudent":
                    NavigateToCourseStudent(operation);
                    break;
                case "CourseSessionAttendance":
                    NavigateToCourseSessionAttendance(operation);
                    break;

            }
        }
        private void NavigateToStudent(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new StudentAdd().Show();
                    break;
                case "Delete":
                    new DeleteStudent().Show();
                    break;
                case "Update":
                    new UpdateStudent().Show();
                    break;
                case "ShowAll":
                    new StudentShow().Show();
                    break;
            }
        }
        private void NavigateToInstructor(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new AddInstructor().Show();
                    break;
                case "Delete":
                    new DeleteInstructor().Show();
                    break;
                case "Update":
                    new UpdateInstructor().Show();
                    break;
                case "ShowAll":
                    new ShowAllInstructor().Show();
                    break;
            }
        }
        private void NavigateToDepartment(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new AddDepartment().Show();
                    break;
                case "Delete":
                    new DeleteDepartment().Show();
                    break;
                case "Update":
                    new UpdateDepartment().Show();
                    break;
                case "ShowAll":
                    new ShowAllDepartment().Show();
                    break;
            }
        }
        private void NavigateToCourse(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new AddCourses().Show();
                    break;
                case "Delete":
                    new DeleteCourse().Show();
                    break;
                case "Update":
                    new UpdateCourse().Show();
                    break;
                case "ShowAll":
                    new ShowAllCources().Show();
                    break;
            }
        }
        private void NavigateToCourseSession(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new AddCourseSession().Show();
                    break;
                case "Delete":
                    new DeleteCourseSession().Show();
                    break;
                case "Update":
                    new UpdateCourseSession().Show();
                    break;
                case "ShowAll":
                    new ShowAllCourseSession().Show();
                    break;
            }
        }
        private void NavigateToCourseStudent(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new AddCourseStudent().Show();
                    break;
                case "Delete":
                    new DeleteCourseStudent().Show();
                    break;
                case "Update":
                    //new UpdateCourseSession().Show();
                    break;
                case "ShowAll":
                    new ShowAllCourseStudent().Show();
                    break;
            }
        }
        private void NavigateToCourseSessionAttendance(string? operation)
        {
            switch (operation)
            {
                case "Add":
                    new AddCourseSessionAttendance().Show();
                    break;
                case "Delete":
                    new DeleteCourseSessionAttendence().Show();
                    break;
                case "Update":
                    //new UpdateCourseSession().Show();
                    break;
                case "ShowAll":
                    new ShowAllCourseSesionAttendance().Show();
                    break;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItemOption = (ToolStripMenuItem)sender;


            //   MessageBox.Show($"Clicked Item: {menuItemOption.Text}");
            var operation = menuItemOption.Text;
            string table = null;
            var parentMenuItem = menuItemOption.OwnerItem as ToolStripMenuItem;

            if (parentMenuItem != null)
            {
                //  MessageBox.Show($"Parent Item: {parentMenuItem.Text}"); 
                table = parentMenuItem.Text;

                Navigate(table, operation);
            }
            else
            {
                // mt3mlsh 7aga 
                // MessageBox.Show("This is a top-level menu item.");
            }
        }
    }
}
