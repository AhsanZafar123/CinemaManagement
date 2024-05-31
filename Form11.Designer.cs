
namespace cinemamangement_1
{
    partial class Form11
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
            this.reserved_seats_title_label = new System.Windows.Forms.Label();
            this.reserved_seat_is_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.screening_id_label = new System.Windows.Forms.Label();
            this.reservation_id_label = new System.Windows.Forms.Label();
            this.reserved_seat_id_textbox = new System.Windows.Forms.TextBox();
            this.seat_id_textbox = new System.Windows.Forms.TextBox();
            this.screening_id_textbox = new System.Windows.Forms.TextBox();
            this.reservation_id_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert9 = new System.Windows.Forms.Button();
            this.display9 = new System.Windows.Forms.Button();
            this.update9 = new System.Windows.Forms.Button();
            this.delete9 = new System.Windows.Forms.Button();
            this.searchbar_reservedseats_textbox = new System.Windows.Forms.TextBox();
            this.search9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reserved_seats_title_label
            // 
            this.reserved_seats_title_label.AutoSize = true;
            this.reserved_seats_title_label.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserved_seats_title_label.Location = new System.Drawing.Point(288, 37);
            this.reserved_seats_title_label.Name = "reserved_seats_title_label";
            this.reserved_seats_title_label.Size = new System.Drawing.Size(148, 27);
            this.reserved_seats_title_label.TabIndex = 0;
            this.reserved_seats_title_label.Text = "reserved seats";
            // 
            // reserved_seat_is_label
            // 
            this.reserved_seat_is_label.AutoSize = true;
            this.reserved_seat_is_label.Location = new System.Drawing.Point(77, 120);
            this.reserved_seat_is_label.Name = "reserved_seat_is_label";
            this.reserved_seat_is_label.Size = new System.Drawing.Size(88, 13);
            this.reserved_seat_is_label.TabIndex = 1;
            this.reserved_seat_is_label.Text = "reserved_seat_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "seat_id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // screening_id_label
            // 
            this.screening_id_label.AutoSize = true;
            this.screening_id_label.Location = new System.Drawing.Point(77, 200);
            this.screening_id_label.Name = "screening_id_label";
            this.screening_id_label.Size = new System.Drawing.Size(67, 13);
            this.screening_id_label.TabIndex = 3;
            this.screening_id_label.Text = "screening_id";
            // 
            // reservation_id_label
            // 
            this.reservation_id_label.AutoSize = true;
            this.reservation_id_label.Location = new System.Drawing.Point(77, 241);
            this.reservation_id_label.Name = "reservation_id_label";
            this.reservation_id_label.Size = new System.Drawing.Size(73, 13);
            this.reservation_id_label.TabIndex = 4;
            this.reservation_id_label.Text = "reservation_id";
            // 
            // reserved_seat_id_textbox
            // 
            this.reserved_seat_id_textbox.Location = new System.Drawing.Point(193, 120);
            this.reserved_seat_id_textbox.Name = "reserved_seat_id_textbox";
            this.reserved_seat_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.reserved_seat_id_textbox.TabIndex = 5;
            // 
            // seat_id_textbox
            // 
            this.seat_id_textbox.Location = new System.Drawing.Point(193, 167);
            this.seat_id_textbox.Name = "seat_id_textbox";
            this.seat_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.seat_id_textbox.TabIndex = 6;
            // 
            // screening_id_textbox
            // 
            this.screening_id_textbox.Location = new System.Drawing.Point(193, 200);
            this.screening_id_textbox.Name = "screening_id_textbox";
            this.screening_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.screening_id_textbox.TabIndex = 7;
            // 
            // reservation_id_textbox
            // 
            this.reservation_id_textbox.Location = new System.Drawing.Point(193, 238);
            this.reservation_id_textbox.Name = "reservation_id_textbox";
            this.reservation_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.reservation_id_textbox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 267);
            this.dataGridView1.TabIndex = 9;
            // 
            // insert9
            // 
            this.insert9.Location = new System.Drawing.Point(147, 294);
            this.insert9.Name = "insert9";
            this.insert9.Size = new System.Drawing.Size(75, 23);
            this.insert9.TabIndex = 10;
            this.insert9.Text = "insert";
            this.insert9.UseVisualStyleBackColor = true;
            this.insert9.Click += new System.EventHandler(this.insert9_Click);
            // 
            // display9
            // 
            this.display9.Location = new System.Drawing.Point(248, 294);
            this.display9.Name = "display9";
            this.display9.Size = new System.Drawing.Size(75, 23);
            this.display9.TabIndex = 11;
            this.display9.Text = "display";
            this.display9.UseVisualStyleBackColor = true;
            this.display9.Click += new System.EventHandler(this.display9_Click);
            // 
            // update9
            // 
            this.update9.Location = new System.Drawing.Point(147, 333);
            this.update9.Name = "update9";
            this.update9.Size = new System.Drawing.Size(75, 23);
            this.update9.TabIndex = 12;
            this.update9.Text = "update";
            this.update9.UseVisualStyleBackColor = true;
            this.update9.Click += new System.EventHandler(this.update9_Click);
            // 
            // delete9
            // 
            this.delete9.Location = new System.Drawing.Point(248, 333);
            this.delete9.Name = "delete9";
            this.delete9.Size = new System.Drawing.Size(75, 23);
            this.delete9.TabIndex = 13;
            this.delete9.Text = "delete";
            this.delete9.UseVisualStyleBackColor = true;
            this.delete9.Click += new System.EventHandler(this.delete9_Click);
            // 
            // searchbar_reservedseats_textbox
            // 
            this.searchbar_reservedseats_textbox.Location = new System.Drawing.Point(390, 123);
            this.searchbar_reservedseats_textbox.Name = "searchbar_reservedseats_textbox";
            this.searchbar_reservedseats_textbox.Size = new System.Drawing.Size(303, 20);
            this.searchbar_reservedseats_textbox.TabIndex = 14;
            // 
            // search9
            // 
            this.search9.Location = new System.Drawing.Point(699, 120);
            this.search9.Name = "search9";
            this.search9.Size = new System.Drawing.Size(75, 23);
            this.search9.TabIndex = 15;
            this.search9.Text = "search";
            this.search9.UseVisualStyleBackColor = true;
            this.search9.Click += new System.EventHandler(this.search9_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search9);
            this.Controls.Add(this.searchbar_reservedseats_textbox);
            this.Controls.Add(this.delete9);
            this.Controls.Add(this.update9);
            this.Controls.Add(this.display9);
            this.Controls.Add(this.insert9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reservation_id_textbox);
            this.Controls.Add(this.screening_id_textbox);
            this.Controls.Add(this.seat_id_textbox);
            this.Controls.Add(this.reserved_seat_id_textbox);
            this.Controls.Add(this.reservation_id_label);
            this.Controls.Add(this.screening_id_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reserved_seat_is_label);
            this.Controls.Add(this.reserved_seats_title_label);
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reserved_seats_title_label;
        private System.Windows.Forms.Label reserved_seat_is_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label screening_id_label;
        private System.Windows.Forms.Label reservation_id_label;
        private System.Windows.Forms.TextBox reserved_seat_id_textbox;
        private System.Windows.Forms.TextBox seat_id_textbox;
        private System.Windows.Forms.TextBox screening_id_textbox;
        private System.Windows.Forms.TextBox reservation_id_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert9;
        private System.Windows.Forms.Button display9;
        private System.Windows.Forms.Button update9;
        private System.Windows.Forms.Button delete9;
        private System.Windows.Forms.TextBox searchbar_reservedseats_textbox;
        private System.Windows.Forms.Button search9;
    }
}