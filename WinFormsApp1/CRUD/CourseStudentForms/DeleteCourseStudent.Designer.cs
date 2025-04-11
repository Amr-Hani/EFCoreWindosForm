namespace WinFormsApp1.CRUD.CourseStudentForms
{
    partial class DeleteCourseStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Courses = new Label();
            comboBox1 = new ComboBox();
            btnBack = new Button();
            AddCourse = new Button();
            label1 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(69, 77);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 132;
            Courses.Text = "Student";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 131;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(69, 199);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 136;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(540, 199);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 135;
            AddCourse.Text = "Delete";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 125);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 138;
            label1.Text = "Course";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(219, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 137;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // DeleteCourseStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox1);
            Name = "DeleteCourseStudent";
            Text = "DeleteCourseStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Courses;
        private ComboBox comboBox1;
        private Button btnBack;
        private Button AddCourse;
        private Label label1;
        private ComboBox comboBox2;
    }
}