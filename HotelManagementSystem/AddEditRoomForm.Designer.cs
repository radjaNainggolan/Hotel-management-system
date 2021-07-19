
namespace HotelManagementSystem
{
    partial class AddEditRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_of_beds_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.room_status_combo = new System.Windows.Forms.ComboBox();
            this.room_type_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of beds : ";
            // 
            // num_of_beds_text_box
            // 
            this.num_of_beds_text_box.Location = new System.Drawing.Point(389, 170);
            this.num_of_beds_text_box.Name = "num_of_beds_text_box";
            this.num_of_beds_text_box.Size = new System.Drawing.Size(199, 20);
            this.num_of_beds_text_box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room status : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room type : ";
            // 
            // room_status_combo
            // 
            this.room_status_combo.FormattingEnabled = true;
            this.room_status_combo.Items.AddRange(new object[] {
            "Free",
            "Taken",
            "In preparation"});
            this.room_status_combo.Location = new System.Drawing.Point(389, 217);
            this.room_status_combo.Name = "room_status_combo";
            this.room_status_combo.Size = new System.Drawing.Size(199, 21);
            this.room_status_combo.TabIndex = 7;
            // 
            // room_type_combo
            // 
            this.room_type_combo.FormattingEnabled = true;
            this.room_type_combo.Items.AddRange(new object[] {
            "Classic room",
            "Studio",
            "Suite",
            "President suite",
            "Apartment"});
            this.room_type_combo.Location = new System.Drawing.Point(389, 271);
            this.room_type_combo.Name = "room_type_combo";
            this.room_type_combo.Size = new System.Drawing.Size(199, 21);
            this.room_type_combo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.room_type_combo);
            this.Controls.Add(this.room_status_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_of_beds_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoomForm";
            this.Text = "AddRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num_of_beds_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox room_status_combo;
        private System.Windows.Forms.ComboBox room_type_combo;
        private System.Windows.Forms.Button button1;
    }
}