namespace EventManager
{
    partial class FrmAddEvent
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
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.btnAddOrganizer = new System.Windows.Forms.Button();
            this.btnAddVenue = new System.Windows.Forms.Button();
            this.cbOrganizer = new System.Windows.Forms.ComboBox();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.lblEventCategory = new System.Windows.Forms.Label();
            this.lblImgUrl = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblOrganizer = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.cbTicketCategory = new System.Windows.Forms.ComboBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbAddEvent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddEvent
            // 
            this.gbAddEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbAddEvent.Controls.Add(this.lblStartTime);
            this.gbAddEvent.Controls.Add(this.txtStartTime);
            this.gbAddEvent.Controls.Add(this.btnAddOrganizer);
            this.gbAddEvent.Controls.Add(this.btnAddVenue);
            this.gbAddEvent.Controls.Add(this.cbOrganizer);
            this.gbAddEvent.Controls.Add(this.cbVenue);
            this.gbAddEvent.Controls.Add(this.lblEventCategory);
            this.gbAddEvent.Controls.Add(this.lblImgUrl);
            this.gbAddEvent.Controls.Add(this.lblVenueName);
            this.gbAddEvent.Controls.Add(this.lblOrganizer);
            this.gbAddEvent.Controls.Add(this.lblEventName);
            this.gbAddEvent.Controls.Add(this.lblEventDate);
            this.gbAddEvent.Controls.Add(this.cbTicketCategory);
            this.gbAddEvent.Controls.Add(this.dtpEventDate);
            this.gbAddEvent.Controls.Add(this.txtImageUrl);
            this.gbAddEvent.Controls.Add(this.txtEventName);
            this.gbAddEvent.Location = new System.Drawing.Point(15, 115);
            this.gbAddEvent.Name = "gbAddEvent";
            this.gbAddEvent.Size = new System.Drawing.Size(621, 363);
            this.gbAddEvent.TabIndex = 30;
            this.gbAddEvent.TabStop = false;
            this.gbAddEvent.Text = "New event";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStartTime.Location = new System.Drawing.Point(248, 94);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(72, 17);
            this.lblStartTime.TabIndex = 41;
            this.lblStartTime.Text = "Start time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStartTime.Location = new System.Drawing.Point(251, 112);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(184, 23);
            this.txtStartTime.TabIndex = 40;
            this.txtStartTime.Text = "20:00";
            // 
            // btnAddOrganizer
            // 
            this.btnAddOrganizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrganizer.Location = new System.Drawing.Point(251, 211);
            this.btnAddOrganizer.Name = "btnAddOrganizer";
            this.btnAddOrganizer.Size = new System.Drawing.Size(92, 21);
            this.btnAddOrganizer.TabIndex = 32;
            this.btnAddOrganizer.Text = "New organizer";
            this.btnAddOrganizer.UseVisualStyleBackColor = true;
            this.btnAddOrganizer.Click += new System.EventHandler(this.btnAddOrganizer_Click);
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.Location = new System.Drawing.Point(23, 211);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(92, 21);
            this.btnAddVenue.TabIndex = 31;
            this.btnAddVenue.Text = "New venue";
            this.btnAddVenue.UseVisualStyleBackColor = true;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // cbOrganizer
            // 
            this.cbOrganizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrganizer.FormattingEnabled = true;
            this.cbOrganizer.Location = new System.Drawing.Point(251, 184);
            this.cbOrganizer.Name = "cbOrganizer";
            this.cbOrganizer.Size = new System.Drawing.Size(184, 21);
            this.cbOrganizer.TabIndex = 39;
            // 
            // cbVenue
            // 
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Location = new System.Drawing.Point(23, 184);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(184, 21);
            this.cbVenue.TabIndex = 38;
            // 
            // lblEventCategory
            // 
            this.lblEventCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventCategory.AutoSize = true;
            this.lblEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEventCategory.Location = new System.Drawing.Point(20, 248);
            this.lblEventCategory.Name = "lblEventCategory";
            this.lblEventCategory.Size = new System.Drawing.Size(107, 17);
            this.lblEventCategory.TabIndex = 37;
            this.lblEventCategory.Text = "Event category:";
            // 
            // lblImgUrl
            // 
            this.lblImgUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImgUrl.AutoSize = true;
            this.lblImgUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImgUrl.Location = new System.Drawing.Point(20, 303);
            this.lblImgUrl.Name = "lblImgUrl";
            this.lblImgUrl.Size = new System.Drawing.Size(70, 17);
            this.lblImgUrl.TabIndex = 34;
            this.lblImgUrl.Text = "Image url:";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenueName.Location = new System.Drawing.Point(20, 164);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(53, 17);
            this.lblVenueName.TabIndex = 33;
            this.lblVenueName.Text = "Venue:";
            // 
            // lblOrganizer
            // 
            this.lblOrganizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrganizer.AutoSize = true;
            this.lblOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrganizer.Location = new System.Drawing.Point(248, 164);
            this.lblOrganizer.Name = "lblOrganizer";
            this.lblOrganizer.Size = new System.Drawing.Size(75, 17);
            this.lblOrganizer.TabIndex = 32;
            this.lblOrganizer.Text = "Organizer:";
            // 
            // lblEventName
            // 
            this.lblEventName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // cbTicketCategory
            // 
            this.cbTicketCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTicketCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTicketCategory.FormattingEnabled = true;
            this.cbTicketCategory.Location = new System.Drawing.Point(23, 268);
            this.cbTicketCategory.Name = "cbTicketCategory";
            this.cbTicketCategory.Size = new System.Drawing.Size(412, 24);
            this.cbTicketCategory.TabIndex = 27;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEventDate.Location = new System.Drawing.Point(23, 112);
            this.dtpEventDate.MinDate = new System.DateTime(2024, 1, 28, 0, 0, 0, 0);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(184, 23);
            this.dtpEventDate.TabIndex = 26;
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImageUrl.Location = new System.Drawing.Point(23, 323);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(412, 23);
            this.txtImageUrl.TabIndex = 24;
            // 
            // txtEventName
            // 
            this.txtEventName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventName.Location = new System.Drawing.Point(23, 49);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(412, 23);
            this.txtEventName.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(96, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 484);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 79);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "ADD EVENT";
            // 
            // FrmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAddEvent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.Name = "FrmAddEvent";
            this.helpProvider1.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEvent";
            this.Load += new System.EventHandler(this.FrmAddEvent_Load);
            this.gbAddEvent.ResumeLayout(false);
            this.gbAddEvent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddEvent;
        private System.Windows.Forms.Label lblEventCategory;
        private System.Windows.Forms.Label lblImgUrl;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblOrganizer;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.ComboBox cbTicketCategory;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbOrganizer;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.Button btnAddOrganizer;
        private System.Windows.Forms.Button btnAddVenue;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}