namespace finalproject.view
{
    partial class SubjectForm
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
            mainpanel = new Panel();
            txtSubjectID = new TextBox();
            label1 = new Label();
            txtCourseName = new ComboBox();
            dataGridViewSubjects = new DataGridView();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            txtSubjectName = new TextBox();
            CNamelabel = new Label();
            SNamelabel = new Label();
            label11 = new Label();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveBorder;
            mainpanel.Controls.Add(txtSubjectID);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(txtCourseName);
            mainpanel.Controls.Add(dataGridViewSubjects);
            mainpanel.Controls.Add(delete_btn);
            mainpanel.Controls.Add(update_btn);
            mainpanel.Controls.Add(add_btn);
            mainpanel.Controls.Add(txtSubjectName);
            mainpanel.Controls.Add(CNamelabel);
            mainpanel.Controls.Add(SNamelabel);
            mainpanel.Controls.Add(label11);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1368, 744);
            mainpanel.TabIndex = 9;
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(322, 161);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(265, 27);
            txtSubjectID.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 161);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 13;
            label1.Text = "Subject ID";
            // 
            // txtCourseName
            // 
            txtCourseName.FormattingEnabled = true;
            txtCourseName.Location = new Point(322, 316);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(265, 28);
            txtCourseName.TabIndex = 12;
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Location = new Point(680, 161);
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.RowHeadersWidth = 51;
            dataGridViewSubjects.Size = new Size(428, 136);
            dataGridViewSubjects.TabIndex = 11;
            dataGridViewSubjects.CellContentClick += dataGridViewSubjects_CellContentClick;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Black;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(451, 441);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(136, 42);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Black;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(278, 441);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(136, 42);
            update_btn.TabIndex = 9;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Black;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(100, 441);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(136, 42);
            add_btn.TabIndex = 8;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(322, 240);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(265, 27);
            txtSubjectName.TabIndex = 6;
            // 
            // CNamelabel
            // 
            CNamelabel.AutoSize = true;
            CNamelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CNamelabel.Location = new Point(100, 316);
            CNamelabel.Name = "CNamelabel";
            CNamelabel.Size = new Size(156, 31);
            CNamelabel.TabIndex = 5;
            CNamelabel.Text = "Course Name";
            // 
            // SNamelabel
            // 
            SNamelabel.AutoSize = true;
            SNamelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SNamelabel.Location = new Point(100, 236);
            SNamelabel.Name = "SNamelabel";
            SNamelabel.Size = new Size(163, 31);
            SNamelabel.TabIndex = 4;
            SNamelabel.Text = "Subject Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 50);
            label11.Name = "label11";
            label11.Size = new Size(104, 31);
            label11.TabIndex = 3;
            label11.Text = "Subjects";
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 744);
            Controls.Add(mainpanel);
            Name = "SubjectForm";
            Text = "SubjectForm";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private ComboBox txtCourseName;
        private DataGridView dataGridViewSubjects;
        private Button delete_btn;
        private Button update_btn;
        private Button add_btn;
        private TextBox txtSubjectName;
        private Label CNamelabel;
        private Label SNamelabel;
        private Label label11;
        private Label label1;
        private TextBox txtSubjectID;
    }
}