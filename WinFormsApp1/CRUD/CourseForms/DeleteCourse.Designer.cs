namespace WinFormsApp1.CRUD.CourseForms
{
    partial class DeleteCourse
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
            btnBack = new Button();
            AddCourse = new Button();
            SuspendLayout();
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(90, 85);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 113;
            Courses.Text = "Courses";
            Courses.Click += Courses_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(240, 82);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(470, 28);
            comboBox3.TabIndex = 112;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(90, 211);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 115;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(561, 211);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(149, 29);
            AddCourse.TabIndex = 114;
            AddCourse.Text = "Delete";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // DeleteCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(AddCourse);
            Controls.Add(Courses);
            Controls.Add(comboBox3);
            Name = "DeleteCourse";
            Text = "DeleteCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Courses;
        private ComboBox comboBox3;
        private Button btnBack;
        private Button AddCourse;
    }
}