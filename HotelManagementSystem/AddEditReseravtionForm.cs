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
    public partial class AddEditReseravtionForm : Form
    {
        private Home homeForm;
        private SqlConnection connection;
        private bool edit;

        public AddEditReseravtionForm(Home homeForm , bool edit)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.connection = this.homeForm.Connection;
            this.edit = edit;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = "Select id, num_of_beds from Room where status_id = 1";
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read()) 
            {
                room_combo.Items.Add(reader1.GetInt32(0).ToString()+" ("+reader1.GetInt32(1).ToString()+" beds)");
            }

            reader1.Close();

            cmd.CommandText = "Select id, first_name, last_name\n" +
                              "From Guest";

            reader1 = cmd.ExecuteReader();
            while (reader1.Read()) 
            {
                guest_combo.Items.Add(reader1.GetInt32(0).ToString() + " " + reader1.GetString(1) + " " + reader1.GetString(2));
            }

            reader1.Close();





            if (this.edit) {
                SqlCommand command = new SqlCommand();
                command.Connection = this.connection;
                command.CommandText = "Select *\n" +
                                      "From Reservation as r\n" +
                                      "Inner join\n"+
                                      "Guest as g\n"+
                                      "on r.guest_id = g.id\n"+
                                      "Where r.id = @ID";
                command.Parameters.AddWithValue("ID", this.homeForm.SelectedReservationID);
                SqlDataReader reader = command.ExecuteReader();
                
                reader.Read();




                guest_combo.Text = reader.GetInt32(1).ToString() + " " + reader.GetString(11) + " " + reader.GetString(12);
                room_combo.Text = reader.GetInt32(2).ToString();
                date_picker.Text = reader.GetDateTime(3).ToString();
                in_picker.Text = reader.GetDateTime(4).ToString();
                out_picker.Text = reader.GetDateTime(5).ToString();
                num_of_adults_text_box.Text = reader.GetInt32(6).ToString();
                num_of_chlidren_text_box.Text = reader.GetInt32(7).ToString();
                meal_text_box.Text = reader.GetString(8);
                price_text_box.Text = reader.GetDecimal(9).ToString();


                reader.Close();







            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.connection;

            if (edit)
            {
                command.CommandText = "Update Reservation \n" +
                                      "Set guest_id = @guest_id,\n" +
                                      "room_id = @room_id,\n" +
                                      "created = @created,\n" +
                                      "check_in = @check_in,\n" +
                                      "check_out = @check_out,\n" +
                                      "adults = @adults,\n" +
                                      "childrens = @childrens,\n" +
                                      "meal = @meal,\n" +
                                      "price = @price \n" +
                                      "Where id = @ID";
                command.Parameters.AddWithValue("ID",this.homeForm.SelectedReservationID);

            }
            else 
            {
                command.CommandText = "Insert into Reservation(guest_id, room_id, created, check_in, check_out, adults, childrens, meal, price) " +
                                    "Values(@guest_id, @room_id, @created, @check_in, @check_out, @adults, @childrens, @meal, @price)";
            }

            command.Parameters.AddWithValue("guest_id", Convert.ToInt32(guest_combo.Text.Substring(0,2)));
            command.Parameters.AddWithValue("room_id", Convert.ToInt32(room_combo.Text.Substring(0,room_combo.Text.IndexOf(" "))));
            command.Parameters.AddWithValue("created", DateTime.Parse(date_picker.Text));
            command.Parameters.AddWithValue("check_in", DateTime.Parse(in_picker.Text));
            command.Parameters.AddWithValue("check_out", DateTime.Parse(out_picker.Text));
            command.Parameters.AddWithValue("adults", Convert.ToInt32(num_of_adults_text_box.Text));
            command.Parameters.AddWithValue("childrens", Convert.ToInt32(num_of_chlidren_text_box.Text));
            command.Parameters.AddWithValue("meal", meal_text_box.Text);
            command.Parameters.AddWithValue("price", price_text_box.Text);

            int rows = command.ExecuteNonQuery();

            if (rows > 0)
            {
                if (this.edit)
                {
                

                    command.CommandText = "Update Room Set status_id=@sdi where id=@di";
                    command.Parameters.AddWithValue("di", Convert.ToInt32(room_combo.Text.Substring(0, room_combo.Text.IndexOf(" "))));
                    command.Parameters.AddWithValue("sdi", 2);
                    
                    int r = command.ExecuteNonQuery();
                    this.homeForm.InitializeRooms(null);
                    MessageBox.Show("Reservation is successfully edited ! " +r);

                }
                else
                {
                    command.CommandText = "Update Room Set status_id=@sdi where id=@di";
                    command.Parameters.AddWithValue("di", Convert.ToInt32(room_combo.Text.Substring(0, room_combo.Text.IndexOf(" "))));
                    command.Parameters.AddWithValue("sdi", 2);

                    int r = command.ExecuteNonQuery();
                    this.homeForm.InitializeRooms(null);
                    MessageBox.Show("Reservation is successfully inserted !"+ r);
                }

                guest_combo.Text = room_combo.Text = date_picker.Text = in_picker.Text = out_picker.Text = num_of_adults_text_box.Text = num_of_chlidren_text_box.Text = meal_text_box.Text = price_text_box.Text = "";
                this.homeForm.InitializeReservations(null);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Some error occurred, please try again ...");
            }

        }
    }
}
