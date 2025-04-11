namespace WinFormsApp1.CRUD.DepartmentForms
{
    partial class UpdateDepartment
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
            UpdateDepartmnet = new Button();
            ErrLName = new Label();
            ErrFName = new Label();
            Lbl_Phone = new TextBox();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(82, 350);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 79;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // UpdateDepartmnet
            // 
            UpdateDepartmnet.Location = new Point(582, 361);
            UpdateDepartmnet.Name = "UpdateDepartmnet";
            UpdateDepartmnet.Size = new Size(149, 29);
            UpdateDepartmnet.TabIndex = 78;
            UpdateDepartmnet.Text = "Update";
            UpdateDepartmnet.UseVisualStyleBackColor = true;
            UpdateDepartmnet.Click += UpdateDepartmnet_Click;
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(219, 245);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 77;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(219, 153);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 76;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.Enabled = false;
            Lbl_Phone.Location = new Point(219, 283);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(470, 27);
            Lbl_Phone.TabIndex = 75;
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(219, 191);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 74;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(219, 111);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 73;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 286);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 72;
            label3.Text = "Manger Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 191);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 71;
            label2.Text = "Department Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 114);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 70;
            label1.Text = "Department Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 63);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 69;
            label7.Text = "Instructors";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(219, 60);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 68;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 15);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 81;
            label4.Text = "Departments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 80;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UpdateDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(btnBack);
            Controls.Add(UpdateDepartmnet);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(Lbl_Phone);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Name = "UpdateDepartment";
            Text = "UpdateDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button UpdateDepartmnet;
        private Label ErrLName;
        private Label ErrFName;
        private TextBox Lbl_Phone;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
    }
}