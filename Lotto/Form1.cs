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


        private void 홀짝통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSnifflingChart fsc = new FrmSnifflingChart(lottoList);
            fsc.Show();
        }

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
        private LottoResult Parsing(string path)
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

            LottoResult lotto = new LottoResult() { Turn = round, Number1 = number1, Number2 = number2, Number3 = number3, Number4 = number4, Number5 = number5, Number6 = number6, Bonus = bonus };
            lottoList.Add(lotto);

            return lotto;
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

                int result = cmd.ExecuteNonQuery();
                DBConnect.Close(con);

                if (result == 1)
                {
                    // MessageBox.Show("데이터 추가 성공", "성공메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            count = Parsing(path).Turn - DBNewestRound();
            if (Parsing(path).Turn > DBNewestRound() || DBNewestRound() == 0)
            {
                fpb = new FrmProgressBar();
                fpb.Show();
                while (Parsing(path).Turn > DBNewestRound())
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
                MessageBox.Show("업데이트 필요없음");
            }
        }
    }
}
