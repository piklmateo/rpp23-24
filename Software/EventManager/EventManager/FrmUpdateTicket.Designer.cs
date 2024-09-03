namespace EventManager
{
    partial class FrmUpdateTicket
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
            this.gbUpdateTicket = new System.Windows.Forms.GroupBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.lblTicketCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbTicketCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbUpdateTicket.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUpdateTicket
            // 
            this.gbUpdateTicket.Controls.Add(this.cbEvent);
            this.gbUpdateTicket.Controls.Add(this.lblTicketCategory);
            this.gbUpdateTicket.Controls.Add(this.lblPrice);
            this.gbUpdateTicket.Controls.Add(this.txtPrice);
            this.gbUpdateTicket.Controls.Add(this.lblAmount);
            this.gbUpdateTicket.Controls.Add(this.lblEvent);
            this.gbUpdateTicket.Controls.Add(this.cbTicketCategory);
            this.gbUpdateTicket.Controls.Add(this.txtAmount);
            this.gbUpdateTicket.Location = new System.Drawing.Point(12, 115);
            this.gbUpdateTicket.Name = "gbUpdateTicket";
            this.gbUpdateTicket.Size = new System.Drawing.Size(608, 224);
            this.gbUpdateTicket.TabIndex = 30;
            this.gbUpdateTicket.TabStop = false;
            this.gbUpdateTicket.Text = "Update ticket";
            // 
            // cbEvent
            // 
            this.cbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(23, 49);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(399, 24);
            this.cbEvent.TabIndex = 38;
            // 
            // lblTicketCategory
            // 
            this.lblTicketCategory.AutoSize = true;
            this.lblTicketCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTicketCategory.Location = new System.Drawing.Point(20, 156);
            this.lblTicketCategory.Name = "lblTicketCategory";
            this.lblTicketCategory.Size = new System.Drawing.Size(109, 17);
            this.lblTicketCategory.TabIndex = 37;
            this.lblTicketCategory.Text = "Ticket category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(20, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(23, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 23);
            this.txtPrice.TabIndex = 35;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAmount.Location = new System.Drawing.Point(235, 90);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = "Amount:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEvent.Location = new System.Drawing.Point(20, 29);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(48, 17);
            this.lblEvent.TabIndex = 29;
            this.lblEvent.Text = "Event:";
            // 
            // cbTicketCategory
            // 
            this.cbTicketCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTicketCategory.FormattingEnabled = true;
            this.cbTicketCategory.Location = new System.Drawing.Point(23, 176);
            this.cbTicketCategory.Name = "cbTicketCategory";
            this.cbTicketCategory.Size = new System.Drawing.Size(399, 24);
            this.cbTicketCategory.TabIndex = 27;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAmount.Location = new System.Drawing.Point(238, 110);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(184, 23);
            this.txtAmount.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(93, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 79);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "UPDATE TICKET";
            // 
            // FrmUpdateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbUpdateTicket);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateTicket";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateTicket";
            this.Load += new System.EventHandler(this.FrmUpdateTicket_Load);
            this.gbUpdateTicket.ResumeLayout(false);
            this.gbUpdateTicket.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdateTicket;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label lblTicketCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cbTicketCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}