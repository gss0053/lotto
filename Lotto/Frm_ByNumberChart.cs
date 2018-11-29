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
    public partial class Frm_ByNumberChart : Form
    {
        //int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
        //int num11, num12, num13, num14, num15, num16, num17, num18, num19, num20;
        //int num21, num22, num23, num24, num25, num26, num27, num28, num29, num30;
        //int num31, num32, num33, num34, num35, num36, num37, num38, num39, num40;
        //int num41, num42, num43, num44, num45;

        //int[] count = {0,0,0,0,0, 0,0,0,0,0,
        //               0,0,0,0,0, 0,0,0,0,0,
        //               0,0,0,0,0, 0,0,0,0,0,
        //               0,0,0,0,0, 0,0,0,0,0,
        //               0,0,0,0,0 };

        int[] lottoNumber_count = new int[46];
        List<LottoResult> lottoResults = new List<LottoResult>();


        public Frm_ByNumberChart()
        {

            InitializeComponent();
        }

        public Frm_ByNumberChart(List<LottoResult> list) : this()
        {
            this.lottoResults = list;
        }

        private void Frm_ByNumberChart_Load(object sender, EventArgs e)
        {
            for (int i = lottoResults.Count; i > 0; i--)
            {
                cbo_Start_Number.Items.Add(i);
                cbo_End_Number.Items.Add(i);
            }

            cbo_Start_Number.Text = 1.ToString();
            cbo_End_Number.Text = lottoResults.Count.ToString();

            LottoNumber_Count();

        }

        private void LottoNumber_Count()
        {
            for (int i = 0; i < lottoNumber_count.Length; i++)
            {
                lottoNumber_count[i] = 0;
            }

            if (Int32.Parse(cbo_Start_Number.Text) > Int32.Parse(cbo_End_Number.Text))
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for (int i = Int32.Parse(cbo_Start_Number.Text) - 1; i < Int32.Parse(cbo_End_Number.Text); i++)
                {
                    lottoNumber_count[lottoResults[i].Number1 - 1]++;
                    lottoNumber_count[lottoResults[i].Number2 - 1]++;
                    lottoNumber_count[lottoResults[i].Number3 - 1]++;
                    lottoNumber_count[lottoResults[i].Number4 - 1]++;
                    lottoNumber_count[lottoResults[i].Number5 - 1]++;
                    lottoNumber_count[lottoResults[i].Number6 - 1]++;
                    if (!chk_Bonus.Checked)
                    {
                        lottoNumber_count[lottoResults[i].Bonus - 1]++;
                    }

                }
            }
            ByNumberChart.Series[0].Name = "당첨 횟수";
            ByNumberChart.Series[0].Points.DataBindY(lottoNumber_count);

            ByNumberChart.ChartAreas[0].AxisX.Interval = 1;

            ByNumberChart.ChartAreas[0].AxisX.Maximum = 45;
            ByNumberChart.ChartAreas[0].AxisX.Minimum = 1;
          
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            LottoNumber_Count();
        }
    }
}
