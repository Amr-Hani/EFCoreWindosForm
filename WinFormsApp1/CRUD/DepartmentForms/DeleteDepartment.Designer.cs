namespace WinFormsApp1.CRUD.DepartmentForms
{
    partial class DeleteDepartment
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
            btnBack = new Button();
            DeleteDepartmnet = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 124);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 83;
            label4.Text = "Departments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 82;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(81, 299);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 85;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DeleteDepartmnet
            // 
            DeleteDepartmnet.Location = new Point(561, 309);
            DeleteDepartmnet.Name = "DeleteDepartmnet";
            DeleteDepartmnet.Size = new Size(149, 29);
            DeleteDepartmnet.TabIndex = 84;
            DeleteDepartmnet.Text = "Delete";
            DeleteDepartmnet.UseVisualStyleBackColor = true;
            DeleteDepartmnet.Click += DeleteDepartmnet_Click;
            // 
            // DeleteDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(DeleteDepartmnet);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Name = "DeleteDepartment";
            Text = "DeleteDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox1;
        private Button btnBack;
        private Button DeleteDepartmnet;
    }
}