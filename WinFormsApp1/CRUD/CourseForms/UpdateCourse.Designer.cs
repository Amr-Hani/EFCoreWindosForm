namespace WinFormsApp1.CRUD.CourseForms
{
    partial class UpdateCourse
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
            ErrLName = new Label();
            ErrFName = new Label();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            AddCourse = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            lblDepartment = new TextBox();
            lblInsrtuctor = new TextBox();
            label3 = new Label();
            label5 = new Label();
            Courses = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(231, 306);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 105;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(231, 221);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 104;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(231, 259);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 103;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(231, 179);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 102;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 259);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 101;
            label2.Text = "Course Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 182);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 100;
            label1.Text = "Course Name";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(81, 437);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 99;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(552, 437);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 98;
            AddCourse.Text = "Update";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 34);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 97;
            label4.Text = "Departments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 96;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 87);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 95;
            label7.Text = "Instructors";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(234, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 94;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblDepartment
            // 
            lblDepartment.Enabled = false;
            lblDepartment.Location = new Point(231, 343);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(470, 27);
            lblDepartment.TabIndex = 106;
            lblDepartment.TextChanged += lblDepartment_TextChanged;
            // 
            // lblInsrtuctor
            // 
            lblInsrtuctor.Enabled = false;
            lblInsrtuctor.Location = new Point(231, 386);
            lblInsrtuctor.Name = "lblInsrtuctor";
            lblInsrtuctor.Size = new Size(470, 27);
            lblInsrtuctor.TabIndex = 107;
            lblInsrtuctor.TextChanged += lblInsrtuctor_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 393);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 108;
            label3.Text = "Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 346);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 109;
            label5.Text = "Department";
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(84, 136);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 111;
            Courses.Text = "Courses";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(234, 133);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(470, 28);
            comboBox3.TabIndex = 110;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // UpdateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(Courses);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblInsrtuctor);
            Controls.Add(lblDepartment);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Name = "UpdateCourse";
            Text = "UpdateCourse";
            Load += UpdateCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrLName;
        private Label ErrFName;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Button AddCourse;
        private Label label4;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private TextBox lblDepartment;
        private TextBox lblInsrtuctor;
        private Label label3;
        private Label label5;
        private Label Courses;
        private ComboBox comboBox3;
    }
}