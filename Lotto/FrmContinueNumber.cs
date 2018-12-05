﻿using System;
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

        private void FrmContinueNumber_Load(object sender, EventArgs e)
        {
            DataTable continueTab = new DataTable();

            continueTab.Columns.Add("회차");
            continueTab.Columns.Add("당첨일자");
            continueTab.Columns.Add("당첨번호");
            continueTab.Columns.Add("연속번호");
            continueTab.Columns.Add("연속번호 출현횟수");

            foreach (var item in lottoList)
            {
                int cnt = 0;
                string conNum = string.Empty;
                List<string> conNumList = new List<string>();
                numberList.Clear();
                conNumList.Clear();
                DataRow row = continueTab.NewRow();

                numberList.Add(item.Number1);
                numberList.Add(item.Number2);
                numberList.Add(item.Number3);
                numberList.Add(item.Number4);
                numberList.Add(item.Number5);
                numberList.Add(item.Number6);

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

                row["회차"] = item.Turn;
                row["연속번호"] = conNum;
                row["당첨일자"] = item.Date;
                row["당첨번호"] = item.Number1 + ", " + item.Number2 + ", " + item.Number3 + ", " + item.Number4 + ", " + item.Number5 + ", " + item.Number6 + ", ";
                row["연속번호 출현횟수"] = cnt + "쌍";

                continueTab.Rows.Add(row);
            }
            continueNumView.DataSource = continueTab;
            continueNumView.Columns["연속번호"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            continueNumView.Columns["당첨번호"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            continueNumView.Columns["당첨일자"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            continueNumView.Columns["연속번호 출현횟수"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
    }
}