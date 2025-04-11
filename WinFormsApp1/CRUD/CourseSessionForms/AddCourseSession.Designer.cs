namespace WinFormsApp1.CRUD.CourseSessionForms
{
    partial class AddCourseSession
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
            btnBack = new Button();
            AddCourse = new Button();
            Courses = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            ErrFName = new Label();
            Lbl_Fname = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(80, 298);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 119;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(561, 298);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 118;
            AddCourse.Text = "Add";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click_1;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(80, 54);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 117;
            Courses.Text = "Courses";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(230, 51);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(470, 28);
            comboBox3.TabIndex = 116;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 111);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 121;
            label7.Text = "Instructors";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(230, 108);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 120;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(230, 205);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 126;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(230, 159);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 124;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 162);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 122;
            label1.Text = "Course Title";
            // 
            // AddCourseSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrFName);
            Controls.Add(Lbl_Fname);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox3);
            Name = "AddCourseSession";
            Text = "AddCourseSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button AddCourse;
        private Label Courses;
        private ComboBox comboBox3;
        private Label label7;
        private ComboBox comboBox2;
        private Label ErrFName;
        private TextBox Lbl_Fname;
        private Label label1;
    }
}