using System.Collections.Generic;
using Bingo.BingoCheckers;

namespace Bingo
{
    public class BingoCard
    {
        public BingoNumber[,] BingoCards { get; private set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
    }
}