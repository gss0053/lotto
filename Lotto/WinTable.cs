using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class WinTable
    {
        private string rank;
        private string winStandard;
        private int totalWinMoney = 0;
        private int winMoney = 0;
        private int gameAmount = 0;

        public string Rank { get => rank; set => rank = value; }
        public string WinStandard { get => winStandard; set => winStandard = value; }
        public int TotalWinMoney { get => totalWinMoney; set => totalWinMoney = value; }
        public int WinMoney { get => winMoney; set => winMoney = value; }
        public int GameAmount { get => gameAmount; set => gameAmount = value; }
    }
}
