using System;
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
        DataTable snifflingTab;
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
                cboStart.Items.Add(lottoList.Count - i);
                i++;
            }
        }
        private void FrmSnifflingChart_Load(object sender, EventArgs e)
        {
            Addtocb();
            GetDataTable(0, cboStart.Items.Count);

            snifflingChart.Series[0].Name = "홀짝";
            snifflingChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            snifflingChart.Series[0].Points[0].YValues = new double[] { oddNum };
            snifflingChart.Series[0].Points[1].YValues = new double[] { evenNum };
        }

        private void GetDataTable(int start, int end)
        {
            oddNum = 0;
            evenNum = 0;
            snifflingView.DataSource = null;
            snifflingTab = new DataTable();

            this.Text = "홀짝 통계";
            snifflingTab.Columns.Add("회차");
            snifflingTab.Columns.Add("당첨일자");
            snifflingTab.Columns.Add("당첨번호");
            snifflingTab.Columns.Add("홀수");
            snifflingTab.Columns.Add("짝수");
            snifflingTab.Columns.Add("번호합");

            for (int i = start; i < end; i++)
            {
                even = string.Empty;
                odd = string.Empty;
                numberList.Clear();

                DataRow row = snifflingTab.NewRow();

                numberList.Add(lottoList[i].Number1);
                numberList.Add(lottoList[i].Number2);
                numberList.Add(lottoList[i].Number3);
                numberList.Add(lottoList[i].Number4);
                numberList.Add(lottoList[i].Number5);
                numberList.Add(lottoList[i].Number6);

                for (int j = 0; j < numberList.Count; j++)
                {
                    switch (numberList[j] % 2)
                    {
                        case 0:
                            evenNum++;
                            even += numberList[j].ToString() + ", ";
                            row["짝수"] = even.Substring(0, even.Length - 2);
                            break;
                        case 1:
                            oddNum++;
                            odd += numberList[j].ToString() + ", ";
                            row["홀수"] = odd.Substring(0, odd.Length - 2);
                            break;
                    }
                }

                row["회차"] = lottoList[i].Turn;
                row["당첨번호"] = lottoList[i].Number1 + ", " + lottoList[i].Number2 + ", " + lottoList[i].Number3 + ", " + lottoList[i].Number4 + ", " + lottoList[i].Number5 + ", " + lottoList[i].Number6;
                row["당첨일자"] = lottoList[i].Date;
                row["번호합"] = lottoList[i].Number1 + lottoList[i].Number2 + lottoList[i].Number3 + lottoList[i].Number4 + lottoList[i].Number5 + lottoList[i].Number6;

                snifflingTab.Rows.Add(row);
            }
            snifflingView.DataSource = snifflingTab;

            snifflingView.Columns["당첨번호"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["당첨일자"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["짝수"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["홀수"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            snifflingView.Columns["번호합"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void cboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboStart.SelectedIndex < 7)
                {
                    snifflingView.FirstDisplayedScrollingRowIndex = 0;
                }
                else if (lottoList.Count - cboStart.SelectedIndex < 7)
                {
                    snifflingView.FirstDisplayedScrollingRowIndex = cboStart.SelectedIndex - 7;
                }
                else
                {
                    snifflingView.FirstDisplayedScrollingRowIndex = int.Parse(cboStart.SelectedIndex.ToString()) - 7;
                }
                snifflingView.Rows[cboStart.SelectedIndex].Selected = true;
                GetEndCbx();
            }
            catch (Exception)
            {
                Addtocb();
                GetEndCbx();
                return;
            }
        }

        private void GetEndCbx()
        {
            cboEnd.Items.Clear();
            int j = 0;
            for (int i = lottoList.Count - cboStart.SelectedIndex; i < lottoList.Count + 1; i++)
            {
                cboEnd.Items.Add(lottoList.Count - j);
                j++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label6.Text = cboStart.Text + "회";
            label5.Text = cboEnd.Text + "회";

            GetDataTable(cboEnd.SelectedIndex, cboStart.SelectedIndex + 1);

            snifflingChart.Series[0].Points[0].YValues = new double[] { oddNum };
            snifflingChart.Series[0].Points[1].YValues = new double[] { evenNum };
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (int.Parse(comboBox1.Text) < lottoList.Count || int.Parse(comboBox1.Text) == lottoList.Count)
            //    {
            //        comboBox1.SelectedIndex = lottoList.Count - int.Parse(comboBox1.Text);
            //    }
            //    else if (int.Parse(comboBox1.Text) > lottoList.Count)
            //    {
            //        comboBox1.SelectedIndex = 0;
            //    }
            //}
        }
    }
}

