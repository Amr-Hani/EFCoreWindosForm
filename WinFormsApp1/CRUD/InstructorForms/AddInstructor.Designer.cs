namespace WinFormsApp1.CRUD.InstructorForms
{
    partial class AddInstructor
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
            ErrPhone = new Label();
            ErrLName = new Label();
            ErrFName = new Label();
            AddIns = new Button();
            Lbl_Phone = new TextBox();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            label5 = new Label();
            Lbl_Dept = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 35);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 33;
            label4.Text = "Departments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 32;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ErrPhone
            // 
            ErrPhone.AutoSize = true;
            ErrPhone.ForeColor = Color.Red;
            ErrPhone.Location = new Point(206, 308);
            ErrPhone.Name = "ErrPhone";
            ErrPhone.Size = new Size(434, 20);
            ErrPhone.TabIndex = 31;
            ErrPhone.Text = "Phone Must Be 11 Number And Must Start with(010,011,012,015)";
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(206, 217);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 30;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(206, 125);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 29;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // AddIns
            // 
            AddIns.Location = new Point(577, 409);
            AddIns.Name = "AddIns";
            AddIns.Size = new Size(149, 29);
            AddIns.TabIndex = 28;
            AddIns.Text = "Add";
            AddIns.UseVisualStyleBackColor = true;
            AddIns.Click += AddIns_Click;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.Location = new Point(206, 255);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(470, 27);
            Lbl_Phone.TabIndex = 27;
            Lbl_Phone.TextChanged += Lbl_Phone_TextChanged;
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(206, 163);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 26;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(206, 83);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 25;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 258);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 24;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 163);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 23;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 86);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 22;
            label1.Text = "First Name";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(77, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(206, 398);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 37;
            // 
            // Lbl_Dept
            // 
            Lbl_Dept.Location = new Point(206, 345);
            Lbl_Dept.Name = "Lbl_Dept";
            Lbl_Dept.Size = new Size(470, 27);
            Lbl_Dept.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 348);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 35;
            label6.Text = "Department";
            // 
            // AddInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(label5);
            Controls.Add(Lbl_Dept);
            Controls.Add(label6);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(ErrPhone);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(AddIns);
            Controls.Add(Lbl_Phone);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInstructor";
            Text = "AddInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox1;
        private Label ErrPhone;
        private Label ErrLName;
        private Label ErrFName;
        private Button AddIns;
        private TextBox Lbl_Phone;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Label label5;
        private TextBox Lbl_Dept;
        private Label label6;
    }
}