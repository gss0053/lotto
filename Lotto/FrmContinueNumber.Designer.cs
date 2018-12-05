namespace Lotto
{
    partial class FrmContinueNumber
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
            this.continueNumView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.continueNumView)).BeginInit();
            this.SuspendLayout();
            // 
            // continueNumView
            // 
            this.continueNumView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.continueNumView.Location = new System.Drawing.Point(12, 38);
            this.continueNumView.MultiSelect = false;
            this.continueNumView.Name = "continueNumView";
            this.continueNumView.RowTemplate.Height = 23;
            this.continueNumView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.continueNumView.Size = new System.Drawing.Size(633, 426);
            this.continueNumView.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(524, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // FrmContinueNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 475);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.continueNumView);
            this.Name = "FrmContinueNumber";
            this.Text = "FrmContinueNumber";
            this.Load += new System.EventHandler(this.FrmContinueNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.continueNumView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView continueNumView;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}