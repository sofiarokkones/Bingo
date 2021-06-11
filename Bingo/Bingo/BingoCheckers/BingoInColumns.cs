namespace Bingo.BingoCheckers
{
    public class BingoInColumns : IBingoRule
    {
        private readonly BingoHelpers _helper = new();

        public bool CheckForBingoInRow(BingoNumber[,] bingoCard)
        {
            for (int i = 0; i < _helper.GetRow(bingoCard, 0).Length; i++)
            {
                var bingoColumn = _helper.GetColumn(bingoCard, i);

                if (_helper.Contains5InARow(bingoColumn))
                    return true;
            }

            return false;
        }
    }
}