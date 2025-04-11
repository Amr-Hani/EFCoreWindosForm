namespace WinFormsApp1.CRUD.InstructorForms
{
    partial class UpdateInstructor
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
            label5 = new Label();
            Lbl_Dept = new TextBox();
            label6 = new Label();
            btnBack = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ErrPhone = new Label();
            ErrLName = new Label();
            ErrFName = new Label();
            UpdateIns = new Button();
            Lbl_Phone = new TextBox();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(205, 447);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 53;
            // 
            // Lbl_Dept
            // 
            Lbl_Dept.Location = new Point(205, 394);
            Lbl_Dept.Name = "Lbl_Dept";
            Lbl_Dept.Size = new Size(470, 27);
            Lbl_Dept.TabIndex = 52;
            Lbl_Dept.TextChanged += Lbl_Dept_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 397);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 51;
            label6.Text = "Department";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(76, 447);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 50;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 83);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 49;
            label4.Text = "Departments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(205, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 48;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ErrPhone
            // 
            ErrPhone.AutoSize = true;
            ErrPhone.ForeColor = Color.Red;
            ErrPhone.Location = new Point(205, 357);
            ErrPhone.Name = "ErrPhone";
            ErrPhone.Size = new Size(434, 20);
            ErrPhone.TabIndex = 47;
            ErrPhone.Text = "Phone Must Be 11 Number And Must Start with(010,011,012,015)";
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(205, 266);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 46;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(205, 174);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 45;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // UpdateIns
            // 
            UpdateIns.Location = new Point(576, 458);
            UpdateIns.Name = "UpdateIns";
            UpdateIns.Size = new Size(149, 29);
            UpdateIns.TabIndex = 44;
            UpdateIns.Text = "Update";
            UpdateIns.UseVisualStyleBackColor = true;
            UpdateIns.Click += UpdateIns_Click;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.Location = new Point(205, 304);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(470, 27);
            Lbl_Phone.TabIndex = 43;
            Lbl_Phone.TextChanged += Lbl_Phone_TextChanged;
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(205, 212);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 42;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(205, 132);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 41;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 307);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 40;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 212);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 39;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 135);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 38;
            label1.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 28);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 55;
            label7.Text = "Instructors";
            label7.Click += label7_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(205, 25);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 54;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // UpdateInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(Lbl_Dept);
            Controls.Add(label6);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(ErrPhone);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(UpdateIns);
            Controls.Add(Lbl_Phone);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateInstructor";
            Text = "UpdateInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox Lbl_Dept;
        private Label label6;
        private Button btnBack;
        private Label label4;
        private ComboBox comboBox1;
        private Label ErrPhone;
        private Label ErrLName;
        private Label ErrFName;
        private Button UpdateIns;
        private TextBox Lbl_Phone;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox comboBox2;
    }
}