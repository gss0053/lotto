using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class LottoResult
    {
        private int turn;
        private int number1;
        private int number2;
        private int number3;
        private int number4;
        private int number5;
        private int number6;
        private int bonus;

        public int Turn { get => turn; set => turn = value; }
        public int Number1 { get => number1; set => number1 = value; }
        public int Number2 { get => number2; set => number2 = value; }
        public int Number3 { get => number3; set => number3 = value; }
        public int Number4 { get => number4; set => number4 = value; }
        public int Number5 { get => number5; set => number5 = value; }
        public int Number6 { get => number6; set => number6 = value; }
        public int Bonus { get => bonus; set => bonus = value; }

        public LottoResult(int turn, int number1, int number2, int number3, int number4, int number5, int number6, int bonus)
        {
            this.turn = turn;
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
            this.number4 = number4;
            this.number5 = number5;
            this.number6 = number6;
            this.bonus = bonus;
        }

        public LottoResult()
        {
        }
    }
}
