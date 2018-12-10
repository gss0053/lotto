using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lotto
{
    public partial class FrmContinueNumber : Form
    {
        List<LottoResult> lottoList;
        List<int> numberList;
        public FrmContinueNumber(List<LottoResult> lottoList)
        {
            InitializeComponent();
            this.lottoList = lottoList;
            numberList = new List<int>();
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
        private void FrmContinueNumber_Load(object sender, EventArgs e)
        {
            this.Text = "연속번호 통계";

            Addtocb();
            GetDataTable(0, cboStart.Items.Count);
            for (int i = 0; i < cboStart.Items.Count; i++)
            {
                for (int j = 4; j < 9; j++)
                {

                    if (int.Parse(continueNumView.Rows[(cboStart.SelectedIndex + 1) + i].Cells[j].Value.ToString()) - int.Parse(continueNumView.Rows[(cboStart.SelectedIndex + 1) + i].Cells[j + 1].Value.ToString()) == -1)
                    {
                        continueNumView.Rows[(cboStart.SelectedIndex + 1) + i].Cells[j].Style.BackColor = Color.Yellow;
                        continueNumView.Rows[(cboStart.SelectedIndex + 1) + i].Cells[j + 1].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
        List<string> conNumList;
        private void GetDataTable(int start, int end)
        {
            DataTable continueTab = new DataTable();
            continueTab.Clear();

            continueTab.Columns.Add("회차");
            continueTab.Columns.Add("당첨일자");
            continueTab.Columns.Add("당첨번호");
            continueTab.Columns.Add("연속번호");
            continueTab.Columns.Add("번호 1");
            continueTab.Columns.Add("번호 2");
            continueTab.Columns.Add("번호 3");
            continueTab.Columns.Add("번호 4");
            continueTab.Columns.Add("번호 5");
            continueTab.Columns.Add("번호 6");
            continueTab.Columns.Add("연속번호 출현횟수");

            for (int k = start; k < end; k++)
            {
                int cnt = 0;
                string conNum = string.Empty;
                conNumList = new List<string>();
                numberList.Clear();
                conNumList.Clear();
                DataRow row = continueTab.NewRow();

                numberList.Add(lottoList[k].Number1);
                numberList.Add(lottoList[k].Number2);
                numberList.Add(lottoList[k].Number3);
                numberList.Add(lottoList[k].Number4);
                numberList.Add(lottoList[k].Number5);
                numberList.Add(lottoList[k].Number6);

                for (int i = 0; i < numberList.Count; i++)
                {
                    for (int j = i + 1; j < numberList.Count; j++)
                    {
                        if (numberList[i] - numberList[j] == -1)
                        {
                            conNumList.Add(numberList[i].ToString());
                            conNumList.Add(numberList[j].ToString());
                            cnt++;
                        }
                    }
                }

                for (int i = 0; i < conNumList.Count; i++)
                {
                    for (int j = i + 1; j < conNumList.Count; j++)
                    {
                        if (conNumList[i] == conNumList[j])
                        {
                            conNumList.RemoveAt(i);
                        }
                    }
                }

                foreach (string con in conNumList)
                {
                    conNum += con + ", ";
                }

                if (conNum.Length != 0)
                {
                    conNum = conNum.Substring(0, conNum.Length - 2);
                }

                row["회차"] = lottoList[k].Turn;
                row["연속번호"] = conNum;
                row["당첨일자"] = lottoList[k].Date;
                row["당첨번호"] = lottoList[k].Number1 + ", " + lottoList[k].Number2 + ", " + lottoList[k].Number3 + ", " + lottoList[k].Number4 + ", " + lottoList[k].Number5 + ", " + lottoList[k].Number6;
                row["번호 1"] = numberList[0];
                row["번호 2"] = numberList[1];
                row["번호 3"] = numberList[2];
                row["번호 4"] = numberList[3];
                row["번호 5"] = numberList[4];
                row["번호 6"] = numberList[5];
                row["연속번호 출현횟수"] = cnt + "쌍";

                continueTab.Rows.Add(row);

            }
            continueNumView.DataSource = continueTab;
            continueNumView.Columns["연속번호"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            continueNumView.Columns["당첨번호"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            continueNumView.Columns["당첨일자"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            continueNumView.Columns["연속번호 출현횟수"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            if (cboEnd.Text == "" && cboStart.Text == "")
            {
                cboEnd.Text = lottoList[0].Turn.ToString();
                //cboEnd.SelectedIndex = 0;
                //cboStart.Text = lottoList[0].Turn.ToString();
            }


        }

        private void cboStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboStart.SelectedIndex < 7)
                {
                    continueNumView.FirstDisplayedScrollingRowIndex = 0;
                }
                else if (lottoList.Count - cboStart.SelectedIndex < 7)
                {
                    continueNumView.FirstDisplayedScrollingRowIndex = cboStart.SelectedIndex - 7;
                }
                else
                {
                    continueNumView.FirstDisplayedScrollingRowIndex = int.Parse(cboStart.SelectedIndex.ToString()) - 7;
                }
                continueNumView.Rows[cboStart.SelectedIndex].Selected = true;
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

            label6.Text = cboStart.Text + "회";
            label5.Text = cboEnd.Text + "회";

            GetDataTable(cboEnd.SelectedIndex, cboStart.SelectedIndex + 1);
            for (int i = 0; i <= int.Parse(cboEnd.Text) - int.Parse(cboStart.Text); i++)
            {
                for (int j = 4; j < 9; j++)
                {
                    if (int.Parse(continueNumView.Rows[i].Cells[j].Value.ToString()) - int.Parse(continueNumView.Rows[i].Cells[j + 1].Value.ToString()) == -1)
                    {
                        continueNumView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        continueNumView.Rows[i].Cells[j + 1].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
