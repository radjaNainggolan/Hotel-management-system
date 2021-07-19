using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AddEditRoomForm : Form
    {
        private SqlConnection connection;
        private Home form;
        private bool edit;
        public AddEditRoomForm(Home homeForm, bool edit)
        {
            this.form = homeForm;
            this.connection = this.form.Connection;
            this.edit = edit;
            InitializeComponent();

            if (edit == true) 
            {
                SqlCommand readCommand = new SqlCommand();
                readCommand.Connection = this.connection;
                readCommand.CommandText = "Select r.num_of_beds, s.name, t.name\n" +
                                         "From\n" +
                                         "Room as r\n" +
                                         "Inner join\n" +
                                         "Status as s\n" +
                                         "On r.status_id = s.id\n" +
                                         "Inner join\n" +
                                         "Type as t\n" +
                                         "On r.type_id = t.id\n"+
                                         "Where r.id = @ID";
                readCommand.Parameters.AddWithValue("ID", this.form.SelectedRoomID);
                SqlDataReader reader = readCommand.ExecuteReader();
                reader.Read();
                num_of_beds_text_box.Text = reader.GetInt32(0).ToString();
                room_status_combo.Text = reader.GetString(1);
                room_type_combo.Text = reader.GetString(2);
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.connection;


            if (this.edit)
            {
                command.CommandText = "Update Room " +
                                      "Set num_of_beds = @num_of_beds, \n"+
                                      "status_id = @status_id, \n"+
                                      "type_id = @type_id\n"+
                                      "Where id = @ID";
                command.Parameters.AddWithValue("ID", this.form.SelectedRoomID);
                

            }
            else 
            {
            
                command.CommandText = "Insert into Room (num_of_beds, status_id, type_id) " +
                                      "Values (@num_of_beds, @status_id, @type_id)";

                
            }

            command.Parameters.AddWithValue("num_of_beds", Convert.ToInt32(num_of_beds_text_box.Text));
            if (room_status_combo.Text == "Free")
            {
                command.Parameters.AddWithValue("status_id", 1);
            }
            else if (room_status_combo.Text == "Taken")
            {
                command.Parameters.AddWithValue("status_id", 2);
            }
            else
            {
                command.Parameters.AddWithValue("status_id", 3);
            }

            if (room_type_combo.Text == "Classic room")
            {
                command.Parameters.AddWithValue("type_id", 1);
            }
            else if (room_type_combo.Text == "Studio")
            {
                command.Parameters.AddWithValue("type_id", 2);
            }
            else if (room_type_combo.Text == "Suite")
            {
                command.Parameters.AddWithValue("type_id", 3);
            }
            else if (room_type_combo.Text == "President suite")
            {
                command.Parameters.AddWithValue("type_id", 4);
            }
            else if (room_type_combo.Text == "Apartment")
            {
                command.Parameters.AddWithValue("type_id", 5);
            }

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {

                if (this.edit)
                {
                    MessageBox.Show("Room successfully edited !");
                }
                else 
                {
                    MessageBox.Show("Room successfully inserted !");
                }

                num_of_beds_text_box.Text = room_status_combo.Text = room_type_combo.Text = "";
                this.form.InitializeRooms(null);
                this.Close();

            }
            else
            {
                MessageBox.Show("Some error occureed, please try again...");
            }

        }
    }
}
