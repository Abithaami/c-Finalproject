namespace finalproject.view
{
    partial class ExamForm
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
            dateTimePickerExamDate = new DateTimePicker();
            label1 = new Label();
            txtExamID = new TextBox();
            Examlabel = new Label();
            txtSubjectID = new ComboBox();
            dataGridViewExams = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtExamName = new TextBox();
            Subjectlabel = new Label();
            ENamelabel = new Label();
            label11 = new Label();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExams).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveBorder;
            mainpanel.Controls.Add(dateTimePickerExamDate);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(txtExamID);
            mainpanel.Controls.Add(Examlabel);
            mainpanel.Controls.Add(txtSubjectID);
            mainpanel.Controls.Add(dataGridViewExams);
            mainpanel.Controls.Add(btnDelete);
            mainpanel.Controls.Add(btnUpdate);
            mainpanel.Controls.Add(btnAdd);
            mainpanel.Controls.Add(txtExamName);
            mainpanel.Controls.Add(Subjectlabel);
            mainpanel.Controls.Add(ENamelabel);
            mainpanel.Controls.Add(label11);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1371, 745);
            mainpanel.TabIndex = 11;
            // 
            // dateTimePickerExamDate
            // 
            dateTimePickerExamDate.Location = new Point(247, 416);
            dateTimePickerExamDate.Name = "dateTimePickerExamDate";
            dateTimePickerExamDate.Size = new Size(250, 27);
            dateTimePickerExamDate.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 412);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 15;
            label1.Text = "Exam Date";
            // 
            // txtExamID
            // 
            txtExamID.Location = new Point(247, 150);
            txtExamID.Name = "txtExamID";
            txtExamID.Size = new Size(245, 27);
            txtExamID.TabIndex = 14;
            // 
            // Examlabel
            // 
            Examlabel.AutoSize = true;
            Examlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Examlabel.Location = new Point(72, 144);
            Examlabel.Name = "Examlabel";
            Examlabel.Size = new Size(102, 31);
            Examlabel.TabIndex = 13;
            Examlabel.Text = "Exam ID";
            // 
            // txtSubjectID
            // 
            txtSubjectID.FormattingEnabled = true;
            txtSubjectID.Location = new Point(247, 232);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(245, 28);
            txtSubjectID.TabIndex = 12;
            // 
            // dataGridViewExams
            // 
            dataGridViewExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExams.Location = new Point(696, 161);
            dataGridViewExams.Name = "dataGridViewExams";
            dataGridViewExams.RowHeadersWidth = 51;
            dataGridViewExams.Size = new Size(428, 136);
            dataGridViewExams.TabIndex = 11;
            dataGridViewExams.CellContentClick += dataGridViewExams_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(422, 534);
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
            btnUpdate.Location = new Point(247, 534);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(72, 534);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(247, 327);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(245, 27);
            txtExamName.TabIndex = 6;
            // 
            // Subjectlabel
            // 
            Subjectlabel.AutoSize = true;
            Subjectlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subjectlabel.Location = new Point(72, 232);
            Subjectlabel.Name = "Subjectlabel";
            Subjectlabel.Size = new Size(124, 31);
            Subjectlabel.TabIndex = 5;
            Subjectlabel.Text = "Subject ID";
            // 
            // ENamelabel
            // 
            ENamelabel.AutoSize = true;
            ENamelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ENamelabel.Location = new Point(72, 321);
            ENamelabel.Name = "ENamelabel";
            ENamelabel.Size = new Size(141, 31);
            ENamelabel.TabIndex = 4;
            ENamelabel.Text = "Exam Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 50);
            label11.Name = "label11";
            label11.Size = new Size(72, 31);
            label11.TabIndex = 3;
            label11.Text = "Exam";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 745);
            Controls.Add(mainpanel);
            Name = "ExamForm";
            Text = "ExamForm";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private TextBox txtExamID;
        private Label Examlabel;
        private ComboBox txtSubjectID;
        private DataGridView dataGridViewExams;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtExamName;
        private Label Subjectlabel;
        private Label ENamelabel;
        private Label label11;
        private DateTimePicker dateTimePickerExamDate;
        private Label label1;
    }
}