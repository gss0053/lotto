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
        private string path = @"http://www.nlotto.co.kr/gameResult.do?method=byWin&drwNo=";
        private int no = 0;
        private int newestRound = 0;
        int count = 0;
        List<LottoResult> lottoList;
        private double completeCnt;
        List<int> numberList;
        FrmProgressBar fpb;

        public Form1()
        {
            InitializeComponent();
            lottoList = new List<LottoResult>();
            numberList = new List<int>();
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
            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(path);

            HtmlNode root = htmlDoc.DocumentNode.SelectSingleNode("//body");
            HtmlNode info = null;

            for (int i = 0; i < root.SelectNodes("//div").Count; i++)
            {
                if (root.SelectNodes("//div")[i].GetAttributeValue("class", "") == "lotto_win_number mt12")
                {
                    info = root.SelectNodes("//div")[i];
                    break;
                }
            }

            HtmlNode h3 = info.SelectSingleNode("h3");
            HtmlNode p = info.SelectSingleNode("p");
            HtmlNodeCollection ball = p.SelectNodes("img");
            HtmlNode span = null;

            for (int i = 0; i < p.SelectNodes("span").Count; i++)
            {
                if (p.SelectNodes("span")[i].GetAttributeValue("class", "") == "number_bonus")
                {
                    span = p.SelectNodes("span")[i];
                    break;
                }
            }

            numberList.Clear();
            foreach (var numbers in ball)
            {
                numberList.Add(int.Parse(numbers.GetAttributeValue("alt", "")));
            }

            round = int.Parse(h3.SelectSingleNode("strong").InnerText);
            number1 = numberList[0];
            number2 = numberList[1];
            number3 = numberList[2];
            number4 = numberList[3];
            number5 = numberList[4];
            number6 = numberList[5];
            bonus = int.Parse(span.SelectSingleNode("img").GetAttributeValue("alt", ""));
            
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
