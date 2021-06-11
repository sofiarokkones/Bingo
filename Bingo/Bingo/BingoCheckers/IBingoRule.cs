namespace Bingo.BingoCheckers
{
    public interface IBingoRule
    {
        bool CheckForBingoInRow(BingoNumber[,] bingoCard);
    }
}