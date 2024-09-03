namespace EventManager
{
    partial class FrmUserEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserEvents));
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboUserEvents = new System.Windows.Forms.ComboBox();
            this.dgvUserEvents = new System.Windows.Forms.DataGridView();
            this.btnUnrateEvents = new System.Windows.Forms.Button();
            this.btnSelectedEvent = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.lblMyEvents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserEvents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(842, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboUserEvents
            // 
            this.cboUserEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUserEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboUserEvents.FormattingEnabled = true;
            this.cboUserEvents.Items.AddRange(new object[] {
            "All Events",
            "Attended Events",
            "Unattended Events"});
            this.cboUserEvents.Location = new System.Drawing.Point(635, 107);
            this.cboUserEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUserEvents.Name = "cboUserEvents";
            this.cboUserEvents.Size = new System.Drawing.Size(201, 26);
            this.cboUserEvents.TabIndex = 3;
            // 
            // dgvUserEvents
            // 
            this.dgvUserEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserEvents.Location = new System.Drawing.Point(19, 151);
            this.dgvUserEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUserEvents.Name = "dgvUserEvents";
            this.dgvUserEvents.RowHeadersWidth = 51;
            this.dgvUserEvents.RowTemplate.Height = 24;
            this.dgvUserEvents.Size = new System.Drawing.Size(922, 316);
            this.dgvUserEvents.TabIndex = 4;
            // 
            // btnUnrateEvents
            // 
            this.btnUnrateEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnrateEvents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUnrateEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnrateEvents.Location = new System.Drawing.Point(805, 490);
            this.btnUnrateEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnrateEvents.Name = "btnUnrateEvents";
            this.btnUnrateEvents.Size = new System.Drawing.Size(133, 41);
            this.btnUnrateEvents.TabIndex = 5;
            this.btnUnrateEvents.Text = "Unrate Events";
            this.btnUnrateEvents.UseVisualStyleBackColor = false;
            this.btnUnrateEvents.Click += new System.EventHandler(this.btnUnrateEvents_Click);
            // 
            // btnSelectedEvent
            // 
            this.btnSelectedEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectedEvent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelectedEvent.Location = new System.Drawing.Point(19, 485);
            this.btnSelectedEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectedEvent.Name = "btnSelectedEvent";
            this.btnSelectedEvent.Size = new System.Drawing.Size(133, 53);
            this.btnSelectedEvent.TabIndex = 6;
            this.btnSelectedEvent.Text = "Show details of event";
            this.btnSelectedEvent.UseVisualStyleBackColor = false;
            this.btnSelectedEvent.Click += new System.EventHandler(this.btnSelectedEvent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.imgBack);
            this.panel1.Controls.Add(this.lblMyEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 97);
            this.panel1.TabIndex = 34;
            // 
            // imgBack
            // 
            this.imgBack.Image = ((System.Drawing.Image)(resources.GetObject("imgBack.Image")));
            this.imgBack.Location = new System.Drawing.Point(16, 15);
            this.imgBack.Margin = new System.Windows.Forms.Padding(4);
            this.imgBack.Name = "imgBack";
            this.imgBack.Size = new System.Drawing.Size(63, 58);
            this.imgBack.TabIndex = 26;
            this.imgBack.TabStop = false;
            this.imgBack.Click += new System.EventHandler(this.imgBack_Click);
            // 
            // lblMyEvents
            // 
            this.lblMyEvents.AutoSize = true;
            this.lblMyEvents.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyEvents.Location = new System.Drawing.Point(87, 27);
            this.lblMyEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyEvents.Name = "lblMyEvents";
            this.lblMyEvents.Size = new System.Drawing.Size(195, 46);
            this.lblMyEvents.TabIndex = 7;
            this.lblMyEvents.Text = "MY EVENTS";
            // 
            // FrmUserEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelectedEvent);
            this.Controls.Add(this.btnUnrateEvents);
            this.Controls.Add(this.dgvUserEvents);
            this.Controls.Add(this.cboUserEvents);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUserEvents";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Events";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboUserEvents;
        private System.Windows.Forms.DataGridView dgvUserEvents;
        private System.Windows.Forms.Button btnUnrateEvents;
        private System.Windows.Forms.Button btnSelectedEvent;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Label lblMyEvents;
    }
}