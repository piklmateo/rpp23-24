namespace EventManager
{
    partial class FrmUserTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserTransactions));
            this.dgvUserTransactions = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.lblMyTransactions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTransactions)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserTransactions
            // 
            this.dgvUserTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTransactions.Location = new System.Drawing.Point(19, 103);
            this.dgvUserTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUserTransactions.Name = "dgvUserTransactions";
            this.dgvUserTransactions.RowHeadersWidth = 51;
            this.dgvUserTransactions.RowTemplate.Height = 24;
            this.dgvUserTransactions.Size = new System.Drawing.Size(771, 335);
            this.dgvUserTransactions.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.imgBack);
            this.panel1.Controls.Add(this.lblMyTransactions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
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
            // lblMyTransactions
            // 
            this.lblMyTransactions.AutoSize = true;
            this.lblMyTransactions.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyTransactions.Location = new System.Drawing.Point(87, 27);
            this.lblMyTransactions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyTransactions.Name = "lblMyTransactions";
            this.lblMyTransactions.Size = new System.Drawing.Size(320, 46);
            this.lblMyTransactions.TabIndex = 7;
            this.lblMyTransactions.Text = "MY TRANSACTIONS";
            // 
            // FrmUserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUserTransactions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUserTransactions";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Transactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTransactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUserTransactions;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.Label lblMyTransactions;
    }
}