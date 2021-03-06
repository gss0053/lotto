﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {

        private int round, number1, number2, number3, number4, number5, number6, bonus, no, newestRound = 0;

        private int count = 0;
        private double completeCnt = 0;
        private string path = @"https://www.dhlottery.co.kr/gameResult.do?method=byWin&drwNo=";
        private int scrollOffset = int.Parse(ConfigurationManager.AppSettings.GetValues("scrollOffset")[0]);
        private string date;

        

        public List<LottoResult> lottoList;



        List<int> numberList;
        FrmProgressBar fpb;
        HtmlNode node = null;

        private void 홀짝통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSnifflingChart fsc = new FrmSnifflingChart(lottoList);
            fsc.Show();
        }

        private void 번호별통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ByNumberChart fbnc = new Frm_ByNumberChart(lottoList);
            fbnc.Show();
        }

        public Form1()
        {
            InitializeComponent();
            lottoList = new List<LottoResult>();
            numberList = new List<int>();
        }

        private void cbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbGames.SelectedIndex < 7)
            {
                lottoView.FirstDisplayedScrollingRowIndex = 0;
            }
            else if (newestRound - cbGames.SelectedIndex < 7)
            {
                lottoView.FirstDisplayedScrollingRowIndex = cbGames.SelectedIndex - 7;
            }
            else
            {
                lottoView.FirstDisplayedScrollingRowIndex = int.Parse(cbGames.SelectedIndex.ToString()) - 7;
            }
            lottoView.Rows[cbGames.SelectedIndex].Selected = true;
            Display_Num();
        }

        private void cbGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(cbGames.Text) < newestRound || int.Parse(cbGames.Text) == newestRound)
                {
                    cbGames.SelectedIndex = newestRound - int.Parse(cbGames.Text);
                }
                else if (int.Parse(cbGames.Text) > newestRound)
                {
                    cbGames.SelectedIndex = 0;
                }
            }
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 기간별미출현ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UnseenNumber fun = new Frm_UnseenNumber(lottoList);
            fun.Show();
        }
        private void 연속번호출현통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContinueNumber fcn = new FrmContinueNumber(lottoList);
            fcn.Show();
        }

        private void 구간별출현횟수통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSector fs = new FrmSector();
            fs.form1 = this;
            fs.Show();
        }

        private void lottoView_Click(object sender, EventArgs e)
        {
            cbGames.Text = lottoView.SelectedRows[0].Cells[0].Value.ToString();

            Display_Num();

        }

        private void Display_Num()
        {
            lbl_Num.Text = lottoView.SelectedRows[0].Cells[0].Value + "회 당첨 번호";
            label1.Text = lottoView.SelectedRows[0].Cells[1].Value.ToString();
            label2.Text = lottoView.SelectedRows[0].Cells[2].Value.ToString();
            label3.Text = lottoView.SelectedRows[0].Cells[3].Value.ToString();
            label4.Text = lottoView.SelectedRows[0].Cells[4].Value.ToString();
            label5.Text = lottoView.SelectedRows[0].Cells[5].Value.ToString();
            label6.Text = lottoView.SelectedRows[0].Cells[6].Value.ToString();
            label7.Text = lottoView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void lottoView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (int.Parse(cbGames.Text) < newestRound )
                {
                    cbGames.Text = (int.Parse(cbGames.Text) + 1).ToString();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(cbGames.Text) > 1)
                {
                    cbGames.Text = (int.Parse(cbGames.Text) - 1).ToString();
                }
            }

        }

        private int DBNewestRound()
        {
            SqlConnection con = null;
            try
            {
                con = DBConnect.Connect();
                SqlCommand cmd = OpenMethod(con, "GetMaxRound");
                newestRound = (int)cmd.ExecuteScalar();
                DBConnect.Close(con);

                return newestRound;
            }
            catch (Exception)
            {
                DBConnect.Close(con);
                return newestRound;
            }
        }

        private int Parsing(string path)
        {
            HtmlWeb web = new HtmlWeb();
            web.OverrideEncoding = Encoding.Default;
            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(path);
            HtmlNodeCollection root = htmlDoc.DocumentNode.SelectNodes("//body//div");

            for (int i = 0; i < root.Count; i++)
            {
                if (root[i].GetAttributeValue("class", "") == "containerWrap")
                {
                    node = root[i];
                }
            }

            node = node.SelectSingleNode("section").SelectSingleNode("div");
            node = node.SelectNodes("div")[1];
            node = node.SelectSingleNode("div");
            node = node.SelectNodes("div")[1];

            round = int.Parse((node.SelectSingleNode("h4").FirstChild.InnerText).Substring(0, (node.SelectSingleNode("h4").FirstChild.InnerText).Length - 1));
            date = node.SelectSingleNode("p").InnerText;
            date = date.Substring(0, date.Length - 3).Remove(0, 1);

            node = node.SelectNodes("div")[0];
            HtmlNodeCollection nodes = node.SelectNodes("div");

            for (int i = 0; i < nodes.Count; i++)
            {
                switch (nodes[i].GetAttributeValue("class", ""))
                {
                    case "num win":
                        node = nodes[i].SelectSingleNode("p");
                        HtmlNodeCollection spans = node.SelectNodes("span");
                        number1 = int.Parse(spans[0].InnerText);
                        number2 = int.Parse(spans[1].InnerText);
                        number3 = int.Parse(spans[2].InnerText);
                        number4 = int.Parse(spans[3].InnerText);
                        number5 = int.Parse(spans[4].InnerText);
                        number6 = int.Parse(spans[5].InnerText);
                        break;
                    case "num bonus":
                        node = nodes[i].SelectSingleNode("p");
                        HtmlNode span = node.SelectSingleNode("span");
                        bonus = int.Parse(span.InnerText);
                        break;
                    default:
                        break;
                }
            }
            return round;
        }

        private void Insert()
        {
            using (SqlConnection con = DBConnect.Connect())
            {              
                SqlCommand cmd = OpenMethod(con, "Insert");
                cmd.StatementCompleted += Cmd_StatementCompleted;

                cmd.Parameters.AddWithValue("round", round);
                cmd.Parameters.AddWithValue("number_1", number1);
                cmd.Parameters.AddWithValue("number_2", number2);
                cmd.Parameters.AddWithValue("number_3", number3);
                cmd.Parameters.AddWithValue("number_4", number4);
                cmd.Parameters.AddWithValue("number_5", number5);
                cmd.Parameters.AddWithValue("number_6", number6);
                cmd.Parameters.AddWithValue("number_7", bonus);
                cmd.Parameters.AddWithValue("date", date);

                cmd.ExecuteNonQuery();
                DBConnect.Close(con);
            }
        }

        private void Cmd_StatementCompleted(object sender, StatementCompletedEventArgs e)
        {
            completeCnt += (double)e.RecordCount;
            fpb.ProgressBar.Value = (int)Math.Truncate(completeCnt / count * 100);
            // fpb.LblUpdate.Text = completeCnt + "/" + count; // 나중에 비동기 어씽크 기법으로 처리하기
        }

        private static SqlCommand OpenMethod(SqlConnection con, string cmdText)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdText;
            return cmd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = Parsing(path) - DBNewestRound();
            if (Parsing(path) > DBNewestRound())
            {
                fpb = new FrmProgressBar();
                fpb.Show();
                while (Parsing(path) > DBNewestRound())
                {
                    no = DBNewestRound() + 1;
                    path = path + no;
                    Parsing(path);
                    Insert();
                    path = path.Substring(0, path.Length - no.ToString().Length);
                    no++;
                }
                MessageBox.Show("업데이트 완료", "업데이트 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fpb.Dispose();
                fpb.Close();
            }
            else
            {
                MessageBox.Show("최신 버전입니다","업데이트 메세지",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


            SqlConnection con = new SqlConnection("Data Source=192.168.0.10;Initial Catalog=lotto_DB;User ID=khi;Password=1234");
            con.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "Select";

            SqlDataReader sr = comm.ExecuteReader();

            while (sr.Read())
            {
                lottoList.Add(new LottoResult(int.Parse(sr[0].ToString()), int.Parse(sr[1].ToString()), int.Parse(sr[2].ToString()), int.Parse(sr[3].ToString()), int.Parse(sr[4].ToString()), int.Parse(sr[5].ToString()), int.Parse(sr[6].ToString()), int.Parse(sr[7].ToString()), sr[8].ToString()));
            }

            newestRound = lottoList[0].Turn;
            con.Close();
            lottoView.DataSource = lottoList;

            lottoView.Columns[0].HeaderText = "회차수";
            lottoView.Columns[1].HeaderText = "1번 번호";
            lottoView.Columns[2].HeaderText = "2번 번호";
            lottoView.Columns[3].HeaderText = "3번 번호";
            lottoView.Columns[4].HeaderText = "4번 번호";
            lottoView.Columns[5].HeaderText = "5번 번호";
            lottoView.Columns[6].HeaderText = "6번 번호";
            lottoView.Columns[7].HeaderText = "보너스 번호";
            lottoView.Columns[8].HeaderText = "추첨 일자";
            lottoView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            Addtocb();


            Display_Num();
            this.Text = "로또 프로그램";
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Orange;
            label3.ForeColor = Color.Yellow;
            label4.ForeColor = Color.Green;
            label5.ForeColor = Color.Blue;
            label6.ForeColor = Color.DarkBlue;
            label7.ForeColor = Color.Purple;
        }

        public void Addtocb()
        {
            int i = 0;
            foreach (var item in lottoList)
            {
                cbGames.Items.Add(newestRound - i);
                i++;
            }
        }
    }
}