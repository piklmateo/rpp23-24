namespace EventManager
{
    partial class FrmRateEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRateEvents));
            this.btnRateEvent = new System.Windows.Forms.Button();
            this.dgvRateEvents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.lblRateEvents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateEvents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRateEvent
            // 
            this.btnRateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRateEvent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRateEvent.Location = new System.Drawing.Point(881, 588);
            this.btnRateEvent.Name = "btnRateEvent";
            this.btnRateEvent.Size = new System.Drawing.Size(133, 41);
            this.btnRateEvent.TabIndex = 6;
            this.btnRateEvent.Text = "Rate Event";
            this.btnRateEvent.UseVisualStyleBackColor = false;
            this.btnRateEvent.Click += new System.EventHandler(this.btnRateEvent_Click);
            // 
            // dgvRateEvents
            // 
            this.dgvRateEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRateEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRateEvents.Location = new System.Drawing.Point(18, 104);
            this.dgvRateEvents.Name = "dgvRateEvents";
            this.dgvRateEvents.RowHeadersWidth = 51;
            this.dgvRateEvents.RowTemplate.Height = 24;
            this.dgvRateEvents.Size = new System.Drawing.Size(996, 463);
            this.dgvRateEvents.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.imgBack);
            this.panel1.Controls.Add(this.lblRateEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 97);
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
            // lblRateEvents
            // 
            this.lblRateEvents.AutoSize = true;
            this.lblRateEvents.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateEvents.Location = new System.Drawing.Point(87, 27);
            this.lblRateEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRateEvents.Name = "lblRateEvents";
            this.lblRateEvents.Size = new System.Drawing.Size(221, 46);
            this.lblRateEvents.TabIndex = 7;
            this.lblRateEvents.Text = "RATE EVENTS";
            // 
            // FrmRateEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRateEvents);
            this.Controls.Add(this.btnRateEvent);
            this.Name = "FrmRateEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Events";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRateEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRateEvent;
        private System.Windows.Forms.DataGridView dgvRateEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Label lblRateEvents;
    }
}