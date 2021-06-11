using System;
using System.Collections.Generic;
using Bingo.BingoCheckers;

namespace Bingo
{
    public class BingoCardGame
    {
        private BingoNumber[,] _bingoCard { get; }
        private HashSet<int> _valInCard;
        private List<IBingoRule> _rules;
        private int _rows;
        private int _cols;
        private int _drawNbr;
        //private BingoCard _bingoCard { get; set; }

        public BingoCardGame(List<IBingoRule> rules, int rows)
        {
            _rows = rows;
            _cols = 5;
            _bingoCard = new BingoNumber[_rows, _cols];
            _valInCard = new HashSet<int>();
            _rules = rules;
            InitBingoCard();
        }

        private void InitBingoCard()
        {
            for (var r = 0; r < _rows; r++)
            {
                for (var c = 0; c < _cols; c++)
                {
                    AddValueToBingoCard(r, c);
                }
            }

            PrintBingoCard();
        }

        private void AddValueToBingoCard(int r, int c)
        {
            int value;
            do
            {
                value = new Random().Next(_rows*_cols);
            } while (!_valInCard.Add(value));

            _bingoCard[r, c] = new BingoNumber {Value = value.ToString()};
        }

        public void CheckIfDrawedNumberIsPresentInBingoCard()
        {
            DrawNumber();
            if (_valInCard.Contains(_drawNbr))
            {
                foreach (var place in _bingoCard)
                {
                    if (place.Value == _drawNbr.ToString())
                    {
                        place.Value = "X";
                    }
                }

                _valInCard.Remove(_drawNbr);
            }
        }

        private void DrawNumber()
        {
            _drawNbr = new Random().Next(_rows*_cols);
        }

        public bool CheckForBingo()
        {
            foreach (IBingoRule rule in _rules)
            {
                if (rule.CheckForBingoInRow(_bingoCard))
                    return true;
            }

            return false;
        }


        public void PrintBingoCard()
        {
            Console.Clear();
            foreach (var c in "BINGO")
            {
                Console.Write($"{c,5}");
            }

            Console.WriteLine();

            for (var r = 0; r < _rows; r++)
            {
                for (var c = 0; c < _cols; c++)
                {
                    if (_bingoCard[r, c].Value == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{_bingoCard[r, c].Value,5}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{_bingoCard[r, c].Value,5}");
                    }
                }

                Console.WriteLine();
                if ((r + 1) % 5 == 0)
                    Console.WriteLine();
            }
        }
    }
}