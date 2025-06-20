namespace finalproject.view
{
    partial class TimetableForm
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
            txtTime = new ComboBox();
            label1 = new Label();
            txtDay = new DateTimePicker();
            Timeslotlabel = new Label();
            txtRoom = new ComboBox();
            txtTimetableID = new TextBox();
            Timetablelabel = new Label();
            txtSubjectID = new ComboBox();
            dataGridViewTimetable = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            Subjectlabel = new Label();
            Roomlabel = new Label();
            label11 = new Label();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveBorder;
            mainpanel.Controls.Add(txtTime);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(txtDay);
            mainpanel.Controls.Add(Timeslotlabel);
            mainpanel.Controls.Add(txtRoom);
            mainpanel.Controls.Add(txtTimetableID);
            mainpanel.Controls.Add(Timetablelabel);
            mainpanel.Controls.Add(txtSubjectID);
            mainpanel.Controls.Add(dataGridViewTimetable);
            mainpanel.Controls.Add(btnDelete);
            mainpanel.Controls.Add(btnUpdate);
            mainpanel.Controls.Add(btnAdd);
            mainpanel.Controls.Add(Subjectlabel);
            mainpanel.Controls.Add(Roomlabel);
            mainpanel.Controls.Add(label11);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1368, 739);
            mainpanel.TabIndex = 13;
            // 
            // txtTime
            // 
            txtTime.FormattingEnabled = true;
            txtTime.Location = new Point(263, 459);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(212, 28);
            txtTime.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 453);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 18;
            label1.Text = "Time ";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(263, 379);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(212, 27);
            txtDay.TabIndex = 17;
            txtDay.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Timeslotlabel
            // 
            Timeslotlabel.AutoSize = true;
            Timeslotlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Timeslotlabel.Location = new Point(74, 375);
            Timeslotlabel.Name = "Timeslotlabel";
            Timeslotlabel.Size = new Size(55, 31);
            Timeslotlabel.TabIndex = 16;
            Timeslotlabel.Text = "Day";
            // 
            // txtRoom
            // 
            txtRoom.FormattingEnabled = true;
            txtRoom.Location = new Point(263, 303);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(212, 28);
            txtRoom.TabIndex = 15;
            // 
            // txtTimetableID
            // 
            txtTimetableID.Location = new Point(263, 150);
            txtTimetableID.Name = "txtTimetableID";
            txtTimetableID.Size = new Size(212, 27);
            txtTimetableID.TabIndex = 14;
            // 
            // Timetablelabel
            // 
            Timetablelabel.AutoSize = true;
            Timetablelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Timetablelabel.Location = new Point(74, 144);
            Timetablelabel.Name = "Timetablelabel";
            Timetablelabel.Size = new Size(151, 31);
            Timetablelabel.TabIndex = 13;
            Timetablelabel.Text = "Timetable ID";
            // 
            // txtSubjectID
            // 
            txtSubjectID.FormattingEnabled = true;
            txtSubjectID.Location = new Point(263, 232);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(212, 28);
            txtSubjectID.TabIndex = 12;
            // 
            // dataGridViewTimetable
            // 
            dataGridViewTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetable.Location = new Point(560, 150);
            dataGridViewTimetable.Name = "dataGridViewTimetable";
            dataGridViewTimetable.RowHeadersWidth = 51;
            dataGridViewTimetable.Size = new Size(429, 136);
            dataGridViewTimetable.TabIndex = 11;
            dataGridViewTimetable.CellContentClick += dataGridViewTimetable_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(467, 561);
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
            btnUpdate.Location = new Point(275, 561);
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
            btnAdd.Location = new Point(74, 561);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Subjectlabel
            // 
            Subjectlabel.AutoSize = true;
            Subjectlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subjectlabel.Location = new Point(74, 226);
            Subjectlabel.Name = "Subjectlabel";
            Subjectlabel.Size = new Size(124, 31);
            Subjectlabel.TabIndex = 5;
            Subjectlabel.Text = "Subject ID";
            // 
            // Roomlabel
            // 
            Roomlabel.AutoSize = true;
            Roomlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Roomlabel.Location = new Point(74, 297);
            Roomlabel.Name = "Roomlabel";
            Roomlabel.Size = new Size(77, 31);
            Roomlabel.TabIndex = 4;
            Roomlabel.Text = "Room";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 50);
            label11.Name = "label11";
            label11.Size = new Size(129, 31);
            label11.TabIndex = 3;
            label11.Text = "Time Table";
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 739);
            Controls.Add(mainpanel);
            Name = "TimetableForm";
            Text = "TimetableForm";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private ComboBox txtRoom;
        private TextBox txtTimetableID;
        private Label Timetablelabel;
        private ComboBox txtSubjectID;
        private DataGridView dataGridViewTimetable;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label Subjectlabel;
        private Label Roomlabel;
        private Label label11;
        private DateTimePicker txtDay;
        private Label Timeslotlabel;
        private ComboBox txtTime;
        private Label label1;
    }
}