using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Frm_UnseenNumber : Form
    {
        int[] lottoNumber_count = new int[46];
        List<LottoResult> lottoResults = new List<LottoResult>();
        string pattern = "^[0-9]*$";
        int search_num = 0;



        public Frm_UnseenNumber()
        {
            InitializeComponent();
        }

        public Frm_UnseenNumber(List<LottoResult> lottoList) : this()
        {
            this.lottoResults = lottoList;
         
        }

        private void Frm_UnseenNumber_Load(object sender, EventArgs e)
        {
            gb_recent.Visible = true;
            gb_round.Visible = false;
            cbo_recent.DropDownStyle = ComboBoxStyle.DropDownList;


            for (int i = lottoResults.Count; i > 0; i--)
            {   // 콤보 박스에 회차수 입력
                cbo_Start_Number.Items.Add(i);
                cbo_End_Number.Items.Add(i);
            }
            cbo_recent.Items.Add("5주간");
            cbo_recent.Items.Add("10주간");
            cbo_recent.Items.Add("15주간");

            cbo_Start_Number.Text = lottoResults.Count.ToString();
            cbo_End_Number.Text = lottoResults.Count.ToString();
            cbo_recent.Text = cbo_recent.Items[0].ToString();



            if (rdo_recent.Checked)
            {
                Recent_Count();
            }
            else
            {
                Round_Count();
            }
        }

        private void Recent_Count()
        {
            for (int i = 0; i < lottoNumber_count.Length; i++)
            {
                lottoNumber_count[i] = 0;
            }
            //lbl_1_10.Text = lbl_21_30.Text = lbl_31_40.Text = lbl_41_45.Text = lbl_11_20.Text = String.Empty;


            if (cbo_recent.Text == "5주간")
            {
                search_num = 5;
                Search_Count(search_num);
                Section_UnseenNumber();
            }
            if (cbo_recent.Text == "10주간")
            {
                search_num = 10;
                Search_Count(search_num);
                Section_UnseenNumber();
            }
            if (cbo_recent.Text == "15주간")
            {
                search_num = 15;
                Search_Count(search_num);
                Section_UnseenNumber();
            }

        }

        private void Search_Count(int a)
        {
            //for (int i = 0; i < a; i++)
              for(int i = lottoResults.Count - a; i < lottoResults.Count; i++)
            {

                lottoNumber_count[lottoResults[i].Number1 - 1]++;
                lottoNumber_count[lottoResults[i].Number2 - 1]++;
                lottoNumber_count[lottoResults[i].Number3 - 1]++;
                lottoNumber_count[lottoResults[i].Number4 - 1]++;
                lottoNumber_count[lottoResults[i].Number5 - 1]++;
                lottoNumber_count[lottoResults[i].Number6 - 1]++;
                lottoNumber_count[lottoResults[i].Bonus - 1]++;
            }
        }

        private void Round_Count()
        {
            //lbl_1_10.Text = lbl_21_30.Text = lbl_31_40.Text = lbl_41_45.Text = lbl_11_20.Text = String.Empty;

            for (int i = 0; i < lottoNumber_count.Length; i++)
            {
                lottoNumber_count[i] = 0;
            }


            if (!Regex.IsMatch(cbo_Start_Number.Text, pattern) || Int32.Parse(cbo_Start_Number.Text) > lottoResults.Count)
            {
                cbo_Start_Number.Text = lottoResults.Count.ToString();
            }
            if (!Regex.IsMatch(cbo_End_Number.Text, pattern) || Int32.Parse(cbo_End_Number.Text) > lottoResults.Count)
            {
                cbo_End_Number.Text = lottoResults.Count.ToString();
            }


            if (Int32.Parse(cbo_Start_Number.Text) > Int32.Parse(cbo_End_Number.Text))
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Start_Number.Text = 1.ToString();
                cbo_End_Number.Text = lottoResults.Count.ToString();
            }

            for (int i = Int32.Parse(cbo_Start_Number.Text) - 1; i < Int32.Parse(cbo_End_Number.Text); i++)
            {   // 1 ~ 45번 카운트

                lottoNumber_count[lottoResults[i].Number1 - 1]++;
                lottoNumber_count[lottoResults[i].Number2 - 1]++;
                lottoNumber_count[lottoResults[i].Number3 - 1]++;
                lottoNumber_count[lottoResults[i].Number4 - 1]++;
                lottoNumber_count[lottoResults[i].Number5 - 1]++;
                lottoNumber_count[lottoResults[i].Number6 - 1]++;
                if (!chk_Bonus.Checked)
                {   // 보너스 포함시 7번구도 카운트
                    lottoNumber_count[lottoResults[i].Bonus - 1]++;
                }

            }

            Section_UnseenNumber();
        }

        private void Section_UnseenNumber()
        {
            #region 구간별 미출현
            lbl_1_10.Text = lbl_21_30.Text = lbl_31_40.Text = lbl_41_45.Text = lbl_11_20.Text = String.Empty;

            for (int i = 0; i < lottoNumber_count.Length - 1; i++)
            {
                if (lottoNumber_count[i].ToString() == "0")
                {
                    if (i + 1 <= 10 && i + 1 > 0)
                    {
                        lbl_1_10.Text += " " + (i + 1) + ',';
                    }
                    else if (i + 1 <= 20 && i + 1 > 10)
                    {
                        lbl_11_20.Text += " " + (i + 1) + ',';
                    }
                    else if (i + 1 <= 30 && i + 1 > 20)
                    {
                        lbl_21_30.Text += " " + (i + 1) + ',';
                    }
                    else if (i + 1 <= 40 && i + 1 > 30)
                    {
                        lbl_31_40.Text += " " + (i + 1) + ',';
                    }
                    else if (i + 1 <= 45 && i + 1 > 40)
                    {
                        lbl_41_45.Text += " " + (i + 1) + ',';
                    }
                }
            }
            lbl_1_10.Text = lbl_1_10.Text.TrimEnd(',', ' ');
            lbl_11_20.Text = lbl_11_20.Text.TrimEnd(',', ' ');
            lbl_21_30.Text = lbl_21_30.Text.TrimEnd(',', ' ');
            lbl_31_40.Text = lbl_31_40.Text.TrimEnd(',', ' ');
            lbl_41_45.Text = lbl_41_45.Text.TrimEnd(',', ' ');

            #endregion
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (rdo_recent.Checked)
            {
                Recent_Count();
            }
            else
            {
                Round_Count();
            }
        }

        private void cbo_Start_Number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Regex.IsMatch(cbo_Start_Number.Text, pattern) || Int32.Parse(cbo_Start_Number.Text) > lottoResults.Count)
                {
                    cbo_Start_Number.Text = lottoResults.Count.ToString();
                }
                cbo_End_Number.Focus();
            }
        }

        private void cbo_End_Number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Regex.IsMatch(cbo_End_Number.Text, pattern) || Int32.Parse(cbo_End_Number.Text) > lottoResults.Count)
                {
                    cbo_End_Number.Text = lottoResults.Count.ToString();
                }
                btn_sub_Click(null, null);
            }
        }

        private void rdo_Click(object sender, EventArgs e)
        {
            if (rdo_recent.Checked)
            {
                gb_recent.Visible = true;
                gb_round.Visible = false;
            }
            else
            {
                gb_round.Visible = true;
                gb_recent.Visible = false;
            }
        }
    }
}
