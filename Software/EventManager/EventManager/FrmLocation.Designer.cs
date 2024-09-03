namespace EventManager {
    partial class FrmLocation {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblRateEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRateEvents
            // 
            this.lblRateEvents.AutoSize = true;
            this.lblRateEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRateEvents.Location = new System.Drawing.Point(12, 25);
            this.lblRateEvents.Name = "lblRateEvents";
            this.lblRateEvents.Size = new System.Drawing.Size(78, 32);
            this.lblRateEvents.TabIndex = 3;
            this.lblRateEvents.Text = "MAP";
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRateEvents);
            this.Name = "FrmLocation";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRateEvents;
    }
}