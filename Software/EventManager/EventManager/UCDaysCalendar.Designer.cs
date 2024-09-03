namespace EventManager {
    partial class UCDaysCalendar {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtDaysCalendar = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.Label();
            this.btnShowEventInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDaysCalendar
            // 
            this.txtDaysCalendar.AutoSize = true;
            this.txtDaysCalendar.Location = new System.Drawing.Point(14, 11);
            this.txtDaysCalendar.Name = "txtDaysCalendar";
            this.txtDaysCalendar.Size = new System.Drawing.Size(14, 16);
            this.txtDaysCalendar.TabIndex = 0;
            this.txtDaysCalendar.Text = "0";
            // 
            // txtEvent
            // 
            this.txtEvent.AutoSize = true;
            this.txtEvent.Location = new System.Drawing.Point(14, 27);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(0, 16);
            this.txtEvent.TabIndex = 1;
            // 
            // btnShowEventInfo
            // 
            this.btnShowEventInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowEventInfo.FlatAppearance.BorderSize = 0;
            this.btnShowEventInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEventInfo.Location = new System.Drawing.Point(40, 33);
            this.btnShowEventInfo.Name = "btnShowEventInfo";
            this.btnShowEventInfo.Size = new System.Drawing.Size(10, 10);
            this.btnShowEventInfo.TabIndex = 2;
            this.btnShowEventInfo.UseVisualStyleBackColor = false;
            this.btnShowEventInfo.Visible = false;
            this.btnShowEventInfo.Click += new System.EventHandler(this.btnShowEventInfo_Click);
            // 
            // UCDaysCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnShowEventInfo);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtDaysCalendar);
            this.Name = "UCDaysCalendar";
            this.Size = new System.Drawing.Size(76, 53);
            this.Load += new System.EventHandler(this.UCDaysCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDaysCalendar;
        private System.Windows.Forms.Label txtEvent;
        private System.Windows.Forms.Button btnShowEventInfo;
    }
}
