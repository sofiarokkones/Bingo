using Bingo;
using Bingo.BingoCheckers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BingoTests
{
    public class Contains5InARowTests
    { 
        private BingoHelpers _helper;
        
        [TestInitialize]
        public void TestInitialize()
        {
            _helper = new BingoHelpers();
        }

        [TestMethod]
        public void Row_with_bingo_should_be_5_in_a_row()
        {
            var bingoRow = new[]
            {
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "X"},
            };
            var result = _helper.Contains5InARow(bingoRow);
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void Row_not_with_bingo_should_be_5_in_a_row()
        {
            var bingoRow = new[]
            {
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "12"},
                new BingoNumber{Value = "X"},
                new BingoNumber{Value = "X"},
            };
            var result = _helper.Contains5InARow(bingoRow);
            Assert.IsFalse(result);
        }
        
    }
}