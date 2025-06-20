using c_finalproject.controller;
using c_finalproject.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace c_finalproject.view
{
    public partial class RoomForm : Form
    {
        private readonly roomcontroller controller = new roomcontroller();

        public RoomForm()
        {
            InitializeComponent();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            dataGridView1.DataSource = controller.GetAllRooms();
        }

        private void ClearFields()
        {
            txtRoomID.Clear();
            txtRoomType.Clear();
            txtRoomID.Focus();
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            var r = new room(txtRoomID.Text, txtRoomType.Text);
            if (controller.AddRoom(r))
            {
                MessageBox.Show("Room added successfully.");
                LoadRoomData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add room.");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var r = new room(txtRoomID.Text, txtRoomType.Text);
            if (controller.UpdateRoom(r))
            {
                MessageBox.Show("Room updated successfully.");
                LoadRoomData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update room.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string id = txtRoomID.Text;
            if (controller.DeleteRoom(id))
            {
                MessageBox.Show("Room deleted successfully.");
                LoadRoomData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to delete room.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtRoomID.Text = row.Cells["RoomID"].Value.ToString();
                txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
            }
        }
    }

}
