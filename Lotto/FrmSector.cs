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
    public partial class FrmSector : Form
    {
        int ball1to10;
        int ball11to20;
        int ball21to30;
        int ball31to40;
        int ball41to45;

        int ball1;
        int ball6;
        int ball11;
        int ball16;
        int ball21;
        int ball26;
        int ball31;
        int ball36;
        int ball41;

        internal Form1 form1;
        public FrmSector()
        {
            InitializeComponent();
        }

        private void FrmSector_Load(object sender, EventArgs e)
        {
            int i = 0;
            ChartDataSet(5);
            ChartDataSet2(5);
            cbRec.SelectedIndex = 0;
            cbRec2.SelectedIndex = 0;
            foreach (var item in form1.lottoList)
            {
                cbSec1.Items.Add(form1.lottoList.Count - i);
                cbSec3.Items.Add(form1.lottoList.Count - i);
                i++;
            }
        }

        private void btnDeg10Rec_Click(object sender, EventArgs e)
        {
            if (cbRec.SelectedIndex == 0)
            {
                ChartDataSet(5);
            }
            else if (cbRec.SelectedIndex == 1)
            {
                ChartDataSet(10);
            }
            else if (cbRec.SelectedIndex == 2)
            {
                ChartDataSet(15);
            }
        }

        private void ChartDataSet(int selnum)
        {
            ball1to10 = 0;
            ball11to20 = 0;
            ball21to30 = 0;
            ball31to40 = 0;
            ball41to45 = 0;
            for (int i = 0; i < selnum; i++)
            {
                switch ((form1.lottoList[i].Number1 - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }

                switch ((form1.lottoList[i].Number2 - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }

                switch ((form1.lottoList[i].Number3 - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }

                switch ((form1.lottoList[i].Number4 - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }

                switch ((form1.lottoList[i].Number5 - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }

                switch ((form1.lottoList[i].Number6 - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }

                switch ((form1.lottoList[i].Bonus - 1) / 10)
                {
                    case 0:
                        ball1to10 += 1;
                        break;
                    case 1:
                        ball11to20 += 1;
                        break;
                    case 2:
                        ball21to30 += 1;
                        break;
                    case 3:
                        ball31to40 += 1;
                        break;
                    case 4:
                        ball41to45 += 1;
                        break;
                }
            }
            chtDeg10.Series[0].Points[4].YValues = new double[1] { ball1to10 };
            chtDeg10.Series[0].Points[3].YValues = new double[1] { ball11to20 };
            chtDeg10.Series[0].Points[2].YValues = new double[1] { ball21to30 };
            chtDeg10.Series[0].Points[1].YValues = new double[1] { ball31to40 };
            chtDeg10.Series[0].Points[0].YValues = new double[1] { ball41to45 };
            chtCircle.Series[0].Points[0].YValues = new double[1] { ball1to10 };
            chtCircle.Series[0].Points[1].YValues = new double[1] { ball11to20 };
            chtCircle.Series[0].Points[2].YValues = new double[1] { ball21to30 };
            chtCircle.Series[0].Points[3].YValues = new double[1] { ball31to40 };
            chtCircle.Series[0].Points[4].YValues = new double[1] { ball41to45 };

            int[] array = new int[] { ball1to10, ball11to20, ball21to30, ball31to40, ball41to45 };
            Array.Sort<int>(array);
            chtDeg10.ChartAreas[0].AxisY.Maximum = array[4] + Math.Ceiling(double.Parse(array[4].ToString()) / 5);

            chtDeg10.ChartAreas[0].AxisY.Interval = Math.Ceiling(double.Parse(array[4].ToString()) / 10);
            chtDeg10.Series[0].Name = "최근 " + selnum + "주간\n" + (form1.lottoList.Count - selnum) + "회 부터 " + form1.lottoList.Count + "회 까지";
        }

        private void ChartDataSet()
        {
            {
                ball1to10 = 0;
                ball11to20 = 0;
                ball21to30 = 0;
                ball31to40 = 0;
                ball41to45 = 0;
                for (int i = cbSec2.SelectedIndex; i < cbSec1.SelectedIndex + 1; i++)
                {
                    switch ((form1.lottoList[i].Number1 - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number2 - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number3 - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number4 - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number5 - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number6 - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Bonus - 1) / 10)
                    {
                        case 0:
                            ball1to10 += 1;
                            break;
                        case 1:
                            ball11to20 += 1;
                            break;
                        case 2:
                            ball21to30 += 1;
                            break;
                        case 3:
                            ball31to40 += 1;
                            break;
                        case 4:
                            ball41to45 += 1;
                            break;
                    }
                }
                chtDeg10.Series[0].Points[4].YValues = new double[1] { ball1to10 };
                chtDeg10.Series[0].Points[3].YValues = new double[1] { ball11to20 };
                chtDeg10.Series[0].Points[2].YValues = new double[1] { ball21to30 };
                chtDeg10.Series[0].Points[1].YValues = new double[1] { ball31to40 };
                chtDeg10.Series[0].Points[0].YValues = new double[1] { ball41to45 };
                chtCircle.Series[0].Points[0].YValues = new double[1] { ball1to10 };
                chtCircle.Series[0].Points[1].YValues = new double[1] { ball11to20 };
                chtCircle.Series[0].Points[2].YValues = new double[1] { ball21to30 };
                chtCircle.Series[0].Points[3].YValues = new double[1] { ball31to40 };
                chtCircle.Series[0].Points[4].YValues = new double[1] { ball41to45 };

                int[] array = new int[] { ball1to10, ball11to20, ball21to30, ball31to40, ball41to45 };
                Array.Sort<int>(array);
                chtDeg10.ChartAreas[0].AxisY.Maximum = array[4] + Math.Ceiling(double.Parse(array[4].ToString()) / 5);

                chtDeg10.ChartAreas[0].AxisY.Interval = Math.Ceiling(double.Parse(array[4].ToString()) / 10);
            }
            chtDeg10.Series[0].Name = cbSec1.Text + "회 부터 " + cbSec2.Text + "회 까지";
        }

        private void btnDeg10Sec_Click(object sender, EventArgs e)
        {
            ChartDataSet();
        }

        private void cbSec1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSec2.Items.Clear();
            btnDeg10Sec.Enabled = false;
            cbSec2.Enabled = true;
            int j = 0;
            for (int i = form1.lottoList.Count - cbSec1.SelectedIndex; i < form1.lottoList.Count + 1; i++)
            {
                cbSec2.Items.Add(form1.lottoList.Count - j);
                j++;
            }
        }

        private void ChartDataSet2()
        {
            {
                int ball1 = 0;
                int ball6 = 0;
                int ball11 = 0;
                int ball16 = 0;
                int ball21 = 0;
                int ball26 = 0;
                int ball31 = 0;
                int ball36 = 0;
                int ball41 = 0;

                for (int i = cbSec2.SelectedIndex; i < cbSec1.SelectedIndex + 1; i++)
                {
                    switch ((form1.lottoList[i].Number1 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number2 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number3 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number4 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number5 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number6 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Bonus - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }
                }
                chtDeg5.Series[0].Points[8].YValues = new double[1] { ball1 };
                chtDeg5.Series[0].Points[7].YValues = new double[1] { ball6 };
                chtDeg5.Series[0].Points[6].YValues = new double[1] { ball11 };
                chtDeg5.Series[0].Points[5].YValues = new double[1] { ball16 };
                chtDeg5.Series[0].Points[4].YValues = new double[1] { ball21 };
                chtDeg5.Series[0].Points[3].YValues = new double[1] { ball26 };
                chtDeg5.Series[0].Points[2].YValues = new double[1] { ball31 };
                chtDeg5.Series[0].Points[1].YValues = new double[1] { ball36 };
                chtDeg5.Series[0].Points[0].YValues = new double[1] { ball41 };
                chtCircle2.Series[0].Points[0].YValues = new double[1] { ball1 };
                chtCircle2.Series[0].Points[1].YValues = new double[1] { ball6 };
                chtCircle2.Series[0].Points[2].YValues = new double[1] { ball11 };
                chtCircle2.Series[0].Points[3].YValues = new double[1] { ball16 };
                chtCircle2.Series[0].Points[4].YValues = new double[1] { ball21 };
                chtCircle2.Series[0].Points[5].YValues = new double[1] { ball26 };
                chtCircle2.Series[0].Points[6].YValues = new double[1] { ball31 };
                chtCircle2.Series[0].Points[7].YValues = new double[1] { ball36 };
                chtCircle2.Series[0].Points[8].YValues = new double[1] { ball41 };

                int[] array = new int[] { ball1, ball6, ball11, ball16, ball21, ball26, ball31, ball36, ball41 };
                Array.Sort<int>(array);
                chtDeg5.ChartAreas[0].AxisY.Maximum = array[8] + Math.Ceiling(double.Parse(array[8].ToString()) / 5);

                chtDeg5.ChartAreas[0].AxisY.Interval = Math.Ceiling(double.Parse(array[8].ToString()) / 10);
            }
            chtDeg5.Series[0].Name = cbSec1.Text + "회 부터 " + cbSec2.Text + "회 까지";
        }

        private void ChartDataSet2(int selnum)
        {
            {
                ball1 = 0;
                ball6 = 0;
                ball11 = 0;
                ball16 = 0;
                ball21 = 0;
                ball26 = 0;
                ball31 = 0;
                ball36 = 0;
                ball41 = 0;

                for (int i = 0; i < selnum; i++)
                {
                    switch ((form1.lottoList[i].Number1 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number2 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number3 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number4 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number5 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Number6 - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }

                    switch ((form1.lottoList[i].Bonus - 1) / 5)
                    {
                        case 0:
                            ball1 += 1;
                            break;
                        case 1:
                            ball6 += 1;
                            break;
                        case 2:
                            ball11 += 1;
                            break;
                        case 3:
                            ball16 += 1;
                            break;
                        case 4:
                            ball21 += 1;
                            break;
                        case 5:
                            ball26 += 1;
                            break;
                        case 6:
                            ball31 += 1;
                            break;
                        case 7:
                            ball36 += 1;
                            break;
                        case 8:
                            ball41 += 1;
                            break;
                    }
                }
                chtDeg5.Series[0].Points[8].YValues = new double[1] { ball1 };
                chtDeg5.Series[0].Points[7].YValues = new double[1] { ball6 };
                chtDeg5.Series[0].Points[6].YValues = new double[1] { ball11 };
                chtDeg5.Series[0].Points[5].YValues = new double[1] { ball16 };
                chtDeg5.Series[0].Points[4].YValues = new double[1] { ball21 };
                chtDeg5.Series[0].Points[3].YValues = new double[1] { ball26 };
                chtDeg5.Series[0].Points[2].YValues = new double[1] { ball31 };
                chtDeg5.Series[0].Points[1].YValues = new double[1] { ball36 };
                chtDeg5.Series[0].Points[0].YValues = new double[1] { ball41 };
                chtCircle2.Series[0].Points[0].YValues = new double[1] { ball1 };
                chtCircle2.Series[0].Points[1].YValues = new double[1] { ball6 };
                chtCircle2.Series[0].Points[2].YValues = new double[1] { ball11 };
                chtCircle2.Series[0].Points[3].YValues = new double[1] { ball16 };
                chtCircle2.Series[0].Points[4].YValues = new double[1] { ball21 };
                chtCircle2.Series[0].Points[5].YValues = new double[1] { ball26 };
                chtCircle2.Series[0].Points[6].YValues = new double[1] { ball31 };
                chtCircle2.Series[0].Points[7].YValues = new double[1] { ball36 };
                chtCircle2.Series[0].Points[8].YValues = new double[1] { ball41 };

                int[] array = new int[] { ball1, ball6, ball11, ball16, ball21, ball26, ball31, ball36, ball41 };
                Array.Sort<int>(array);
                chtDeg5.ChartAreas[0].AxisY.Maximum = array[8] + Math.Ceiling(double.Parse(array[8].ToString()) / 5);

                chtDeg5.ChartAreas[0].AxisY.Interval = Math.Ceiling(double.Parse(array[8].ToString()) / 10);
                chtDeg5.Series[0].Name = "최근 " + selnum + "주간\n" + (form1.lottoList.Count - selnum) + "회 부터 " + form1.lottoList.Count + "회 까지";
            }
        }

        private void btnDeg5Sec_Click(object sender, EventArgs e)
        {
            ChartDataSet2();
        }

        private void btnDeg5Rec_Click(object sender, EventArgs e)
        {
            if (cbRec2.SelectedIndex == 0)
            {
                ChartDataSet2(5);
            }
            else if (cbRec2.SelectedIndex == 1)
            {
                ChartDataSet2(10);
            }
            else if (cbRec2.SelectedIndex == 2)
            {
                ChartDataSet2(15);
            }
        }

        private void cbSec3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSec4.Enabled = true;
            btnDeg5Sec.Enabled = false;
            cbSec4.Items.Clear();
            int j = 0;
            for (int i = form1.lottoList.Count - cbSec3.SelectedIndex; i < form1.lottoList.Count + 1; i++)
            {
                cbSec4.Items.Add(form1.lottoList.Count - j);
                j++;
            }
        }

        private void cbSec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeg10Sec.Enabled = true;
        }

        private void cbSec4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeg5Sec.Enabled = true;
        }
    }
}