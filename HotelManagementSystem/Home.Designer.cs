
namespace HotelManagementSystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.search_text_box = new System.Windows.Forms.TabPage();
            this.rooms_data_grid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guests_data_grid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reservation_data_grid = new System.Windows.Forms.DataGridView();
            this.deleteSelectedRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rooms_search = new System.Windows.Forms.TextBox();
            this.guest_search = new System.Windows.Forms.TextBox();
            this.reservation_search = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.search_text_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_data_grid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guests_data_grid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.guestsToolStripMenuItem,
            this.reservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editRoomToolStripMenuItem,
            this.deleteSelectedRoomToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addToolStripMenuItem.Text = "Add room";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editRoomToolStripMenuItem
            // 
            this.editRoomToolStripMenuItem.Name = "editRoomToolStripMenuItem";
            this.editRoomToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editRoomToolStripMenuItem.Text = "Edit selected room";
            this.editRoomToolStripMenuItem.Click += new System.EventHandler(this.editRoomToolStripMenuItem_Click);
            // 
            // guestsToolStripMenuItem
            // 
            this.guestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGuestToolStripMenuItem,
            this.editSelectedGuestToolStripMenuItem,
            this.deleteSelectedGuestToolStripMenuItem});
            this.guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            this.guestsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.guestsToolStripMenuItem.Text = "Guests";
            // 
            // addGuestToolStripMenuItem
            // 
            this.addGuestToolStripMenuItem.Name = "addGuestToolStripMenuItem";
            this.addGuestToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addGuestToolStripMenuItem.Text = "Add guest";
            this.addGuestToolStripMenuItem.Click += new System.EventHandler(this.addGuestToolStripMenuItem_Click);
            // 
            // editSelectedGuestToolStripMenuItem
            // 
            this.editSelectedGuestToolStripMenuItem.Name = "editSelectedGuestToolStripMenuItem";
            this.editSelectedGuestToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editSelectedGuestToolStripMenuItem.Text = "Edit selected guest";
            this.editSelectedGuestToolStripMenuItem.Click += new System.EventHandler(this.editSelectedGuestToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationToolStripMenuItem,
            this.editReservationToolStripMenuItem,
            this.deleteSelectedReservationToolStripMenuItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addReservationToolStripMenuItem.Text = "Add reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.addReservationToolStripMenuItem_Click);
            // 
            // editReservationToolStripMenuItem
            // 
            this.editReservationToolStripMenuItem.Name = "editReservationToolStripMenuItem";
            this.editReservationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.editReservationToolStripMenuItem.Text = "Edit selected reservation";
            this.editReservationToolStripMenuItem.Click += new System.EventHandler(this.editReservationToolStripMenuItem_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.search_text_box);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(12, 86);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(987, 393);
            this.tabs.TabIndex = 1;
            // 
            // search_text_box
            // 
            this.search_text_box.Controls.Add(this.rooms_search);
            this.search_text_box.Controls.Add(this.rooms_data_grid);
            this.search_text_box.Location = new System.Drawing.Point(4, 22);
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Padding = new System.Windows.Forms.Padding(3);
            this.search_text_box.Size = new System.Drawing.Size(979, 367);
            this.search_text_box.TabIndex = 0;
            this.search_text_box.Text = "Rooms tab";
            this.search_text_box.UseVisualStyleBackColor = true;
            // 
            // rooms_data_grid
            // 
            this.rooms_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rooms_data_grid.Location = new System.Drawing.Point(0, 0);
            this.rooms_data_grid.Name = "rooms_data_grid";
            this.rooms_data_grid.Size = new System.Drawing.Size(715, 367);
            this.rooms_data_grid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guest_search);
            this.tabPage2.Controls.Add(this.guests_data_grid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Guests tab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // guests_data_grid
            // 
            this.guests_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guests_data_grid.Location = new System.Drawing.Point(0, 0);
            this.guests_data_grid.Name = "guests_data_grid";
            this.guests_data_grid.Size = new System.Drawing.Size(715, 367);
            this.guests_data_grid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reservation_search);
            this.tabPage3.Controls.Add(this.reservation_data_grid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(979, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservations tab";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reservation_data_grid
            // 
            this.reservation_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservation_data_grid.Location = new System.Drawing.Point(0, 0);
            this.reservation_data_grid.Name = "reservation_data_grid";
            this.reservation_data_grid.Size = new System.Drawing.Size(715, 367);
            this.reservation_data_grid.TabIndex = 0;
            // 
            // deleteSelectedRoomToolStripMenuItem
            // 
            this.deleteSelectedRoomToolStripMenuItem.Name = "deleteSelectedRoomToolStripMenuItem";
            this.deleteSelectedRoomToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteSelectedRoomToolStripMenuItem.Text = "Delete selected room";
            this.deleteSelectedRoomToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRoomToolStripMenuItem_Click);
            // 
            // deleteSelectedGuestToolStripMenuItem
            // 
            this.deleteSelectedGuestToolStripMenuItem.Name = "deleteSelectedGuestToolStripMenuItem";
            this.deleteSelectedGuestToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteSelectedGuestToolStripMenuItem.Text = "Delete selected guest";
            this.deleteSelectedGuestToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedGuestToolStripMenuItem_Click);
            // 
            // deleteSelectedReservationToolStripMenuItem
            // 
            this.deleteSelectedReservationToolStripMenuItem.Name = "deleteSelectedReservationToolStripMenuItem";
            this.deleteSelectedReservationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteSelectedReservationToolStripMenuItem.Text = "Delete selected reservation";
            this.deleteSelectedReservationToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedReservationToolStripMenuItem_Click);
            // 
            // rooms_search
            // 
            this.rooms_search.Location = new System.Drawing.Point(747, 37);
            this.rooms_search.Name = "rooms_search";
            this.rooms_search.Size = new System.Drawing.Size(210, 20);
            this.rooms_search.TabIndex = 1;
            // 
            // guest_search
            // 
            this.guest_search.Location = new System.Drawing.Point(756, 41);
            this.guest_search.Name = "guest_search";
            this.guest_search.Size = new System.Drawing.Size(192, 20);
            this.guest_search.TabIndex = 1;
            // 
            // reservation_search
            // 
            this.reservation_search.Location = new System.Drawing.Point(743, 39);
            this.reservation_search.Name = "reservation_search";
            this.reservation_search.Size = new System.Drawing.Size(205, 20);
            this.reservation_search.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 491);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Hotel management system";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.search_text_box.ResumeLayout(false);
            this.search_text_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_data_grid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guests_data_grid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage search_text_box;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView rooms_data_grid;
        private System.Windows.Forms.DataGridView guests_data_grid;
        private System.Windows.Forms.DataGridView reservation_data_grid;
        private System.Windows.Forms.ToolStripMenuItem editRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedReservationToolStripMenuItem;
        private System.Windows.Forms.TextBox rooms_search;
        private System.Windows.Forms.TextBox guest_search;
        private System.Windows.Forms.TextBox reservation_search;
    }
}

