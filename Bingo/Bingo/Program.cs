using System;
using System.Collections.Generic;
using Bingo.BingoCheckers;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<IBingoRule>
            {
                new BingoInRows(), new BingoInColumns(), new BingoInDiagonals()
            };
            var game = new BingoCardGame(rules, 15);
            var bingo = false;
            var nbrOfTurns = 0;
            
            while (!bingo)
            {
                //Console.ReadKey();
                game.CheckIfDrawedNumberIsPresentInBingoCard();
                bingo = game.CheckForBingo();
                game.PrintBingoCard();
                nbrOfTurns++;
            } 
            game.PrintBingoCard();
            Console.WriteLine($"Number of tries to get bingo: {nbrOfTurns}");
        }
    }
}