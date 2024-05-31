
namespace cinemamangement_1
{
    partial class Form4
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
            this.movies_title = new System.Windows.Forms.Label();
            this.movie_id_textbox = new System.Windows.Forms.TextBox();
            this.movie_title_textox = new System.Windows.Forms.TextBox();
            this.director_textbox = new System.Windows.Forms.TextBox();
            this.staff_textbox = new System.Windows.Forms.TextBox();
            this.synopsis_textbox = new System.Windows.Forms.TextBox();
            this.duration_textbox = new System.Windows.Forms.TextBox();
            this.movieidlabel = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.director_label = new System.Windows.Forms.Label();
            this.actor_label = new System.Windows.Forms.Label();
            this.synopsis_label = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert2 = new System.Windows.Forms.Button();
            this.update2 = new System.Windows.Forms.Button();
            this.display2 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.search2 = new System.Windows.Forms.Button();
            this.searchbartext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // movies_title
            // 
            this.movies_title.AutoSize = true;
            this.movies_title.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movies_title.Location = new System.Drawing.Point(305, 27);
            this.movies_title.Name = "movies_title";
            this.movies_title.Size = new System.Drawing.Size(81, 27);
            this.movies_title.TabIndex = 0;
            this.movies_title.Text = "movies";
            this.movies_title.Click += new System.EventHandler(this.movies_title_Click);
            // 
            // movie_id_textbox
            // 
            this.movie_id_textbox.Location = new System.Drawing.Point(138, 74);
            this.movie_id_textbox.Name = "movie_id_textbox";
            this.movie_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.movie_id_textbox.TabIndex = 1;
            // 
            // movie_title_textox
            // 
            this.movie_title_textox.Location = new System.Drawing.Point(138, 123);
            this.movie_title_textox.Name = "movie_title_textox";
            this.movie_title_textox.Size = new System.Drawing.Size(100, 20);
            this.movie_title_textox.TabIndex = 2;
            // 
            // director_textbox
            // 
            this.director_textbox.Location = new System.Drawing.Point(138, 167);
            this.director_textbox.Name = "director_textbox";
            this.director_textbox.Size = new System.Drawing.Size(100, 20);
            this.director_textbox.TabIndex = 3;
            // 
            // staff_textbox
            // 
            this.staff_textbox.Location = new System.Drawing.Point(138, 213);
            this.staff_textbox.Name = "staff_textbox";
            this.staff_textbox.Size = new System.Drawing.Size(100, 20);
            this.staff_textbox.TabIndex = 4;
            // 
            // synopsis_textbox
            // 
            this.synopsis_textbox.Location = new System.Drawing.Point(138, 266);
            this.synopsis_textbox.Name = "synopsis_textbox";
            this.synopsis_textbox.Size = new System.Drawing.Size(100, 20);
            this.synopsis_textbox.TabIndex = 5;
            // 
            // duration_textbox
            // 
            this.duration_textbox.Location = new System.Drawing.Point(138, 310);
            this.duration_textbox.Name = "duration_textbox";
            this.duration_textbox.Size = new System.Drawing.Size(100, 20);
            this.duration_textbox.TabIndex = 6;
            // 
            // movieidlabel
            // 
            this.movieidlabel.AutoSize = true;
            this.movieidlabel.Location = new System.Drawing.Point(37, 80);
            this.movieidlabel.Name = "movieidlabel";
            this.movieidlabel.Size = new System.Drawing.Size(49, 13);
            this.movieidlabel.TabIndex = 7;
            this.movieidlabel.Text = "movie_id";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(37, 123);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(23, 13);
            this.title_label.TabIndex = 8;
            this.title_label.Text = "title";
            // 
            // director_label
            // 
            this.director_label.AutoSize = true;
            this.director_label.Location = new System.Drawing.Point(37, 167);
            this.director_label.Name = "director_label";
            this.director_label.Size = new System.Drawing.Size(42, 13);
            this.director_label.TabIndex = 9;
            this.director_label.Text = "director";
            // 
            // actor_label
            // 
            this.actor_label.AutoSize = true;
            this.actor_label.Location = new System.Drawing.Point(40, 213);
            this.actor_label.Name = "actor_label";
            this.actor_label.Size = new System.Drawing.Size(36, 13);
            this.actor_label.TabIndex = 10;
            this.actor_label.Text = "actors";
            // 
            // synopsis_label
            // 
            this.synopsis_label.AutoSize = true;
            this.synopsis_label.Location = new System.Drawing.Point(40, 272);
            this.synopsis_label.Name = "synopsis_label";
            this.synopsis_label.Size = new System.Drawing.Size(47, 13);
            this.synopsis_label.TabIndex = 11;
            this.synopsis_label.Text = "synopsis";
            // 
            // duration_label
            // 
            this.duration_label.AutoSize = true;
            this.duration_label.Location = new System.Drawing.Point(43, 310);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(67, 13);
            this.duration_label.TabIndex = 12;
            this.duration_label.Text = "duration_min";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 212);
            this.dataGridView1.TabIndex = 13;
            // 
            // insert2
            // 
            this.insert2.Location = new System.Drawing.Point(419, 367);
            this.insert2.Name = "insert2";
            this.insert2.Size = new System.Drawing.Size(75, 23);
            this.insert2.TabIndex = 14;
            this.insert2.Text = "insert";
            this.insert2.UseVisualStyleBackColor = true;
            this.insert2.Click += new System.EventHandler(this.insert2_Click);
            // 
            // update2
            // 
            this.update2.Location = new System.Drawing.Point(419, 406);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(75, 23);
            this.update2.TabIndex = 15;
            this.update2.Text = "update";
            this.update2.UseVisualStyleBackColor = true;
            this.update2.Click += new System.EventHandler(this.update2_Click);
            // 
            // display2
            // 
            this.display2.Location = new System.Drawing.Point(697, 366);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(75, 23);
            this.display2.TabIndex = 16;
            this.display2.Text = "display";
            this.display2.UseVisualStyleBackColor = true;
            this.display2.Click += new System.EventHandler(this.display2_Click);
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(696, 406);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(75, 23);
            this.delete2.TabIndex = 17;
            this.delete2.Text = "delete";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(695, 300);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(75, 23);
            this.search2.TabIndex = 18;
            this.search2.Text = "search";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // searchbartext
            // 
            this.searchbartext.Location = new System.Drawing.Point(419, 302);
            this.searchbartext.Name = "searchbartext";
            this.searchbartext.Size = new System.Drawing.Size(270, 20);
            this.searchbartext.TabIndex = 19;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbartext);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.update2);
            this.Controls.Add(this.insert2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.duration_label);
            this.Controls.Add(this.synopsis_label);
            this.Controls.Add(this.actor_label);
            this.Controls.Add(this.director_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.movieidlabel);
            this.Controls.Add(this.duration_textbox);
            this.Controls.Add(this.synopsis_textbox);
            this.Controls.Add(this.staff_textbox);
            this.Controls.Add(this.director_textbox);
            this.Controls.Add(this.movie_title_textox);
            this.Controls.Add(this.movie_id_textbox);
            this.Controls.Add(this.movies_title);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movies_title;
        private System.Windows.Forms.TextBox movie_id_textbox;
        private System.Windows.Forms.TextBox movie_title_textox;
        private System.Windows.Forms.TextBox director_textbox;
        private System.Windows.Forms.TextBox staff_textbox;
        private System.Windows.Forms.TextBox synopsis_textbox;
        private System.Windows.Forms.TextBox duration_textbox;
        private System.Windows.Forms.Label movieidlabel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label director_label;
        private System.Windows.Forms.Label actor_label;
        private System.Windows.Forms.Label synopsis_label;
        private System.Windows.Forms.Label duration_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert2;
        private System.Windows.Forms.Button update2;
        private System.Windows.Forms.Button display2;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.TextBox searchbartext;
    }
}