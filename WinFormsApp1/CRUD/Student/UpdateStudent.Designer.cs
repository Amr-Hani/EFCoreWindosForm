namespace WinFormsApp1.CRUD.Student
{
    partial class UpdateStudent
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
            ErrPhone = new Label();
            ErrLName = new Label();
            ErrFName = new Label();
            UpdateStude = new Button();
            Lbl_Phone = new TextBox();
            Lbl_Lname = new TextBox();
            Lbl_Fname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // ErrPhone
            // 
            ErrPhone.AutoSize = true;
            ErrPhone.ForeColor = Color.Red;
            ErrPhone.Location = new Point(212, 299);
            ErrPhone.Name = "ErrPhone";
            ErrPhone.Size = new Size(434, 20);
            ErrPhone.TabIndex = 19;
            ErrPhone.Text = "Phone Must Be 11 Number And Must Start with(010,011,012,015)";
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(212, 208);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 18;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(212, 116);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 17;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // UpdateStude
            // 
            UpdateStude.Location = new Point(575, 381);
            UpdateStude.Name = "UpdateStude";
            UpdateStude.Size = new Size(149, 29);
            UpdateStude.TabIndex = 16;
            UpdateStude.Text = "Update";
            UpdateStude.UseVisualStyleBackColor = true;
            UpdateStude.Click += UpdateStude_Click;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.Location = new Point(212, 246);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(470, 27);
            Lbl_Phone.TabIndex = 15;
            Lbl_Phone.TextChanged += Lbl_Phone_TextChanged;
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(212, 154);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 14;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(212, 74);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 13;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 249);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 154);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 77);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 26);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 21;
            label4.Text = "Students";
            label4.Click += label4_Click;
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(ErrPhone);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(UpdateStude);
            Controls.Add(Lbl_Phone);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateStudent";
            Text = "UpdateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrPhone;
        private Label ErrLName;
        private Label ErrFName;
        private Button UpdateStude;
        private TextBox Lbl_Phone;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Fname;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
    }
}