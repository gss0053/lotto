using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class FrmSnifflingChart : Form
    {
        List<LottoResult> lottoList = new List<LottoResult>();
        List<int> numberList = new List<int>();
        public FrmSnifflingChart(List<LottoResult> lottoList)
        {
            InitializeComponent();
            this.lottoList = lottoList;
        }

        private void FrmSnifflingChart_Load(object sender, EventArgs e)
        {
            DataTable snifflingTab = new DataTable();
            

            snifflingTab.Columns.Add("회차");
            snifflingTab.Columns.Add("당첨일자");
            snifflingTab.Columns.Add("당첨번호");
            snifflingTab.Columns.Add("홀수");
            snifflingTab.Columns.Add("짝수");
            snifflingTab.Columns.Add("번호합");
            

            foreach (var item in lottoList)
            {
                string even = string.Empty;
                string odd = string.Empty;
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
                            even += numberList[i].ToString() + ", ";
                            row["짝수"] = even.Substring(0, even.Length - 2);
                            break;
                        case 1:
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
        }
    }
}
