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
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar()
        {
            InitializeComponent();
        }


        public ProgressBar ProgressBar
        {
            get { return progressBar; }
            set { progressBar = value; }
        }

        public Label LblUpdate
        {
            get { return lblUpdate; }
            set { lblUpdate = value; }
        }

        private void FrmProgressBar_Load(object sender, EventArgs e)
        {
        }
    }
}
