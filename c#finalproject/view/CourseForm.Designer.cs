namespace finalproject.view
{
    partial class CourseForm
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
            dataGridViewCourses = new DataGridView();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            courseNameTextBox = new TextBox();
            courseIdTextBox = new TextBox();
            CNamelabel = new Label();
            Courselabel = new Label();
            label11 = new Label();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveBorder;
            mainpanel.Controls.Add(dataGridViewCourses);
            mainpanel.Controls.Add(delete_btn);
            mainpanel.Controls.Add(update_btn);
            mainpanel.Controls.Add(add_btn);
            mainpanel.Controls.Add(courseNameTextBox);
            mainpanel.Controls.Add(courseIdTextBox);
            mainpanel.Controls.Add(CNamelabel);
            mainpanel.Controls.Add(Courselabel);
            mainpanel.Controls.Add(label11);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1366, 746);
            mainpanel.TabIndex = 8;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(641, 167);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.Size = new Size(558, 225);
            dataGridViewCourses.TabIndex = 11;
            dataGridViewCourses.CellContentClick += dataGridViewCourses_CellContentClick_1;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Black;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(423, 392);
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
            update_btn.Location = new Point(246, 392);
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
            add_btn.Location = new Point(75, 392);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(136, 42);
            add_btn.TabIndex = 8;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(255, 278);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(304, 27);
            courseNameTextBox.TabIndex = 7;
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Location = new Point(255, 176);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(304, 27);
            courseIdTextBox.TabIndex = 6;
            // 
            // CNamelabel
            // 
            CNamelabel.AutoSize = true;
            CNamelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CNamelabel.Location = new Point(75, 272);
            CNamelabel.Name = "CNamelabel";
            CNamelabel.Size = new Size(156, 31);
            CNamelabel.TabIndex = 5;
            CNamelabel.Text = "Course Name";
            // 
            // Courselabel
            // 
            Courselabel.AutoSize = true;
            Courselabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Courselabel.Location = new Point(75, 176);
            Courselabel.Name = "Courselabel";
            Courselabel.Size = new Size(117, 31);
            Courselabel.TabIndex = 4;
            Courselabel.Text = "Course ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 50);
            label11.Name = "label11";
            label11.Size = new Size(97, 31);
            label11.TabIndex = 3;
            label11.Text = "Courses";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 746);
            Controls.Add(mainpanel);
            Name = "CourseForm";
            Text = "CourseForm";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Label CNamelabel;
        private Label Courselabel;
        private Label label11;
        private Button add_btn;
        private TextBox courseNameTextBox;
        private TextBox courseIdTextBox;
        private Button delete_btn;
        private Button update_btn;
        private DataGridView dataGridViewCourses;
    }
}