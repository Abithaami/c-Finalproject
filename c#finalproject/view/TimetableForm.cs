using c_finalproject;
using c_finalproject.controller;
using c_finalproject.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproject.view
{
    public partial class TimetableForm : Form
    {
        private timetablecontroller controller = new timetablecontroller();

        public TimetableForm()
        {
            InitializeComponent();
            LoadtimetableToComboBox();
            LoadRoomComboBox();
            LoadTimetables();
            LoadTimeSlotsToComboBox();
        }
        private roomcontroller rController = new roomcontroller();
        private void LoadRoomComboBox()
        {
            var rooms = rController.GetRoomsForComboBox();
            txtRoom.DataSource = rooms;
            txtRoom.DisplayMember = "RoomType";   // Or "RoomID", or combine using ToString()
            txtRoom.ValueMember = "RoomID";
        }
        private void LoadTimetables()
        {
            List<Timetable> timetables = controller.GetAllTimetables();
            dataGridViewTimetable.DataSource = timetables;
        }

        private void LoadtimetableToComboBox()
        {
            using (var conn = dbconfig.getConnection())
            {
                conn.Open();
                string query = "SELECT SubjectID FROM Subjects";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new System.Data.DataTable();
                    dt.Load(reader);

                    txtSubjectID.DisplayMember = "SubjectID";  // What user sees
                    txtSubjectID.ValueMember = "SubjectID";      // The actual value you want to save
                    txtSubjectID.DataSource = dt;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Timetable timetable = new Timetable()
            {
                SubjectID = txtSubjectID.Text,
                RoomID= txtRoom.Text,
                Day = txtDay.Text,
                TimeSlot = txtTime.Text
            };

            if (controller.AddTimetable(timetable))
            {
                MessageBox.Show("Timetable added successfully.");
                LoadTimetables();
            }
            else
            {
                MessageBox.Show("Error adding timetable.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimetableID.Text, out int id))
            {
                Timetable timetable = new Timetable()
                {
                    TimetableID = id,
                    SubjectID = txtSubjectID.Text,
                    RoomID = txtRoom.Text,
                    Day = txtDay.Text,
                    TimeSlot = txtTime.Text
                };

                if (controller.UpdateTimetable(timetable))
                {
                    MessageBox.Show("Timetable updated successfully.");
                    LoadTimetables();
                }
                else
                {
                    MessageBox.Show("Error updating timetable.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimetableID.Text, out int id))
            {
                if (controller.DeleteTimetable(id))
                {
                    MessageBox.Show("Timetable deleted successfully.");
                    LoadTimetables();
                }
                else
                {
                    MessageBox.Show("Error deleting timetable.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid timetable to delete.");
            }
        }

        private void dataGridViewTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTimetable.Rows[e.RowIndex];
                txtTimetableID.Text = row.Cells["TimetableID"].Value.ToString();
                txtSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
                txtRoom.Text = row.Cells["Room"].Value.ToString();
                txtDay.Text = row.Cells["Day"].Value.ToString();
                txtTime.Text = row.Cells["Time"].Value.ToString();
            }
        }

        private void LoadTimeSlotsToComboBox()
        {
            txtTime.Items.Clear(); // Clear existing items

            txtTime.Items.Add("9.00am to 12.00pm");
            txtTime.Items.Add("12.00pm to 4.00pm");

            txtTime.SelectedIndex = -1; // Optional: no default selection
        }
        
    }
}
