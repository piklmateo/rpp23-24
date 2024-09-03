namespace EventManager
{
    partial class FrmUpdateEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.cbOrganizers = new System.Windows.Forms.ComboBox();
            this.cbVenues = new System.Windows.Forms.ComboBox();
            this.lblEventCategory = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblOrganizer = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.cbEventCategory = new System.Windows.Forms.ComboBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbAddEvent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddEvent
            // 
            this.gbAddEvent.Controls.Add(this.label2);
            this.gbAddEvent.Controls.Add(this.txtImageUrl);
            this.gbAddEvent.Controls.Add(this.cbOrganizers);
            this.gbAddEvent.Controls.Add(this.cbVenues);
            this.gbAddEvent.Controls.Add(this.lblEventCategory);
            this.gbAddEvent.Controls.Add(this.lblStartTime);
            this.gbAddEvent.Controls.Add(this.lblVenueName);
            this.gbAddEvent.Controls.Add(this.lblOrganizer);
            this.gbAddEvent.Controls.Add(this.lblEventName);
            this.gbAddEvent.Controls.Add(this.lblEventDate);
            this.gbAddEvent.Controls.Add(this.cbEventCategory);
            this.gbAddEvent.Controls.Add(this.dtpEventDate);
            this.gbAddEvent.Controls.Add(this.txtStartTime);
            this.gbAddEvent.Controls.Add(this.txtEventName);
            this.gbAddEvent.Location = new System.Drawing.Point(12, 113);
            this.gbAddEvent.Name = "gbAddEvent";
            this.gbAddEvent.Size = new System.Drawing.Size(608, 381);
            this.gbAddEvent.TabIndex = 34;
            this.gbAddEvent.TabStop = false;
            this.gbAddEvent.Text = "Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Image url:";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImageUrl.Location = new System.Drawing.Point(23, 296);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(399, 23);
            this.txtImageUrl.TabIndex = 40;
            // 
            // cbOrganizers
            // 
            this.cbOrganizers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbOrganizers.FormattingEnabled = true;
            this.cbOrganizers.Location = new System.Drawing.Point(238, 184);
            this.cbOrganizers.Name = "cbOrganizers";
            this.cbOrganizers.Size = new System.Drawing.Size(184, 24);
            this.cbOrganizers.TabIndex = 39;
            // 
            // cbVenues
            // 
            this.cbVenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbVenues.FormattingEnabled = true;
            this.cbVenues.Location = new System.Drawing.Point(23, 184);
            this.cbVenues.Name = "cbVenues";
            this.cbVenues.Size = new System.Drawing.Size(184, 24);
            this.cbVenues.TabIndex = 38;
            // 
            // lblEventCategory
            // 
            this.lblEventCategory.AutoSize = true;
            this.lblEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventCategory.Location = new System.Drawing.Point(20, 221);
            this.lblEventCategory.Name = "lblEventCategory";
            this.lblEventCategory.Size = new System.Drawing.Size(107, 17);
            this.lblEventCategory.TabIndex = 37;
            this.lblEventCategory.Text = "Event category:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStartTime.Location = new System.Drawing.Point(235, 94);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(72, 17);
            this.lblStartTime.TabIndex = 34;
            this.lblStartTime.Text = "Start time:";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenueName.Location = new System.Drawing.Point(20, 164);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(92, 17);
            this.lblVenueName.TabIndex = 33;
            this.lblVenueName.Text = "Venue name:";
            // 
            // lblOrganizer
            // 
            this.lblOrganizer.AutoSize = true;
            this.lblOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrganizer.Location = new System.Drawing.Point(235, 164);
            this.lblOrganizer.Name = "lblOrganizer";
            this.lblOrganizer.Size = new System.Drawing.Size(75, 17);
            this.lblOrganizer.TabIndex = 32;
            this.lblOrganizer.Text = "Organizer:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventName.Location = new System.Drawing.Point(20, 29);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(87, 17);
            this.lblEventName.TabIndex = 29;
            this.lblEventName.Text = "Event name:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventDate.Location = new System.Drawing.Point(20, 92);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(80, 17);
            this.lblEventDate.TabIndex = 28;
            this.lblEventDate.Text = "Event date:";
            // 
            // cbEventCategory
            // 
            this.cbEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEventCategory.FormattingEnabled = true;
            this.cbEventCategory.Location = new System.Drawing.Point(23, 241);
            this.cbEventCategory.Name = "cbEventCategory";
            this.cbEventCategory.Size = new System.Drawing.Size(399, 24);
            this.cbEventCategory.TabIndex = 27;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEventDate.Location = new System.Drawing.Point(23, 112);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(184, 23);
            this.dtpEventDate.TabIndex = 26;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStartTime.Location = new System.Drawing.Point(238, 114);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(184, 23);
            this.txtStartTime.TabIndex = 24;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventName.Location = new System.Drawing.Point(23, 49);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(399, 23);
            this.txtEventName.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(93, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "UPDATE EVENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 79);
            this.panel1.TabIndex = 35;
            // 
            // FrmUpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAddEvent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateEvent";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateEvent";
            this.Load += new System.EventHandler(this.FrmUpdateEvent_Load);
            this.gbAddEvent.ResumeLayout(false);
            this.gbAddEvent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddEvent;
        private System.Windows.Forms.Label lblEventCategory;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblOrganizer;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.ComboBox cbEventCategory;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrganizers;
        private System.Windows.Forms.ComboBox cbVenues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}