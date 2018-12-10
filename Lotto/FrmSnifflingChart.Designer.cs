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
            this.snifflingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.snifflingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.cboStart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // snifflingView
            // 
            this.snifflingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snifflingView.Location = new System.Drawing.Point(12, 78);
            this.snifflingView.MultiSelect = false;
            this.snifflingView.Name = "snifflingView";
            this.snifflingView.RowTemplate.Height = 23;
            this.snifflingView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.snifflingView.Size = new System.Drawing.Size(642, 426);
            this.snifflingView.TabIndex = 0;
            // 
            // snifflingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.snifflingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.snifflingChart.Legends.Add(legend1);
            this.snifflingChart.Location = new System.Drawing.Point(660, 12);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "까지";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "부터";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "까지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "부터";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "회차선택";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(498, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboEnd
            // 
            this.cboEnd.FormattingEnabled = true;
            this.cboEnd.Location = new System.Drawing.Point(323, 23);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(121, 20);
            this.cboEnd.TabIndex = 24;
            // 
            // cboStart
            // 
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Location = new System.Drawing.Point(161, 23);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(121, 20);
            this.cboStart.TabIndex = 23;
            this.cboStart.SelectedIndexChanged += new System.EventHandler(this.cboStart_SelectedIndexChanged);
            // 
            // FrmSnifflingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboEnd);
            this.Controls.Add(this.cboStart);
            this.Controls.Add(this.snifflingChart);
            this.Controls.Add(this.snifflingView);
            this.Name = "FrmSnifflingChart";
            this.Text = "FrmSnifflingChart";
            this.Load += new System.EventHandler(this.FrmSnifflingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snifflingView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snifflingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView snifflingView;
        private System.Windows.Forms.DataVisualization.Charting.Chart snifflingChart;
        private System.Windows.Forms.ToolTip snifflingToolTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboEnd;
        private System.Windows.Forms.ComboBox cboStart;
    }
}