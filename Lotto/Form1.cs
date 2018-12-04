using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace Lotto
{
    public partial class Form1 : Form
    {
        private int round, number1, number2, number3, number4, number5, number6, bonus = 0;
<<<<<<< HEAD
        private string path = @"https://www.nlotto.co.kr/gameResult.do?method=byWin&drwNo=";
        //private string path = @"http://www.dhlottery.co.kr/gameResult.do?method=byWin&drwNo=";
=======
>>>>>>> master
        private int no = 0;
        private int newestRound = 0;
        int count = 0;

        private double completeCnt;
<<<<<<< HEAD
        List<int> numberList;   // 파싱 할때 1 ~ 6 번 구
=======

        private string path = @"https://www.dhlottery.co.kr/gameResult.do?method=byWin&drwNo=";
        private string winStandard;

        List<LottoResult> lottoList;
        List<int> numberList;
        List<WinTable> winTabList;
>>>>>>> master
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
            winTabList = new List<WinTable>();
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

            round = int.Parse((node.SelectSingleNode("h4").FirstChild.InnerText).Substring(0, 3));

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

                cmd.ExecuteNonQuery();
                DBConnect.Close(con);
            }
        }

        private void Cmd_StatementCompleted(object sender, StatementCompletedEventArgs e)
        {
            completeCnt += (double)e.RecordCount;
            fpb.ProgressBar.Value = (int)Math.Truncate(completeCnt / count * 100);
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
                MessageBox.Show("업데이트 완료");
                fpb.Dispose();
                fpb.Close();
            }
            else
            {
                MessageBox.Show("최신 버전입니다");
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
                lottoList.Add(new LottoResult(int.Parse(sr[0].ToString()), int.Parse(sr[1].ToString()), int.Parse(sr[2].ToString()), int.Parse(sr[3].ToString()), int.Parse(sr[4].ToString()), int.Parse(sr[5].ToString()), int.Parse(sr[6].ToString()), int.Parse(sr[7].ToString())));
            }
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
        }
    }
}
