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
            this.components = new System.ComponentModel.Container();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.ByNumberChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_Start_Number = new System.Windows.Forms.ComboBox();
            this.cbo_End_Number = new System.Windows.Forms.ComboBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.chk_Bonus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ByNumberChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ByNumberChart
            // 

            chartArea5.Name = "ChartArea1";
            this.ByNumberChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ByNumberChart.Legends.Add(legend5);
            this.ByNumberChart.Location = new System.Drawing.Point(12, 72);
            this.ByNumberChart.Name = "ByNumberChart";
            this.ByNumberChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.MarkerSize = 1;
            series5.Name = "Series1";
            this.ByNumberChart.Series.Add(series5);

            this.ByNumberChart.Size = new System.Drawing.Size(763, 571);
            this.ByNumberChart.TabIndex = 0;
            this.ByNumberChart.Text = "chart1";
            this.ByNumberChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ByNumberChart_MouseMove);
            // 
            // cbo_Start_Number
            // 
            this.cbo_Start_Number.FormattingEnabled = true;
            this.cbo_Start_Number.Location = new System.Drawing.Point(249, 27);
            this.cbo_Start_Number.Name = "cbo_Start_Number";
            this.cbo_Start_Number.Size = new System.Drawing.Size(121, 20);
            this.cbo_Start_Number.TabIndex = 1;

            //this.cbo_Start_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_Start_Number_KeyUp);

            // 
            // cbo_End_Number
            // 
            this.cbo_End_Number.FormattingEnabled = true;
            this.cbo_End_Number.Location = new System.Drawing.Point(411, 27);
            this.cbo_End_Number.Name = "cbo_End_Number";
            this.cbo_End_Number.Size = new System.Drawing.Size(121, 20);
            this.cbo_End_Number.TabIndex = 2;

            //this.cbo_End_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_End_Number_KeyUp);

            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(585, 25);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "조회";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // chk_Bonus
            // 
            this.chk_Bonus.AutoSize = true;
            this.chk_Bonus.Location = new System.Drawing.Point(141, 33);
            this.chk_Bonus.Name = "chk_Bonus";
            this.chk_Bonus.Size = new System.Drawing.Size(15, 14);
            this.chk_Bonus.TabIndex = 4;
            this.chk_Bonus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "회차선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "보너스 미포함";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "부터";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "까지";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "부터";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "까지";
            // 
            // Frm_ByNumberChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_Bonus);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.cbo_End_Number);
            this.Controls.Add(this.cbo_Start_Number);
            this.Controls.Add(this.ByNumberChart);
            this.Name = "Frm_ByNumberChart";
            this.Text = "Frm_ByNumberChart";
            this.Load += new System.EventHandler(this.Frm_ByNumberChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ByNumberChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ByNumberChart;
        private System.Windows.Forms.ComboBox cbo_Start_Number;
        private System.Windows.Forms.ComboBox cbo_End_Number;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.CheckBox chk_Bonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip myTooltip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}