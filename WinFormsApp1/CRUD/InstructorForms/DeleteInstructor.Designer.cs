namespace WinFormsApp1.CRUD.InstructorForms
{
    partial class DeleteInstructor
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
            label7 = new Label();
            comboBox2 = new ComboBox();
            btnBack = new Button();
            DeleteIns = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 95);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 57;
            label7.Text = "Instructors";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(232, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(470, 28);
            comboBox2.TabIndex = 56;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(108, 214);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 59;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DeleteIns
            // 
            DeleteIns.Location = new Point(553, 214);
            DeleteIns.Name = "DeleteIns";
            DeleteIns.Size = new Size(149, 29);
            DeleteIns.TabIndex = 58;
            DeleteIns.Text = "Delete";
            DeleteIns.UseVisualStyleBackColor = true;
            DeleteIns.Click += DeleteIns_Click;
            // 
            // DeleteInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(DeleteIns);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Name = "DeleteInstructor";
            Text = "DeleteInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox comboBox2;
        private Button btnBack;
        private Button DeleteIns;
    }
}