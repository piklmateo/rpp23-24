namespace EventManager
{
    partial class FrmAddVenue
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
            this.gbAddVenue = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblVenueDescription = new System.Windows.Forms.Label();
            this.txtVenueDescription = new System.Windows.Forms.TextBox();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.btnAddVenue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbAddVenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddVenue
            // 
            this.gbAddVenue.Controls.Add(this.label2);
            this.gbAddVenue.Controls.Add(this.txtLatitude);
            this.gbAddVenue.Controls.Add(this.label1);
            this.gbAddVenue.Controls.Add(this.txtLongitude);
            this.gbAddVenue.Controls.Add(this.lblVenueDescription);
            this.gbAddVenue.Controls.Add(this.txtVenueDescription);
            this.gbAddVenue.Controls.Add(this.lblVenueName);
            this.gbAddVenue.Controls.Add(this.txtVenueName);
            this.gbAddVenue.Location = new System.Drawing.Point(12, 12);
            this.gbAddVenue.Name = "gbAddVenue";
            this.gbAddVenue.Size = new System.Drawing.Size(493, 295);
            this.gbAddVenue.TabIndex = 31;
            this.gbAddVenue.TabStop = false;
            this.gbAddVenue.Text = "New venue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Latitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLatitude.Location = new System.Drawing.Point(6, 165);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(372, 23);
            this.txtLatitude.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Longitude:";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLongitude.Location = new System.Drawing.Point(6, 105);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(372, 23);
            this.txtLongitude.TabIndex = 32;
            // 
            // lblVenueDescription
            // 
            this.lblVenueDescription.AutoSize = true;
            this.lblVenueDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenueDescription.Location = new System.Drawing.Point(6, 191);
            this.lblVenueDescription.Name = "lblVenueDescription";
            this.lblVenueDescription.Size = new System.Drawing.Size(83, 17);
            this.lblVenueDescription.TabIndex = 31;
            this.lblVenueDescription.Text = "Description:";
            // 
            // txtVenueDescription
            // 
            this.txtVenueDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVenueDescription.Location = new System.Drawing.Point(6, 211);
            this.txtVenueDescription.Multiline = true;
            this.txtVenueDescription.Name = "txtVenueDescription";
            this.txtVenueDescription.Size = new System.Drawing.Size(372, 78);
            this.txtVenueDescription.TabIndex = 30;
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenueName.Location = new System.Drawing.Point(3, 29);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(92, 17);
            this.lblVenueName.TabIndex = 29;
            this.lblVenueName.Text = "Venue name:";
            // 
            // txtVenueName
            // 
            this.txtVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVenueName.Location = new System.Drawing.Point(6, 49);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(372, 23);
            this.txtVenueName.TabIndex = 20;
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddVenue.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVenue.Location = new System.Drawing.Point(12, 313);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(75, 30);
            this.btnAddVenue.TabIndex = 32;
            this.btnAddVenue.Text = "ADD";
            this.btnAddVenue.UseVisualStyleBackColor = false;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(93, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddVenue);
            this.Controls.Add(this.gbAddVenue);
            this.MaximizeBox = false;
            this.Name = "FrmAddVenue";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddVenue";
            this.gbAddVenue.ResumeLayout(false);
            this.gbAddVenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddVenue;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.Label lblVenueDescription;
        private System.Windows.Forms.TextBox txtVenueDescription;
        private System.Windows.Forms.Button btnAddVenue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}