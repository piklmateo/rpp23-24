namespace EventManager
{
    partial class FrmAddOrganizer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddOrganizer = new System.Windows.Forms.Button();
            this.gbAddOrganizer = new System.Windows.Forms.GroupBox();
            this.lblOrganizerName = new System.Windows.Forms.Label();
            this.txtOrganizerName = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbAddOrganizer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(93, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddOrganizer
            // 
            this.btnAddOrganizer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddOrganizer.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganizer.Location = new System.Drawing.Point(12, 120);
            this.btnAddOrganizer.Name = "btnAddOrganizer";
            this.btnAddOrganizer.Size = new System.Drawing.Size(75, 30);
            this.btnAddOrganizer.TabIndex = 35;
            this.btnAddOrganizer.Text = "ADD";
            this.btnAddOrganizer.UseVisualStyleBackColor = false;
            this.btnAddOrganizer.Click += new System.EventHandler(this.btnAddOrganizer_Click);
            // 
            // gbAddOrganizer
            // 
            this.gbAddOrganizer.Controls.Add(this.lblOrganizerName);
            this.gbAddOrganizer.Controls.Add(this.txtOrganizerName);
            this.gbAddOrganizer.Location = new System.Drawing.Point(12, 12);
            this.gbAddOrganizer.Name = "gbAddOrganizer";
            this.gbAddOrganizer.Size = new System.Drawing.Size(349, 102);
            this.gbAddOrganizer.TabIndex = 34;
            this.gbAddOrganizer.TabStop = false;
            this.gbAddOrganizer.Text = "New organizer";
            // 
            // lblOrganizerName
            // 
            this.lblOrganizerName.AutoSize = true;
            this.lblOrganizerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrganizerName.Location = new System.Drawing.Point(6, 29);
            this.lblOrganizerName.Name = "lblOrganizerName";
            this.lblOrganizerName.Size = new System.Drawing.Size(114, 17);
            this.lblOrganizerName.TabIndex = 29;
            this.lblOrganizerName.Text = "Organizer name:";
            // 
            // txtOrganizerName
            // 
            this.txtOrganizerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOrganizerName.Location = new System.Drawing.Point(9, 49);
            this.txtOrganizerName.Name = "txtOrganizerName";
            this.txtOrganizerName.Size = new System.Drawing.Size(240, 23);
            this.txtOrganizerName.TabIndex = 20;
            // 
            // FrmAddOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddOrganizer);
            this.Controls.Add(this.gbAddOrganizer);
            this.MaximizeBox = false;
            this.Name = "FrmAddOrganizer";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrganizer";
            this.gbAddOrganizer.ResumeLayout(false);
            this.gbAddOrganizer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddOrganizer;
        private System.Windows.Forms.GroupBox gbAddOrganizer;
        private System.Windows.Forms.Label lblOrganizerName;
        private System.Windows.Forms.TextBox txtOrganizerName;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}