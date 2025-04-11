namespace WinFormsApp1.CRUD.CourseSessionForms
{
    partial class DeleteCourseSession
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
            SuspendLayout();
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(80, 105);
            Courses.Name = "Courses";
            Courses.Size = new Size(113, 20);
            Courses.TabIndex = 113;
            Courses.Text = "Courses Session";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(230, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 112;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(80, 207);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 115;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(551, 207);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 114;
            AddCourse.Text = "Delete";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // DeleteCourseSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox1);
            Name = "DeleteCourseSession";
            Text = "DeleteCourseSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Courses;
        private ComboBox comboBox1;
        private Button btnBack;
        private Button AddCourse;
    }
}