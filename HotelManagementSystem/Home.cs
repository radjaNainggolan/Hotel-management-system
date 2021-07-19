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
    public partial class Home : Form
    {
        private SqlConnection connection;

        public SqlConnection Connection 
        {
            get { return this.connection; }
        }

       

        private int selectedRoomID = -1;

        public int SelectedRoomID 
        {
            get { return this.selectedRoomID; }
        }

        private int selectedGuestID = -1;

        public int SelectedGuestID
        {
            get { return this.selectedGuestID; }
        }

        private int selectedReservationID = -1;

        public int SelectedReservationID
        { 
            get { return this.selectedReservationID; } 
        }

        public Home()
        {
            InitializeComponent();
            this.rooms_data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.rooms_search.TextChanged += Search_text_box_TextChanged;
            this.guest_search.TextChanged += Guest_search_TextChanged;
            this.reservation_search.TextChanged += Reservation_search_TextChanged;
            
            this.rooms_data_grid.CellClick += Rooms_data_grid_CellClick;
            this.guests_data_grid.CellClick += Guests_data_grid_CellClick;
            this.reservation_data_grid.CellClick += Reservation_data_grid_CellClick;
            
            InitializeConnection();
            InitializeRooms(null);
            InitializeGuests(null);
            InitializeReservations(null);
        }

        private void Reservation_search_TextChanged(object sender, EventArgs e)
        {
            InitializeReservations(reservation_search.Text);
        }

        private void Guest_search_TextChanged(object sender, EventArgs e)
        {
            InitializeGuests(guest_search.Text);
        }

        private void Search_text_box_TextChanged(object sender, EventArgs e)
        {
            InitializeRooms(rooms_search.Text);
        }

        private void Reservation_data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = this.reservation_data_grid.Rows[e.RowIndex];
                this.selectedReservationID = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void Guests_data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = this.guests_data_grid.Rows[e.RowIndex];
                this.selectedGuestID = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void Rooms_data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {   

            if(e.RowIndex != -1) 
            { 
                DataGridViewRow tableRow = this.rooms_data_grid.Rows[e.RowIndex];
                this.selectedRoomID = Convert.ToInt32(tableRow.Cells[0].Value);
            }
           
        }

        private void InitializeConnection()
        {
            String connectionString = "Data Source=DESKTOP-N09IQJK; Initial Catalog=HotelManagementSystem; Integrated Security=True";
            this.connection = new SqlConnection(connectionString);

            try
            {
                this.connection.Open();
                //MessageBox.Show("ok");
            }
            catch (Exception e) 
            {
                MessageBox.Show("not ok");
            }
        }

        public void InitializeRooms(String search) 
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.connection;

            if (string.IsNullOrEmpty(search))
            {
                command.CommandText = "Select r.id as \"Room number\",r.num_of_beds as \"Number of beds\", s.name as \"Status\", t.name as \"Type\"\n" +
                                  "From\n" +
                                  "Room as r\n" +
                                  "Inner Join\n" +
                                  "Status as s\n" +
                                  "On r.status_id = s.id\n" +
                                  "Inner Join\n" +
                                  "Type as t\n" +
                                  "On r.type_id = t.id\n";
            }
            else 
            {
                command.CommandText = "Select r.id as \"Room number\",r.num_of_beds as \"Number of beds\", s.name as \"Status\", t.name as \"Type\"\n" +
                                  "From\n" +
                                  "Room as r\n" +
                                  "Inner Join\n" +
                                  "Status as s\n" +
                                  "On r.status_id = s.id\n" +
                                  "Inner Join\n" +
                                  "Type as t\n" +
                                  "On r.type_id = t.id\n"+
                                  "Where r.id LIKE '%' + @src + '%' or s.name LIKE '%' + @src + '%'  or t.name LIKE '%' + @src+ '%' ";
                command.Parameters.AddWithValue("src", search);
            }

            SqlDataReader reader = command.ExecuteReader();
            DataTable roomsTable = new DataTable();
            roomsTable.Load(reader);
            rooms_data_grid.DataSource = roomsTable;
        }

        public void InitializeGuests(String search) 
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.connection;

            if (string.IsNullOrEmpty(search))
            {
                command.CommandText = "Select id as \"ID\", first_name as \"First name\", last_name as \"Last name\", email as \"Email\", phone as \"Phone\", adress as \"Adress\", city as \"City\", country as \"Country\"\n" +
                                 "From\n" +
                                 "Guest";
            }
            else 
            {
                command.CommandText = "Select id as \"ID\", first_name as \"First name\", last_name as \"Last name\", email as \"Email\", phone as \"Phone\", adress as \"Adress\", city as \"City\", country as \"Country\"\n" +
                                 "From\n" +
                                 "Guest\n"+
                                 "where id like '%'+@src+'%' or first_name like '%'+@src+'%' or last_name like '%'+@src+'%' ";
                command.Parameters.AddWithValue("src", search);
            }

            SqlDataReader reader = command.ExecuteReader();
            DataTable guestsTable = new DataTable();
            guestsTable.Load(reader);
            guests_data_grid.DataSource = guestsTable;
        }

        public void InitializeReservations(String search) 
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.connection;

            if (string.IsNullOrEmpty(search))
            {
                command.CommandText = "Select res.id as \"Reservation ID\",res.guest_id as \"Guest ID\",  g.first_name as \"First name\", g.last_name as \"Last name\", g.email as \"Email\", g.phone as \"Phone\", g.city as \"City\", g.country as \"Country\", res.room_id as \"Room number\", res.created as \"Date of creation\", res.check_in as \"Check in date\", res.check_out as \"Check out date\", res.adults as \"Adults\", res.childrens as \"Childrens\", res.meal as \"Meal\", res.price as \"Price\"\n" +
                                  "From \n" +
                                  "Reservation as res\n" +
                                  "Inner Join\n" +
                                  "Guest as g\n" +
                                  "On res.guest_id = g.id\n" +
                                  "Inner join\n" +
                                  "Room as r\n" +
                                  "On res.room_id = r.id";
            }
            else 
            {
                command.CommandText = "Select res.id as \"Reservation ID\",res.guest_id as \"Guest ID\",  g.first_name as \"First name\", g.last_name as \"Last name\", g.email as \"Email\", g.phone as \"Phone\", g.city as \"City\", g.country as \"Country\", res.room_id as \"Room number\", res.created as \"Date of creation\", res.check_in as \"Check in date\", res.check_out as \"Check out date\", res.adults as \"Adults\", res.childrens as \"Childrens\", res.meal as \"Meal\", res.price as \"Price\"\n" +
                                  "From \n" +
                                  "Reservation as res\n" +
                                  "Inner Join\n" +
                                  "Guest as g\n" +
                                  "On res.guest_id = g.id\n" +
                                  "Inner join\n" +
                                  "Room as r\n" +
                                  "On res.room_id = r.id\n"+
                                  "where res.id like '%'+@src+'%' or  g.first_name like '%'+@src+'%' or g.last_name like '%'+@src+'%' ";
                command.Parameters.AddWithValue("src", search);
            }
            
            SqlDataReader reader = command.ExecuteReader();
            DataTable reservationTable = new DataTable();
            reservationTable.Load(reader);
            reservation_data_grid.DataSource = reservationTable;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditRoomForm addForm = new AddEditRoomForm(this ,false);
            addForm.ShowDialog();
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.selectedRoomID != -1)
            {
                AddEditRoomForm editForm = new AddEditRoomForm(this, true);
                editForm.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Please select room you want to edit !");
            }

        }

        private void addGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditGuestForm addForm = new AddEditGuestForm(this, false);
            addForm.ShowDialog();
        }

        private void editSelectedGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.selectedGuestID != -1)
            {
                AddEditGuestForm editForm = new AddEditGuestForm(this, true);
                editForm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Please select guest you want to edit !");
            }

        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditReseravtionForm addForm = new AddEditReseravtionForm(this, false);
            addForm.ShowDialog();
        }

        private void editReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.selectedReservationID != -1)
            {
                AddEditReseravtionForm editForm = new AddEditReseravtionForm(this, true);
                editForm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Please select reservation you want to edit !");
            }
        }

        private void deleteSelectedRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (this.selectedRoomID != -1)
            {

                DialogResult res = MessageBox.Show("Are you sure ?!", "Delete", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes) 
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = this.connection;
                    command.CommandText = "Delete from Room where id = @ID";
                    command.Parameters.AddWithValue("ID", this.selectedRoomID);

                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Room " + this.selectedRoomID + " is successfully deleted !");
                        InitializeRooms(null);
                    }
                    else
                    {
                        MessageBox.Show("Some error occured, please try again ...");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select room you want to delete !");
            }

                

        }

        private void deleteSelectedGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.selectedGuestID != -1)
            {

                DialogResult res = MessageBox.Show("Are you sure ?!", "Delete", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes) 
                { 
                    SqlCommand command = new SqlCommand();
                    command.Connection = this.connection;
                    command.CommandText = "Delete from Reservation where guest_id = @ID";
                    command.Parameters.AddWithValue("ID", this.selectedGuestID);

                    int rows = command.ExecuteNonQuery();

                
                
                    InitializeReservations(null);
                    command.CommandText = "Delete from Guest where id = @di";
                    command.Parameters.AddWithValue("di", this.selectedGuestID);

                    int rows1 = command.ExecuteNonQuery();

                    if (rows1 > 0)
                    {
                        MessageBox.Show("Guest with ID: " + this.selectedGuestID + " is successfully deleted !");
                        InitializeGuests(null);

                    }
                    else 
                    {
                        MessageBox.Show("Some error occurred, please try again ...");
                    }

               

                }
                
            }
            else
            {
                MessageBox.Show("Please select guest you want to delete !");
            }


        }

        private void deleteSelectedReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.selectedReservationID != -1)
            {

                DialogResult res = MessageBox.Show("Are you sure ?!", "Delete", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes) 
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = this.connection;

                    command.CommandText = "Select room_id from Reservation where id = @di";
                    command.Parameters.AddWithValue("di", this.selectedReservationID);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    int room = reader.GetInt32(0);

                    reader.Close();

                    
                    command.CommandText = "Delete from Reservation where id = @ID";
                    command.Parameters.AddWithValue("ID", this.selectedReservationID);

                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        command.CommandText = "Update Room Set status_id = @num where id=@room";
                        command.Parameters.AddWithValue("num", 1);
                        command.Parameters.AddWithValue("room", room);

                        int r = command.ExecuteNonQuery();

                        if (r > 0)
                        {
                            MessageBox.Show("Reservation with ID: " + this.selectedReservationID + " is successfully deleted !");
                            InitializeReservations(null);
                            InitializeRooms(null);

                        }
                        else 
                        {
                            MessageBox.Show("Some error occurred, please try again ...");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Some error occured, please try again ...");
                    }

                }

                
                
            }
            else
            {
                MessageBox.Show("Please select reservation you want to delete !");
            }
        }
    }
}
