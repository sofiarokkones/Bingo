namespace Bingo.BingoCheckers
{
    public class BingoInRows : IBingoRule
    {
        private readonly BingoHelpers _helper = new();
        public bool CheckForBingoInRow(BingoNumber[,] bingoCard) 
        {
            for (int i = 0; i < _helper.GetColumn(bingoCard, 0).Length; i++)
            {
                var bingoRow = _helper.GetRow(bingoCard, i);
                if (_helper.Contains5InARow(bingoRow))
                    return true;
            }

            return false;
        }
    }
}