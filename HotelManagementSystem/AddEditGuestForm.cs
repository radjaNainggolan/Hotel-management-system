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
    public partial class AddEditGuestForm : Form
    {

        private Home homeForm;
        private SqlConnection connection;
        private bool edit;

        public AddEditGuestForm(Home homeForm, bool edit)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.connection = this.homeForm.Connection;
            this.edit = edit;

            if (this.edit) 
            {
                SqlCommand readCommand = new SqlCommand();
                readCommand.Connection = this.connection;
                readCommand.CommandText = "Select * \n" +
                                          "From \n" +
                                          "Guest\n"+
                                          "Where Guest.id = @ID";
                readCommand.Parameters.AddWithValue("ID", this.homeForm.SelectedGuestID);
                SqlDataReader reader = readCommand.ExecuteReader();
                reader.Read();
                first_name_text_box.Text = reader.GetString(1);
                last_name_text_box.Text = reader.GetString(2);
                email_text_box.Text = reader.GetString(3);
                phone_text_box.Text = reader.GetString(4);
                adress_text_box.Text = reader.GetString(5);
                city_text_box.Text = reader.GetString(6);
                country_text_box.Text = reader.GetString(7);

                reader.Close();


            }


        }

        private void Submit_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = this.connection;

            if (edit)
            {
                command.CommandText = "Update Guest\n" +
                                      "Set first_name = @first_name,\n" +
                                      "last_name = @last_name,\n" +
                                      "email = @email,\n" +
                                      "phone = @phone,\n" +
                                      "adress = @adress,\n" +
                                      "city = @city,\n" +
                                      "country = @country\n" +
                                      "Where id = @ID";
                command.Parameters.AddWithValue("ID", this.homeForm.SelectedGuestID);
            }
            else 
            {
                command.CommandText = "Insert into Guest(first_name, last_name, email, phone, adress, city, country)\n" +
                                      "Values (@first_name, @last_name,@email, @phone, @adress, @city, @country)";
            }

            command.Parameters.AddWithValue("first_name", first_name_text_box.Text);
            command.Parameters.AddWithValue("last_name", last_name_text_box.Text);
            command.Parameters.AddWithValue("email", email_text_box.Text);
            command.Parameters.AddWithValue("phone", phone_text_box.Text);
            command.Parameters.AddWithValue("adress", adress_text_box.Text);
            command.Parameters.AddWithValue("city", city_text_box.Text);
            command.Parameters.AddWithValue("country", country_text_box.Text);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                if (edit)
                {
                    MessageBox.Show("Guest successfully edited !");


                }
                else
                {
                    MessageBox.Show("Guest successfully isnerted !");
                }

                first_name_text_box.Text = last_name_text_box.Text = email_text_box.Text = phone_text_box.Text = adress_text_box.Text = city_text_box.Text = country_text_box.Text = "";
                this.homeForm.InitializeGuests(null);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Some error occurred, please try again ...");
            }


        }
    }
}
