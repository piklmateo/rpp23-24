namespace EventManager
{
    partial class FrmEventCheck
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
            this.dgvEventCheck = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventCheck
            // 
            this.dgvEventCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventCheck.Location = new System.Drawing.Point(9, 65);
            this.dgvEventCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEventCheck.Name = "dgvEventCheck";
            this.dgvEventCheck.RowHeadersWidth = 51;
            this.dgvEventCheck.RowTemplate.Height = 24;
            this.dgvEventCheck.Size = new System.Drawing.Size(582, 291);
            this.dgvEventCheck.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Users with valid tickets:";
            // 
            // FrmEventCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventCheck);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEventCheck";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FrmEventCheck";
            this.Load += new System.EventHandler(this.FrmEventCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}