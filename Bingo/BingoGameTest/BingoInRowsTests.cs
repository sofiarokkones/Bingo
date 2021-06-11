using Bingo;
using Bingo.BingoCheckers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BingoTests
{
    public class BingoInRowsTests
    {
        private IBingoRule _rule;
        
        [TestInitialize]
        public void TestInitialize()
        {
            _rule = new BingoInRows();
        }

        [TestMethod]
        public void Row_with_bingo_should_be_5_in_a_row()
        {
            BingoNumber[,] bingoCard = {
                {
                    new() {Value = "X"}, new() {Value = "X"}, new() {Value = "X"},
                    new() {Value = "X"}, new() {Value = "X"}
                },
                {
                    new() {Value = "1"}, new() {Value = "2"}, new() {Value = "3"},
                    new() {Value = "4"}, new() {Value = "5"}
                },
                {
                    new() {Value = "6"}, new() {Value = "7"}, new() {Value = "8"},
                    new() {Value = "9"}, new() {Value = "10"}
                },
                {
                    new() {Value = "11"}, new() {Value = "12"}, new() {Value = "13"},
                    new() {Value = "14"}, new() {Value = "15"}
                },
                {
                    new() {Value = "16"}, new() {Value = "17"}, new() {Value = "18"},
                    new() {Value = "19"}, new() {Value = "20"}
                }
            };
            bool result = _rule.CheckForBingoInRow(bingoCard);
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void Row_not_with_bingo_should_be_5_in_a_row()
        {
            BingoNumber[,] bingoCard = {
                {
                    new() {Value = "X"}, new() {Value = "X"}, new() {Value = "X"},
                    new() {Value = "21"}, new() {Value = "X"}
                },
                {
                    new() {Value = "1"}, new() {Value = "2"}, new() {Value = "3"},
                    new() {Value = "4"}, new() {Value = "5"}
                },
                {
                    new() {Value = "6"}, new() {Value = "7"}, new() {Value = "8"},
                    new() {Value = "9"}, new() {Value = "10"}
                },
                {
                    new() {Value = "11"}, new() {Value = "12"}, new() {Value = "13"},
                    new() {Value = "14"}, new() {Value = "15"}
                },
                {
                    new() {Value = "16"}, new() {Value = "17"}, new() {Value = "18"},
                    new() {Value = "19"}, new() {Value = "20"}
                }
            };
            bool result = _rule.CheckForBingoInRow(bingoCard);
            Assert.IsFalse(result);
        }
    }
}