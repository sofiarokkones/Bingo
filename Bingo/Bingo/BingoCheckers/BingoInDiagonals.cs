namespace Bingo.BingoCheckers
{
    public class BingoInDiagonals : IBingoRule
    {
        private readonly BingoHelpers _helper = new();

        public bool CheckForBingoInRow(BingoNumber[,] bingoCard)
        {
            for (int i = 0; i < _helper.GetColumn(bingoCard, 0).Length - 4; i++)
            {
                if (BingoDiagonalLeftToRight(bingoCard, i) || BingoDiagonalRightToLeft(bingoCard, i))
                    return true;
            }
            return false;
        }
        
        private bool BingoDiagonalLeftToRight(BingoNumber[,] bingoCard, int i)
        {
            var bingoDiagLtoR = new BingoNumber[5];
            for (int j = 0; j < _helper.GetRow(bingoCard, 0).Length; j++)
            {
                bingoDiagLtoR[j] = bingoCard[i + j, j];
            }

            return _helper.Contains5InARow(bingoDiagLtoR);
        }

        private bool BingoDiagonalRightToLeft(BingoNumber[,] bingoCard, int i)
        {
            var bingoDiagRtoL = new BingoNumber[5];
            for (int j = _helper.GetRow(bingoCard, 0).Length - 1; j >= 0; j--)
            {
                bingoDiagRtoL[(j - 4) * -1] = bingoCard[i + (j - 4) * -1, j];
            }

            return _helper.Contains5InARow(bingoDiagRtoL);
        }
    }
}