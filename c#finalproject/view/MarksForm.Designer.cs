namespace finalproject.view
{
    partial class MarksForm
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
            txtMarkID = new TextBox();
            label1 = new Label();
            txtExamID = new ComboBox();
            Examlabel = new Label();
            txtStudentID = new ComboBox();
            dataGridViewMarks = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtMarksObtained = new TextBox();
            Studentlabel = new Label();
            Markslabel = new Label();
            label11 = new Label();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarks).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveBorder;
            mainpanel.Controls.Add(txtMarkID);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(txtExamID);
            mainpanel.Controls.Add(Examlabel);
            mainpanel.Controls.Add(txtStudentID);
            mainpanel.Controls.Add(dataGridViewMarks);
            mainpanel.Controls.Add(btnDelete);
            mainpanel.Controls.Add(btnUpdate);
            mainpanel.Controls.Add(btnAdd);
            mainpanel.Controls.Add(txtMarksObtained);
            mainpanel.Controls.Add(Studentlabel);
            mainpanel.Controls.Add(Markslabel);
            mainpanel.Controls.Add(label11);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1372, 741);
            mainpanel.TabIndex = 12;
            // 
            // txtMarkID
            // 
            txtMarkID.Location = new Point(316, 178);
            txtMarkID.Name = "txtMarkID";
            txtMarkID.Size = new Size(249, 27);
            txtMarkID.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 174);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 16;
            label1.Text = "Mark ID";
            // 
            // txtExamID
            // 
            txtExamID.DropDownStyle = ComboBoxStyle.DropDownList;
            txtExamID.FormattingEnabled = true;
            txtExamID.Location = new Point(316, 273);
            txtExamID.Name = "txtExamID";
            txtExamID.Size = new Size(249, 28);
            txtExamID.TabIndex = 15;
            // 
            // Examlabel
            // 
            Examlabel.AutoSize = true;
            Examlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Examlabel.Location = new Point(81, 267);
            Examlabel.Name = "Examlabel";
            Examlabel.Size = new Size(102, 31);
            Examlabel.TabIndex = 13;
            Examlabel.Text = "Exam ID";
            // 
            // txtStudentID
            // 
            txtStudentID.FormattingEnabled = true;
            txtStudentID.Location = new Point(316, 358);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(249, 28);
            txtStudentID.TabIndex = 12;
            // 
            // dataGridViewMarks
            // 
            dataGridViewMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarks.Location = new Point(661, 221);
            dataGridViewMarks.Name = "dataGridViewMarks";
            dataGridViewMarks.RowHeadersWidth = 51;
            dataGridViewMarks.Size = new Size(428, 136);
            dataGridViewMarks.TabIndex = 11;
            dataGridViewMarks.CellContentClick += dataGridViewMarks_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(429, 549);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 42);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(254, 549);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += update_btn_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(81, 549);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMarksObtained
            // 
            txtMarksObtained.Location = new Point(316, 443);
            txtMarksObtained.Name = "txtMarksObtained";
            txtMarksObtained.Size = new Size(249, 27);
            txtMarksObtained.TabIndex = 6;
            // 
            // Studentlabel
            // 
            Studentlabel.AutoSize = true;
            Studentlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Studentlabel.Location = new Point(81, 355);
            Studentlabel.Name = "Studentlabel";
            Studentlabel.Size = new Size(128, 31);
            Studentlabel.TabIndex = 5;
            Studentlabel.Text = "Student ID";
            // 
            // Markslabel
            // 
            Markslabel.AutoSize = true;
            Markslabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Markslabel.Location = new Point(81, 443);
            Markslabel.Name = "Markslabel";
            Markslabel.Size = new Size(185, 31);
            Markslabel.TabIndex = 4;
            Markslabel.Text = "Marks Obtained";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 50);
            label11.Name = "label11";
            label11.Size = new Size(80, 31);
            label11.TabIndex = 3;
            label11.Text = "Marks";
            // 
            // MarksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 741);
            Controls.Add(mainpanel);
            Name = "MarksForm";
            Text = "MarksForm";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private ComboBox txtExamID;
        private Label Examlabel;
        private ComboBox txtStudentID;
        private DataGridView dataGridViewMarks;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtMarksObtained;
        private Label Studentlabel;
        private Label Markslabel;
        private Label label11;
        private TextBox txtMarkID;
        private Label label1;
    }
}