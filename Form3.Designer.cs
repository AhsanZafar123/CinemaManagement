
namespace cinemamangement_1
{
    partial class Form3
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
            this.setmovie = new System.Windows.Forms.Button();
            this.settheatre = new System.Windows.Forms.Button();
            this.setscreening = new System.Windows.Forms.Button();
            this.setseats = new System.Windows.Forms.Button();
            this.setreservedseats = new System.Windows.Forms.Button();
            this.setemployee = new System.Windows.Forms.Button();
            this.setreservationtype = new System.Windows.Forms.Button();
            this.setreservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin veiw menu";
            // 
            // setmovie
            // 
            this.setmovie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setmovie.Location = new System.Drawing.Point(202, 97);
            this.setmovie.Name = "setmovie";
            this.setmovie.Size = new System.Drawing.Size(130, 23);
            this.setmovie.TabIndex = 1;
            this.setmovie.Text = "alter movies";
            this.setmovie.UseVisualStyleBackColor = false;
            this.setmovie.Click += new System.EventHandler(this.setmovie_Click);
            // 
            // settheatre
            // 
            this.settheatre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.settheatre.Location = new System.Drawing.Point(384, 97);
            this.settheatre.Name = "settheatre";
            this.settheatre.Size = new System.Drawing.Size(130, 23);
            this.settheatre.TabIndex = 2;
            this.settheatre.Text = "alter theatres";
            this.settheatre.UseVisualStyleBackColor = false;
            this.settheatre.Click += new System.EventHandler(this.settheatre_Click);
            // 
            // setscreening
            // 
            this.setscreening.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setscreening.Location = new System.Drawing.Point(202, 143);
            this.setscreening.Name = "setscreening";
            this.setscreening.Size = new System.Drawing.Size(130, 23);
            this.setscreening.TabIndex = 3;
            this.setscreening.Text = "alter screenings";
            this.setscreening.UseVisualStyleBackColor = false;
            this.setscreening.Click += new System.EventHandler(this.setscreening_Click);
            // 
            // setseats
            // 
            this.setseats.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setseats.Location = new System.Drawing.Point(384, 143);
            this.setseats.Name = "setseats";
            this.setseats.Size = new System.Drawing.Size(130, 23);
            this.setseats.TabIndex = 4;
            this.setseats.Text = "alter seats";
            this.setseats.UseVisualStyleBackColor = false;
            this.setseats.Click += new System.EventHandler(this.setseats_Click);
            // 
            // setreservedseats
            // 
            this.setreservedseats.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setreservedseats.Location = new System.Drawing.Point(384, 240);
            this.setreservedseats.Name = "setreservedseats";
            this.setreservedseats.Size = new System.Drawing.Size(130, 23);
            this.setreservedseats.TabIndex = 5;
            this.setreservedseats.Text = "alter reserved seats";
            this.setreservedseats.UseVisualStyleBackColor = false;
            this.setreservedseats.Click += new System.EventHandler(this.setreservedseats_Click);
            // 
            // setemployee
            // 
            this.setemployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setemployee.Location = new System.Drawing.Point(202, 190);
            this.setemployee.Name = "setemployee";
            this.setemployee.Size = new System.Drawing.Size(130, 23);
            this.setemployee.TabIndex = 6;
            this.setemployee.Text = "alter employee";
            this.setemployee.UseVisualStyleBackColor = false;
            this.setemployee.Click += new System.EventHandler(this.setemployee_Click);
            // 
            // setreservationtype
            // 
            this.setreservationtype.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setreservationtype.Location = new System.Drawing.Point(384, 190);
            this.setreservationtype.Name = "setreservationtype";
            this.setreservationtype.Size = new System.Drawing.Size(130, 23);
            this.setreservationtype.TabIndex = 7;
            this.setreservationtype.Text = "alter reservation type";
            this.setreservationtype.UseVisualStyleBackColor = false;
            this.setreservationtype.Click += new System.EventHandler(this.setreservationtype_Click);
            // 
            // setreservation
            // 
            this.setreservation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setreservation.DialogResult = System.Windows.Forms.DialogResult.No;
            this.setreservation.Location = new System.Drawing.Point(202, 240);
            this.setreservation.Name = "setreservation";
            this.setreservation.Size = new System.Drawing.Size(130, 23);
            this.setreservation.TabIndex = 8;
            this.setreservation.Text = "alter reservation";
            this.setreservation.UseVisualStyleBackColor = false;
            this.setreservation.Click += new System.EventHandler(this.setreservation_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setreservation);
            this.Controls.Add(this.setreservationtype);
            this.Controls.Add(this.setemployee);
            this.Controls.Add(this.setreservedseats);
            this.Controls.Add(this.setseats);
            this.Controls.Add(this.setscreening);
            this.Controls.Add(this.settheatre);
            this.Controls.Add(this.setmovie);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setmovie;
        private System.Windows.Forms.Button settheatre;
        private System.Windows.Forms.Button setscreening;
        private System.Windows.Forms.Button setseats;
        private System.Windows.Forms.Button setreservedseats;
        private System.Windows.Forms.Button setemployee;
        private System.Windows.Forms.Button setreservationtype;
        private System.Windows.Forms.Button setreservation;
    }
}