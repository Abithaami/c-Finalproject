namespace finalproject.view
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
            mainpanel = new Panel();
            studentNameTextBox = new TextBox();
            Studentlabel = new Label();
            courseIdTextBox = new ComboBox();
            dataGridView1 = new DataGridView();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            Stnametext = new TextBox();
            Courselabel = new Label();
            StNamelabel = new Label();
            label11 = new Label();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveBorder;
            mainpanel.Controls.Add(studentNameTextBox);
            mainpanel.Controls.Add(Studentlabel);
            mainpanel.Controls.Add(courseIdTextBox);
            mainpanel.Controls.Add(dataGridView1);
            mainpanel.Controls.Add(delete_btn);
            mainpanel.Controls.Add(update_btn);
            mainpanel.Controls.Add(add_btn);
            mainpanel.Controls.Add(Stnametext);
            mainpanel.Controls.Add(Courselabel);
            mainpanel.Controls.Add(StNamelabel);
            mainpanel.Controls.Add(label11);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1372, 741);
            mainpanel.TabIndex = 10;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(316, 144);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(312, 27);
            studentNameTextBox.TabIndex = 14;
            // 
            // Studentlabel
            // 
            Studentlabel.AutoSize = true;
            Studentlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Studentlabel.Location = new Point(107, 144);
            Studentlabel.Name = "Studentlabel";
            Studentlabel.Size = new Size(128, 31);
            Studentlabel.TabIndex = 13;
            Studentlabel.Text = "Student ID";
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.FormattingEnabled = true;
            courseIdTextBox.Location = new Point(316, 309);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(312, 28);
            courseIdTextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(664, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 136);
            dataGridView1.TabIndex = 11;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Black;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(492, 422);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(136, 42);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = false;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Black;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(298, 422);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(136, 42);
            update_btn.TabIndex = 9;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Black;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(107, 422);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(136, 42);
            add_btn.TabIndex = 8;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // Stnametext
            // 
            Stnametext.Location = new Point(316, 223);
            Stnametext.Name = "Stnametext";
            Stnametext.Size = new Size(312, 27);
            Stnametext.TabIndex = 6;
            // 
            // Courselabel
            // 
            Courselabel.AutoSize = true;
            Courselabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Courselabel.Location = new Point(107, 306);
            Courselabel.Name = "Courselabel";
            Courselabel.Size = new Size(117, 31);
            Courselabel.TabIndex = 5;
            Courselabel.Text = "Course ID";
            // 
            // StNamelabel
            // 
            StNamelabel.AutoSize = true;
            StNamelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StNamelabel.Location = new Point(107, 217);
            StNamelabel.Name = "StNamelabel";
            StNamelabel.Size = new Size(167, 31);
            StNamelabel.TabIndex = 4;
            StNamelabel.Text = "Student Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 50);
            label11.Name = "label11";
            label11.Size = new Size(108, 31);
            label11.TabIndex = 3;
            label11.Text = "Students";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 741);
            Controls.Add(mainpanel);
            Name = "StudentForm";
            Text = "StudentForm";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private TextBox studentNameTextBox;
        private Label Studentlabel;
        private ComboBox courseIdTextBox;
        private DataGridView dataGridView1;
        private Button delete_btn;
        private Button update_btn;
        private Button add_btn;
        private TextBox Stnametext;
        private Label Courselabel;
        private Label StNamelabel;
        private Label label11;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn CourseID;
    }
}