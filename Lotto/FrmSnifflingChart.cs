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
            DataColumn data = snifflingTab.Columns.Add("당첨번호");
            snifflingTab.Columns.Add("홀수");
            snifflingTab.Columns.Add("짝수");
            snifflingTab.Columns.Add("번호합");
            DataRow row = snifflingTab.NewRow();
            foreach (var item in lottoList)
            {
                row["회차"] = item.Turn;
                // row["당첨일자"] = 
                numberList.Add(item.Number1);
                numberList.Add(item.Number2);
                numberList.Add(item.Number3);
                numberList.Add(item.Number4);
                numberList.Add(item.Number5);
                numberList.Add(item.Number6);
                row["당첨번호"] = item.Number1 + ", " + item.Number2 + ", " + item.Number3 + ", " + item.Number4 + ", " + item.Number5 + ", " + item.Number6;

                for (int i = 0; i < numberList.Count; i++)
                {
                    switch (numberList[i] % 2)
                    {
                        case 0:
                            //.Substring(0, numberList[i].ToString().Length - 1)
                            string result = numberList[i].ToString() + ", ";
                            row["짝수"] += result;
                            result = string.Empty;
                            break;
                        case 1:
                            row["홀수"] = numberList[i];
                            break;
                    }
                }
                numberList.Clear();
            }
            snifflingTab.Rows.Add(row);

            snifflingView.DataSource = snifflingTab;
        }
    }
}
