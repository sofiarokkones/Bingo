using System.Linq;

namespace Bingo.BingoCheckers
{
    public class BingoHelpers{
            
        public bool Contains5InARow(BingoNumber[] data)
        {
            for (var i = 0; i < data.Length - 4; ++i)
                if (data[i].Value == "X" && data[i + 1].Value == "X" && data[i + 2].Value== "X" &&  data[i + 3].Value == "X" && data[i + 4].Value == "X")
                    return true;
            return false;
        }

        public BingoNumber[] GetColumn(BingoNumber[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                .Select(x => matrix[x, columnNumber])
                .ToArray();
        }

        public BingoNumber[] GetRow(BingoNumber[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                .Select(x => matrix[rowNumber, x])
                .ToArray();
        }
    }
}