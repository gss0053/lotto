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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.snifflingView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.snifflingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.snifflingToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingChart)).BeginInit();
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
            // snifflingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.snifflingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.snifflingChart.Legends.Add(legend1);
            this.snifflingChart.Location = new System.Drawing.Point(719, 12);
            this.snifflingChart.Name = "snifflingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "홀수";
            dataPoint2.AxisLabel = "짝수";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.snifflingChart.Series.Add(series1);
            this.snifflingChart.Size = new System.Drawing.Size(508, 492);
            this.snifflingChart.TabIndex = 2;
            this.snifflingChart.Text = "chart1";
            this.snifflingChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.snifflingChart_MouseMove);
            // 
            // FrmSnifflingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 530);
            this.Controls.Add(this.snifflingChart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.snifflingView);
            this.Name = "FrmSnifflingChart";
            this.Text = "FrmSnifflingChart";
            this.Load += new System.EventHandler(this.FrmSnifflingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView snifflingView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart snifflingChart;
        private System.Windows.Forms.ToolTip snifflingToolTip;
    }
}