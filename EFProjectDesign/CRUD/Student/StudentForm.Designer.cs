



namespace EFProjectDesign.CRUD.Student
{
    partial class StudentForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            showStudent = new Button();
            FName = new TextBox();
            LName = new TextBox();
            Phone = new TextBox();
            saveAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            saveDelete = new Button();
            saveUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(665, 394);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addStudent_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 150);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += updateStudent_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 210);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += deleteStudent_Click;
            // 
            // showStudent
            // 
            showStudent.Location = new Point(12, 37);
            showStudent.Name = "showStudent";
            showStudent.Size = new Size(94, 29);
            showStudent.TabIndex = 6;
            showStudent.Text = "Show";
            showStudent.UseVisualStyleBackColor = true;
            showStudent.Click += bshowStudent_Click;
            // 
            // FName
            // 
            FName.Location = new Point(339, 88);
            FName.Name = "FName";
            FName.Size = new Size(241, 27);
            FName.TabIndex = 7;
            // 
            // LName
            // 
            LName.Location = new Point(339, 139);
            LName.Name = "LName";
            LName.Size = new Size(241, 27);
            LName.TabIndex = 8;
            // 
            // Phone
            // 
            Phone.Location = new Point(339, 189);
            Phone.Name = "Phone";
            Phone.Size = new Size(241, 27);
            Phone.TabIndex = 9;
            // 
            // saveAdd
            // 
            saveAdd.Location = new Point(401, 241);
            saveAdd.Name = "saveAdd";
            saveAdd.Size = new Size(94, 29);
            saveAdd.TabIndex = 11;
            saveAdd.Text = "SaveAdd";
            saveAdd.UseVisualStyleBackColor = true;
            saveAdd.Click += saveAdd_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 90);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 12;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 143);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 13;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 192);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 14;
            label3.Text = "Phone";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 28);
            comboBox1.TabIndex = 15;
            // 
            // saveDelete
            // 
            saveDelete.Location = new Point(401, 241);
            saveDelete.Name = "saveDelete";
            saveDelete.Size = new Size(94, 29);
            saveDelete.TabIndex = 16;
            saveDelete.Text = "SaveDelete";
            saveDelete.UseVisualStyleBackColor = true;
            saveDelete.Click += saveDelete_Click_1;
            // 
            // saveUpdate
            // 
            saveUpdate.Location = new Point(401, 241);
            saveUpdate.Name = "saveUpdate";
            saveUpdate.Size = new Size(94, 29);
            saveUpdate.TabIndex = 17;
            saveUpdate.Text = "SaveUpdate";
            saveUpdate.UseVisualStyleBackColor = true;
            saveUpdate.Click += saveUpdate_Click_1;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveUpdate);
            Controls.Add(saveDelete);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveAdd);
            Controls.Add(Phone);
            Controls.Add(LName);
            Controls.Add(FName);
            Controls.Add(showStudent);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "StudentForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button showStudent;
        private TextBox FName;
        private TextBox LName;
        private TextBox Phone;
        private Button saveAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button saveDelete;
        private Button saveUpdate;
    }
}