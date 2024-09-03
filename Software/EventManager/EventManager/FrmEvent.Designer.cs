namespace EventManager
{
    partial class FrmEvent
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
            this.gbAddEvent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.picQr = new System.Windows.Forms.PictureBox();
            this.lblTicketCategory = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblOrganizer = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddEvent
            // 
            this.gbAddEvent.Controls.Add(this.label1);
            this.gbAddEvent.Controls.Add(this.txtEventDate);
            this.gbAddEvent.Controls.Add(this.txtCategory);
            this.gbAddEvent.Controls.Add(this.picQr);
            this.gbAddEvent.Controls.Add(this.lblTicketCategory);
            this.gbAddEvent.Controls.Add(this.lblStartTime);
            this.gbAddEvent.Controls.Add(this.lblVenueName);
            this.gbAddEvent.Controls.Add(this.lblOrganizer);
            this.gbAddEvent.Controls.Add(this.lblEventName);
            this.gbAddEvent.Controls.Add(this.lblEventDate);
            this.gbAddEvent.Controls.Add(this.txtStartTime);
            this.gbAddEvent.Controls.Add(this.txtVenueName);
            this.gbAddEvent.Controls.Add(this.txtOrganizer);
            this.gbAddEvent.Controls.Add(this.txtEventName);
            this.gbAddEvent.Location = new System.Drawing.Point(10, 20);
            this.gbAddEvent.Name = "gbAddEvent";
            this.gbAddEvent.Size = new System.Drawing.Size(458, 522);
            this.gbAddEvent.TabIndex = 31;
            this.gbAddEvent.TabStop = false;
            this.gbAddEvent.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Vaš Qr kod eventa";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventDate.Location = new System.Drawing.Point(27, 344);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.ReadOnly = true;
            this.txtEventDate.Size = new System.Drawing.Size(184, 23);
            this.txtEventDate.TabIndex = 39;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(27, 477);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(399, 20);
            this.txtCategory.TabIndex = 38;
            // 
            // picQr
            // 
            this.picQr.Location = new System.Drawing.Point(79, 49);
            this.picQr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picQr.Name = "picQr";
            this.picQr.Size = new System.Drawing.Size(304, 186);
            this.picQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQr.TabIndex = 40;
            this.picQr.TabStop = false;
            // 
            // lblTicketCategory
            // 
            this.lblTicketCategory.AutoSize = true;
            this.lblTicketCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTicketCategory.Location = new System.Drawing.Point(24, 449);
            this.lblTicketCategory.Name = "lblTicketCategory";
            this.lblTicketCategory.Size = new System.Drawing.Size(109, 17);
            this.lblTicketCategory.TabIndex = 37;
            this.lblTicketCategory.Text = "Ticket category:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStartTime.Location = new System.Drawing.Point(238, 324);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(72, 17);
            this.lblStartTime.TabIndex = 34;
            this.lblStartTime.Text = "Start time:";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenueName.Location = new System.Drawing.Point(24, 394);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(92, 17);
            this.lblVenueName.TabIndex = 33;
            this.lblVenueName.Text = "Venue name:";
            // 
            // lblOrganizer
            // 
            this.lblOrganizer.AutoSize = true;
            this.lblOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrganizer.Location = new System.Drawing.Point(238, 394);
            this.lblOrganizer.Name = "lblOrganizer";
            this.lblOrganizer.Size = new System.Drawing.Size(75, 17);
            this.lblOrganizer.TabIndex = 32;
            this.lblOrganizer.Text = "Organizer:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventName.Location = new System.Drawing.Point(24, 259);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(87, 17);
            this.lblEventName.TabIndex = 29;
            this.lblEventName.Text = "Event name:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventDate.Location = new System.Drawing.Point(24, 322);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(80, 17);
            this.lblEventDate.TabIndex = 28;
            this.lblEventDate.Text = "Event date:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStartTime.Location = new System.Drawing.Point(242, 344);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(184, 23);
            this.txtStartTime.TabIndex = 24;
            // 
            // txtVenueName
            // 
            this.txtVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVenueName.Location = new System.Drawing.Point(27, 414);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.ReadOnly = true;
            this.txtVenueName.Size = new System.Drawing.Size(184, 23);
            this.txtVenueName.TabIndex = 23;
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOrganizer.Location = new System.Drawing.Point(242, 414);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.ReadOnly = true;
            this.txtOrganizer.Size = new System.Drawing.Size(184, 23);
            this.txtOrganizer.TabIndex = 22;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventName.Location = new System.Drawing.Point(27, 279);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(399, 23);
            this.txtEventName.TabIndex = 20;
            // 
            // FrmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 555);
            this.Controls.Add(this.gbAddEvent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmEvent";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvent";
            this.Load += new System.EventHandler(this.FrmEvent_Load);
            this.gbAddEvent.ResumeLayout(false);
            this.gbAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddEvent;
        private System.Windows.Forms.Label lblTicketCategory;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblOrganizer;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.TextBox txtOrganizer;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picQr;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}