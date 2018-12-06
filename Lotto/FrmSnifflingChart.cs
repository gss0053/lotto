﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lotto
{
    public partial class FrmSnifflingChart : Form
    {
        List<LottoResult> lottoList = new List<LottoResult>();
        List<int> numberList = new List<int>();
        private string even = string.Empty;
        private string odd = string.Empty;
        private int evenNum = 0;
        private int oddNum = 0;
        private int scrollOffset = int.Parse(ConfigurationManager.AppSettings.GetValues("scrollOffset")[0]);
        public FrmSnifflingChart(List<LottoResult> lottoList)
        {
            InitializeComponent();
            this.lottoList = lottoList;
        }
        public void Addtocb()
        {
            int i = 0;
            foreach (var item in lottoList)
            {
                comboBox1.Items.Add(lottoList.Count - i);
                i++;
            }
        }
        private void FrmSnifflingChart_Load(object sender, EventArgs e)
        {
            DataTable snifflingTab = new DataTable();

            this.Text = "홀짝 통계";
            snifflingTab.Columns.Add("회차");
            snifflingTab.Columns.Add("당첨일자");
            snifflingTab.Columns.Add("당첨번호");
            snifflingTab.Columns.Add("홀수");
            snifflingTab.Columns.Add("짝수");
            snifflingTab.Columns.Add("번호합");
            Addtocb();

            foreach (var item in lottoList)
            {
                even = string.Empty;
                odd = string.Empty;
                numberList.Clear();

                DataRow row = snifflingTab.NewRow();

                numberList.Add(item.Number1);
                numberList.Add(item.Number2);
                numberList.Add(item.Number3);
                numberList.Add(item.Number4);
                numberList.Add(item.Number5);
                numberList.Add(item.Number6);

                for (int i = 0; i < numberList.Count; i++)
                {
                    switch (numberList[i] % 2)
                    {
                        case 0:
                            evenNum++;
                            even += numberList[i].ToString() + ", ";
                            row["짝수"] = even.Substring(0, even.Length - 2);
                            break;
                        case 1:
                            oddNum++;
                            odd += numberList[i].ToString() + ", ";
                            row["홀수"] = odd.Substring(0, odd.Length - 2);
                            break;
                    }
                }

                row["회차"] = item.Turn;
                row["당첨번호"] = item.Number1 + ", " + item.Number2 + ", " + item.Number3 + ", " + item.Number4 + ", " + item.Number5 + ", " + item.Number6;
                row["당첨일자"] = item.Date;
                row["번호합"] = item.Number1 + item.Number2 + item.Number3 + item.Number4 + item.Number5 + item.Number6;

                snifflingTab.Rows.Add(row);
            }
            snifflingView.DataSource = snifflingTab;

            snifflingView.Columns["당첨번호"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["당첨일자"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["짝수"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["홀수"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["번호합"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            snifflingChart.Series[0].Name = "홀짝";
            snifflingChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            snifflingChart.Series[0].Points[0].YValues = new double[] { oddNum };
            snifflingChart.Series[0].Points[1].YValues = new double[] { evenNum };
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex < scrollOffset)
            {
                snifflingView.FirstDisplayedScrollingRowIndex = 0;
            }
            else if (lottoList.Count - comboBox1.SelectedIndex < scrollOffset)
            {
                snifflingView.FirstDisplayedScrollingRowIndex = comboBox1.SelectedIndex - scrollOffset;
            }
            else
            {
                snifflingView.FirstDisplayedScrollingRowIndex = int.Parse(comboBox1.SelectedIndex.ToString()) - scrollOffset;
            }
            snifflingView.Rows[comboBox1.SelectedIndex].Selected = true;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(comboBox1.Text) < lottoList.Count || int.Parse(comboBox1.Text) == lottoList.Count)
                {
                    comboBox1.SelectedIndex = lottoList.Count - int.Parse(comboBox1.Text);
                }
                else if (int.Parse(comboBox1.Text) > lottoList.Count)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }        

        private void snifflingChart_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos = e.Location;
            snifflingToolTip.RemoveAll();
            var hit = snifflingChart.HitTest(pos.X, pos.Y, ChartElementType.DataPoint);

            if (hit.ChartElementType == ChartElementType.DataPoint)
            {
                var yvalue = (hit.Object as DataPoint).YValues[0];
                var xvalue = hit.Object as DataPoint;

                var per = Math.Round(((xvalue.YValues[0] / (snifflingChart.Series[0].Points[0].YValues[0] + snifflingChart.Series[0].Points[1].YValues[0])) * 100), 2);
                snifflingToolTip.Show(xvalue.AxisLabel + " " + yvalue + "회" + " " + per + "%", snifflingChart, new Point(pos.X + 10, pos.Y + 15));
            }
        }
    }
}

