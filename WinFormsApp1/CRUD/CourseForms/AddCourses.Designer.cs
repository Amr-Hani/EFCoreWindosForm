namespace WinFormsApp1.CRUD.CourseForms
{
    partial class AddCourses
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
            comboBox1 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            btnBack = new Button();
            AddCourse = new Button();
            ErrFName = new Label();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ErrLName = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 44);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 85;
            label4.Text = "Departments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 84;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 92);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 83;
            label7.Text = "Instructors";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(227, 89);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 82;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(77, 325);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 87;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(548, 325);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 86;
            AddCourse.Text = "Add";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(227, 188);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 92;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(227, 226);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 91;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(227, 146);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 90;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 226);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 89;
            label2.Text = "Course Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 149);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 88;
            label1.Text = "Course Name";
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(227, 278);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 93;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // AddCourses
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
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Name = "AddCourses";
            Text = "AddCourses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Button btnBack;
        private Button AddCourse;
        private Label ErrFName;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label2;
        private Label label1;
        private Label ErrLName;
    }
}