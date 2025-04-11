namespace WinFormsApp1.CRUD.Student
{
    partial class DeleteStudent
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
            DeleteStud = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 83);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 23;
            label4.Text = "Students";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DeleteStud
            // 
            DeleteStud.Location = new Point(379, 179);
            DeleteStud.Name = "DeleteStud";
            DeleteStud.Size = new Size(94, 29);
            DeleteStud.TabIndex = 24;
            DeleteStud.Text = "Delete";
            DeleteStud.UseVisualStyleBackColor = true;
            DeleteStud.Click += DeleteStud_Click;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteStud);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Name = "DeleteStudent";
            Text = "DeleteStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox1;
        private Button DeleteStud;
    }
}