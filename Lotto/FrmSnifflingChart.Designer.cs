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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).BeginInit();
            this.SuspendLayout();
            // 
            // snifflingView
            // 
            this.snifflingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snifflingView.Location = new System.Drawing.Point(12, 38);
            this.snifflingView.MultiSelect = false;
            this.snifflingView.Name = "snifflingView";
            this.snifflingView.RowTemplate.Height = 23;
            this.snifflingView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.snifflingView.Size = new System.Drawing.Size(701, 466);
            this.snifflingView.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(592, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // FrmSnifflingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.snifflingView);
            this.Name = "FrmSnifflingChart";
            this.Text = "FrmSnifflingChart";
            this.Load += new System.EventHandler(this.FrmSnifflingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView snifflingView;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}