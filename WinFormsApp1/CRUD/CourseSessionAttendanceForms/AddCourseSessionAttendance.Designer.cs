namespace WinFormsApp1.CRUD.CourseSessionAttendanceForms
{
    partial class AddCourseSessionAttendance
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
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            ErrLName = new Label();
            ErrFName = new Label();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(68, 348);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 119;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(539, 348);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 118;
            AddCourse.Text = "Add";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(68, 82);
            Courses.Name = "Courses";
            Courses.Size = new Size(113, 20);
            Courses.TabIndex = 117;
            Courses.Text = "Courses Session";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 116;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 121;
            label4.Text = "Students";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(218, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 120;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(218, 275);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 127;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(218, 183);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 126;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(218, 221);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 125;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(218, 141);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 124;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 221);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 123;
            label2.Text = "Note";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 144);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 122;
            label1.Text = "Grade";
            // 
            // AddCourseSessionAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox1);
            Name = "AddCourseSessionAttendance";
            Text = "AddCourseSessionAttendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button AddCourse;
        private Label Courses;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label ErrLName;
        private Label ErrFName;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label2;
        private Label label1;
    }
}