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
        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
        int num11, num12, num13, num14, num15, num16, num17, num18, num19, num20;
        int num21, num22, num23, num24, num25, num26, num27, num28, num29, num30;
        int num31, num32, num33, num34, num35, num36, num37, num38, num39, num40;
        int num41, num42, num43, num44, num45;

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

        }
    }
}
