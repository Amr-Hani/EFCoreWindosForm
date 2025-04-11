namespace WinFormsApp1.CRUD.CourseSessionForms
{
    partial class UpdateCourseSession
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
            ErrFName = new Label();
            Lbl_Fname = new TextBox();
            label1 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            btnBack = new Button();
            AddCourse = new Button();
            Courses = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            ErrLName = new Label();
            SuspendLayout();
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(235, 227);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 135;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(235, 181);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 134;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 184);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 133;
            label1.Text = "Course Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 133);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 132;
            label7.Text = "Instructors";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(235, 130);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 131;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(78, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 130;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(559, 381);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 129;
            AddCourse.Text = "Update";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(85, 76);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 128;
            Courses.Text = "Courses";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(235, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(470, 28);
            comboBox3.TabIndex = 127;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 260);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 136;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 31);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 140;
            label3.Text = "Courses Session";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 139;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(235, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(470, 27);
            dateTimePicker1.TabIndex = 141;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(235, 312);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(123, 20);
            ErrLName.TabIndex = 142;
            ErrLName.Text = "Date Is Requierd ";
            // 
            // UpdateCourseSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrLName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(ErrFName);
            Controls.Add(Lbl_Fname);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox3);
            Name = "UpdateCourseSession";
            Text = "UpdateCourseSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrFName;
        private TextBox Lbl_Fname;
        private Label label1;
        private Label label7;
        private ComboBox comboBox2;
        private Button btnBack;
        private Button AddCourse;
        private Label Courses;
        private ComboBox comboBox3;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label ErrLName;
    }
}