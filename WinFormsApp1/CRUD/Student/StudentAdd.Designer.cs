
namespace WinFormsApp1.CRUD.Student
{
    partial class StudentAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Lbl_Fname = new TextBox();
            Lbl_Lname = new TextBox();
            Lbl_Phone = new TextBox();
            button1 = new Button();
            ErrFName = new Label();
            ErrLName = new Label();
            ErrPhone = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 42);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 119);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 214);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // Lbl_Fname
            // 
            Lbl_Fname.Location = new Point(213, 39);
            Lbl_Fname.Name = "Lbl_Fname";
            Lbl_Fname.Size = new Size(470, 27);
            Lbl_Fname.TabIndex = 3;
            Lbl_Fname.TextChanged += Lbl_Fname_TextChanged;
            // 
            // Lbl_Lname
            // 
            Lbl_Lname.Location = new Point(213, 119);
            Lbl_Lname.Name = "Lbl_Lname";
            Lbl_Lname.Size = new Size(470, 27);
            Lbl_Lname.TabIndex = 4;
            Lbl_Lname.TextChanged += Lbl_Lname_TextChanged;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.Location = new Point(213, 211);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(470, 27);
            Lbl_Phone.TabIndex = 5;
            Lbl_Phone.TextChanged += Lbl_Phone_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(576, 367);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save_Click;
            // 
            // ErrFName
            // 
            ErrFName.AutoSize = true;
            ErrFName.ForeColor = Color.Red;
            ErrFName.Location = new Point(213, 81);
            ErrFName.Name = "ErrFName";
            ErrFName.Size = new Size(337, 20);
            ErrFName.TabIndex = 7;
            ErrFName.Text = "First Name Is requird And dosent contain Number";
            // 
            // ErrLName
            // 
            ErrLName.AutoSize = true;
            ErrLName.ForeColor = Color.Red;
            ErrLName.Location = new Point(213, 173);
            ErrLName.Name = "ErrLName";
            ErrLName.Size = new Size(349, 20);
            ErrLName.TabIndex = 8;
            ErrLName.Text = "Last Name Is Requierd And Dosent Contain number";
            // 
            // ErrPhone
            // 
            ErrPhone.AutoSize = true;
            ErrPhone.ForeColor = Color.Red;
            ErrPhone.Location = new Point(213, 264);
            ErrPhone.Name = "ErrPhone";
            ErrPhone.Size = new Size(434, 20);
            ErrPhone.TabIndex = 9;
            ErrPhone.Text = "Phone Must Be 11 Number And Must Start with(010,011,012,015)";
            // 
            // StudentAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrPhone);
            Controls.Add(ErrLName);
            Controls.Add(ErrFName);
            Controls.Add(button1);
            Controls.Add(Lbl_Phone);
            Controls.Add(Lbl_Lname);
            Controls.Add(Lbl_Fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentAdd";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

       
        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Lbl_Fname;
        private TextBox Lbl_Lname;
        private TextBox Lbl_Phone;
        private Button button1;
        private Label ErrFName;
        private Label ErrLName;
        private Label ErrPhone;
    }
}