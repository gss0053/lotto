namespace Lotto
{
    partial class FrmSnifflingChart
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
            this.snifflingView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).BeginInit();
            this.SuspendLayout();
            // 
            // snifflingView
            // 
            this.snifflingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snifflingView.Location = new System.Drawing.Point(12, 189);
            this.snifflingView.Name = "snifflingView";
            this.snifflingView.RowTemplate.Height = 23;
            this.snifflingView.Size = new System.Drawing.Size(1060, 527);
            this.snifflingView.TabIndex = 0;
            // 
            // FrmSnifflingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 728);
            this.Controls.Add(this.snifflingView);
            this.Name = "FrmSnifflingChart";
            this.Text = "FrmSnifflingChart";
            this.Load += new System.EventHandler(this.FrmSnifflingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView snifflingView;
    }
}