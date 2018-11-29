namespace Lotto
{
    partial class Frm_ByNumberChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ByNumberChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ByNumberChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ByNumberChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ByNumberChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ByNumberChart.Legends.Add(legend2);
            this.ByNumberChart.Location = new System.Drawing.Point(12, 21);
            this.ByNumberChart.Name = "ByNumberChart";
            this.ByNumberChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ByNumberChart.Series.Add(series2);
            this.ByNumberChart.Size = new System.Drawing.Size(300, 300);
            this.ByNumberChart.TabIndex = 0;
            this.ByNumberChart.Text = "chart1";
            // 
            // Frm_ByNumberChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ByNumberChart);
            this.Name = "Frm_ByNumberChart";
            this.Text = "Frm_ByNumberChart";
            this.Load += new System.EventHandler(this.Frm_ByNumberChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ByNumberChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ByNumberChart;
    }
}