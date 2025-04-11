namespace WinFormsApp1.CRUD.CourseStudentForms
{
    partial class AddCourseStudent
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
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            btnBack = new Button();
            AddCourse = new Button();
            ErrFName = new Label();
            ErrLName = new Label();
            SuspendLayout();
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(87, 37);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 130;
            Courses.Text = "Courses";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(237, 34);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(470, 28);
            comboBox3.TabIndex = 129;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 133);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 132;
            label4.Text = "Students";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(237, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 131;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(87, 245);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 134;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(558, 245);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 133;
            AddCourse.Text = "Add";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(237, 85);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 135;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(237, 186);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 136;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // AddCourseStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(Courses);
            Controls.Add(comboBox3);
            Name = "AddCourseStudent";
            Text = "AddCourseStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Courses;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnBack;
        private Button AddCourse;
        private Label ErrFName;
        private Label ErrLName;
    }
}