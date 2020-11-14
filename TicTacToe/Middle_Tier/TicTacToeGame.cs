using System;
using System.Collections.ObjectModel;
using TicTacToe_Interfaces;
using System.Linq;

/*
 * ProfReynolds
 */

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";
        public CellOwners Winner { get; private set; }


        /// <summary>
        ///     This class defines a set of cells
        /// </summary>
        private readonly Collection<TicTacToeCell> _ticTacToeCells = new Collection<TicTacToeCell>();
        private Collection<TicTacToeCell> _goodNextMove;
        private Collection<Collection<TicTacToeCell>> _winningCombinations;

        // notice - no constructor. I dont think one is needed

        public void ResetGrid()
        {
            _ticTacToeCells.Clear(); // resets the collection to empty

            Winner = CellOwners.Open;

            // create the 9 cells
            for (var rowNo = 0; rowNo < 3; rowNo++)
                for (var colNo = 0; colNo < 3; colNo++)
                {
                    _ticTacToeCells.Add(new TicTacToeCell
                    {
                        RowID = rowNo,
                        ColID = colNo
                    });
                }

            _goodNextMove = new Collection<TicTacToeCell>()
            {
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==1 && TicTacToeCell.ColID==1),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==0 && TicTacToeCell.ColID==0),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==0 && TicTacToeCell.ColID==2),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==2 && TicTacToeCell.ColID==0),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==2 && TicTacToeCell.ColID==2),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==0 && TicTacToeCell.ColID==1),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==1 && TicTacToeCell.ColID==0),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==1 && TicTacToeCell.ColID==2),
                _ticTacToeCells.First(TicTacToeCell => TicTacToeCell.RowID==2 && TicTacToeCell.ColID==1),
            };

            _winningCombinations = new Collection<Collection<TicTacToeCell>>()
            {
                new Collection<TicTacToeCell>() // loading the first row
                {
                    // the reference to these objects is in the collection - not new ones!
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the second row
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>()
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
                new Collection<TicTacToeCell>() // loading the first column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0)
                },
                new Collection<TicTacToeCell>() // loading the second column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1)
                },
                new Collection<TicTacToeCell>() // loading the third column
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },

                new Collection<TicTacToeCell>() // loading beginning diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0)
                },
                new Collection<TicTacToeCell>() // loading final diagonal
                {
                    _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                    _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                    _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2)
                },
            };

            

        }

        public CellOwners IdentifyCellOwner(int CellRow, int CellCol)
        {
            if (_ticTacToeCells.Count == 0)
                return CellOwners.Error;

            return _ticTacToeCells
                .FirstOrDefault(TicTacToeCell => TicTacToeCell.RowID == CellRow && TicTacToeCell.ColID == CellCol)
                ?.CellOwner
                ?? CellOwners.Error;

            //var targetCell = _ticTacToeCells.FirstOrDefault(TicTacToeCell => TicTacToeCell.RowID == CellRow && TicTacToeCell.ColID == CellCol);

            //if (targetCell == null)
            //    return CellOwners.Error;

            //return targetCell.CellOwner;
        }

        public void AssignCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            if (_ticTacToeCells.Count == 0)
                return;

            var targetCell = _ticTacToeCells.FirstOrDefault(TicTacToeCell => TicTacToeCell.RowID == CellRow && TicTacToeCell.ColID == CellCol);

            if (targetCell == null)
                return;

            targetCell.CellOwner = CellOwner;
        }

        public void AutoPlayComputer()
        {
            foreach (var targetCell in _goodNextMove)
            {
                if (targetCell.CellOwner == CellOwners.Open)
                {
                    targetCell.CellOwner = CellOwners.Computer;
                    return;
                }
            }
        }

        public bool CheckForWinner()
        {

            #region Human
            ////first row
            //if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
            //   (IdentifyCellOwner(0, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(0, 2) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}

            ////second row
            //if ((IdentifyCellOwner(1, 0) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 2) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}

            ////third row
            //if ((IdentifyCellOwner(2, 0) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 2) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}



            ////first column
            //if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 0) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 0) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}

            ////second column 
            //if ((IdentifyCellOwner(0, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 1) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}

            ////third column
            //if ((IdentifyCellOwner(0, 2) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 2) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 2) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}



            ////first diagonal
            //if ((IdentifyCellOwner(0, 0) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 2) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}

            ////second diagonal
            //if ((IdentifyCellOwner(0, 2) == CellOwners.Human) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Human) &&
            //   (IdentifyCellOwner(2, 0) == CellOwners.Human))
            //{
            //    Winner = CellOwners.Human;
            //    return true;
            //}
            #endregion

            #region Computer
            ////first row
            //if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(0, 2) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}

            ////second row
            //if ((IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 2) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}

            ////third row
            //if ((IdentifyCellOwner(2, 0) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 2) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}



            ////first column
            //if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 0) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 0) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}

            ////second column 
            //if ((IdentifyCellOwner(0, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 1) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}

            ////third column
            //if ((IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 2) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 2) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}



            ////first diagonal
            //if ((IdentifyCellOwner(0, 0) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 2) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}

            ////second diagonal
            //if ((IdentifyCellOwner(0, 2) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(1, 1) == CellOwners.Computer) &&
            //   (IdentifyCellOwner(2, 0) == CellOwners.Computer))
            //{
            //    Winner = CellOwners.Computer;
            //    return true;
            //}
            #endregion

            foreach (var combination in _winningCombinations)
            {
                var firstCell = combination[0];

                if ((firstCell.CellOwner != CellOwners.Computer) && 
                    (firstCell.CellOwner != CellOwners.Human)) continue;

                if ((firstCell.CellOwner != combination[1].CellOwner) ||
                    (firstCell.CellOwner != combination[2].CellOwner)) continue;

                Winner = firstCell.CellOwner;

                return true;
            }

            return false;
        }

        public string IdentifyWinner()
        {
            switch (Winner)
            {
                case CellOwners.Computer:
                    return "Computer";

                case CellOwners.Human:
                    return PlayerName == "" ? "Unnamed Human" : PlayerName;

                case CellOwners.Open:
                    return string.Empty;

                default:
                    return "Error";
            }
        }

    }
}
