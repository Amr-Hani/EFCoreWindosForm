namespace WinFormsApp1.CRUD.CourseSessionAttendanceForms
{
    partial class DeleteCourseSessionAttendence
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
            label4 = new Label();
            comboBox2 = new ComboBox();
            btnBack = new Button();
            AddCourse = new Button();
            Courses = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 82);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 133;
            label4.Text = "Students";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(240, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 132;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(90, 264);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 131;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(561, 264);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 130;
            AddCourse.Text = "Delete";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(90, 134);
            Courses.Name = "Courses";
            Courses.Size = new Size(113, 20);
            Courses.TabIndex = 129;
            Courses.Text = "Courses Session";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 128;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DeleteCourseSessionAttendence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox1);
            Name = "DeleteCourseSessionAttendence";
            Text = "DeleteCourseSessionAttendence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox2;
        private Button btnBack;
        private Button AddCourse;
        private Label Courses;
        private ComboBox comboBox1;
    }
}