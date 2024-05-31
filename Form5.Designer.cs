
namespace cinemamangement_1
{
    partial class Form5
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
            this.theatre_label_title = new System.Windows.Forms.Label();
            this.theatre_id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.seat_count_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.theatre_id_textbox = new System.Windows.Forms.TextBox();
            this.theatre_name_textbox = new System.Windows.Forms.TextBox();
            this.seat_count_textbox = new System.Windows.Forms.TextBox();
            this.inset3 = new System.Windows.Forms.Button();
            this.display3 = new System.Windows.Forms.Button();
            this.update3 = new System.Windows.Forms.Button();
            this.delete3 = new System.Windows.Forms.Button();
            this.search3 = new System.Windows.Forms.Button();
            this.searchbar_theatre_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // theatre_label_title
            // 
            this.theatre_label_title.AutoSize = true;
            this.theatre_label_title.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theatre_label_title.Location = new System.Drawing.Point(346, 25);
            this.theatre_label_title.Name = "theatre_label_title";
            this.theatre_label_title.Size = new System.Drawing.Size(82, 27);
            this.theatre_label_title.TabIndex = 0;
            this.theatre_label_title.Text = "theatre";
            // 
            // theatre_id_label
            // 
            this.theatre_id_label.AutoSize = true;
            this.theatre_id_label.Location = new System.Drawing.Point(86, 102);
            this.theatre_id_label.Name = "theatre_id_label";
            this.theatre_id_label.Size = new System.Drawing.Size(54, 13);
            this.theatre_id_label.TabIndex = 1;
            this.theatre_id_label.Text = "theatre_id";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(86, 143);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(33, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "name";
            // 
            // seat_count_label
            // 
            this.seat_count_label.AutoSize = true;
            this.seat_count_label.Location = new System.Drawing.Point(86, 175);
            this.seat_count_label.Name = "seat_count_label";
            this.seat_count_label.Size = new System.Drawing.Size(60, 13);
            this.seat_count_label.TabIndex = 3;
            this.seat_count_label.Text = "seat_count";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 252);
            this.dataGridView1.TabIndex = 4;
            // 
            // theatre_id_textbox
            // 
            this.theatre_id_textbox.Location = new System.Drawing.Point(181, 102);
            this.theatre_id_textbox.Name = "theatre_id_textbox";
            this.theatre_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.theatre_id_textbox.TabIndex = 5;
            // 
            // theatre_name_textbox
            // 
            this.theatre_name_textbox.Location = new System.Drawing.Point(181, 143);
            this.theatre_name_textbox.Name = "theatre_name_textbox";
            this.theatre_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.theatre_name_textbox.TabIndex = 6;
            // 
            // seat_count_textbox
            // 
            this.seat_count_textbox.Location = new System.Drawing.Point(181, 175);
            this.seat_count_textbox.Name = "seat_count_textbox";
            this.seat_count_textbox.Size = new System.Drawing.Size(100, 20);
            this.seat_count_textbox.TabIndex = 7;
            // 
            // inset3
            // 
            this.inset3.Location = new System.Drawing.Point(80, 258);
            this.inset3.Name = "inset3";
            this.inset3.Size = new System.Drawing.Size(75, 23);
            this.inset3.TabIndex = 8;
            this.inset3.Text = "insert";
            this.inset3.UseVisualStyleBackColor = true;
            this.inset3.Click += new System.EventHandler(this.inset3_Click);
            // 
            // display3
            // 
            this.display3.Location = new System.Drawing.Point(181, 257);
            this.display3.Name = "display3";
            this.display3.Size = new System.Drawing.Size(75, 23);
            this.display3.TabIndex = 9;
            this.display3.Text = "display";
            this.display3.UseVisualStyleBackColor = true;
            this.display3.Click += new System.EventHandler(this.display3_Click);
            // 
            // update3
            // 
            this.update3.Location = new System.Drawing.Point(80, 307);
            this.update3.Name = "update3";
            this.update3.Size = new System.Drawing.Size(75, 23);
            this.update3.TabIndex = 10;
            this.update3.Text = "update";
            this.update3.UseVisualStyleBackColor = true;
            this.update3.Click += new System.EventHandler(this.update3_Click);
            // 
            // delete3
            // 
            this.delete3.Location = new System.Drawing.Point(181, 306);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(75, 23);
            this.delete3.TabIndex = 11;
            this.delete3.Text = "delete";
            this.delete3.UseVisualStyleBackColor = true;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // search3
            // 
            this.search3.Location = new System.Drawing.Point(709, 102);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(75, 23);
            this.search3.TabIndex = 12;
            this.search3.Text = "search";
            this.search3.UseVisualStyleBackColor = true;
            this.search3.Click += new System.EventHandler(this.search3_Click);
            // 
            // searchbar_theatre_textbox
            // 
            this.searchbar_theatre_textbox.Location = new System.Drawing.Point(508, 105);
            this.searchbar_theatre_textbox.Name = "searchbar_theatre_textbox";
            this.searchbar_theatre_textbox.Size = new System.Drawing.Size(158, 20);
            this.searchbar_theatre_textbox.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbar_theatre_textbox);
            this.Controls.Add(this.search3);
            this.Controls.Add(this.delete3);
            this.Controls.Add(this.update3);
            this.Controls.Add(this.display3);
            this.Controls.Add(this.inset3);
            this.Controls.Add(this.seat_count_textbox);
            this.Controls.Add(this.theatre_name_textbox);
            this.Controls.Add(this.theatre_id_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seat_count_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.theatre_id_label);
            this.Controls.Add(this.theatre_label_title);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label theatre_label_title;
        private System.Windows.Forms.Label theatre_id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label seat_count_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox theatre_id_textbox;
        private System.Windows.Forms.TextBox theatre_name_textbox;
        private System.Windows.Forms.TextBox seat_count_textbox;
        private System.Windows.Forms.Button inset3;
        private System.Windows.Forms.Button display3;
        private System.Windows.Forms.Button update3;
        private System.Windows.Forms.Button delete3;
        private System.Windows.Forms.Button search3;
        private System.Windows.Forms.TextBox searchbar_theatre_textbox;
    }
}