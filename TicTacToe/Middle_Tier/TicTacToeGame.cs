using System;
using System.Collections.ObjectModel;
using TicTacToe_Interfaces;
using System.Linq;

/*
 * Spencer Johnson
 */

namespace Middle_Tier
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "Human";
        public CellOwners Winner { get; private set; }

        // unit #9
        /// <summary>
        /// this delegate defines the event (and includes the parameters from above)
        /// </summary>
        /// <param name="sender">normal event object self reference</param>
        /// <param name="e">row, column, and owner of a marker (square)</param>
        public delegate void CellOwnerChangedHandler(object sender, CellOwnerChangedArgs e);

        /// <summary>
        /// The exposed event to the MainForm
        /// </summary>
        public event CellOwnerChangedHandler CellOwnerChanged;

        /// <inheritdoc />
        /// <summary>
        /// defines the parameters that are returned to the parent form when the event is triggered
        /// </summary>
        public class CellOwnerChangedArgs : EventArgs
        {
            public CellOwnerChangedArgs(int rowID, int colID, CellOwners cellOwner)
            {
                RowID = rowID;
                ColID = colID;
                CellOwner = cellOwner;
            }
            public int RowID { get; }
            public int ColID { get; }
            public CellOwners CellOwner { get; }
        }


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
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==0 && tttc.ColID==1),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==0),
                _ticTacToeCells.First(tttc => tttc.RowID==1 && tttc.ColID==2),
                _ticTacToeCells.First(tttc => tttc.RowID==2 && tttc.ColID==1),
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

            var targetCell = _ticTacToeCells.FirstOrDefault(tttc => tttc.RowID == CellRow && tttc.ColID == CellCol);

            if (targetCell == null)
                return;

            targetCell.CellOwner = CellOwner;

            // unit #9
            // these will be the arguments used when the event is fired
            var eventArgs = new CellOwnerChangedArgs(CellRow, CellCol, CellOwner);
            //bubble the event up to the parent ( ONLY if the parent is listening )
            CellOwnerChanged?.Invoke(this, eventArgs);

        }

        public void AutoPlayComputer()
        {
            /*
             * ProfReynolds
             * You are missing much here
             */


            /*
             * ProfReynolds
             * First, you must look to find a possible winning move
             * this will get you started
             */
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if (combination[1].CellOwner == CellOwners.Computer &&
                        combination[2].CellOwner == CellOwners.Computer)
                    {
                        AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if (combination[0].CellOwner == CellOwners.Computer &&
                        combination[2].CellOwner == CellOwners.Computer)
                    {
                        AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if (combination[0].CellOwner == CellOwners.Computer &&
                        combination[1].CellOwner == CellOwners.Computer)
                    {
                        AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }


            /*
             * ProfReynolds
             * Second, you must look to find a necessary blocking move to prevent the human from winning
             * this will get you started
             */
            foreach (var combination in _winningCombinations)
            {
                if (combination[0].CellOwner == CellOwners.Open)
                {
                    if (combination[1].CellOwner == CellOwners.Human &&
                        combination[2].CellOwner == CellOwners.Human)
                    {
                        AssignCellOwner(combination[0].RowID, combination[0].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[1].CellOwner == CellOwners.Open)
                {
                    if (combination[0].CellOwner == CellOwners.Human &&
                        combination[2].CellOwner == CellOwners.Human)
                    {
                        AssignCellOwner(combination[1].RowID, combination[1].ColID, CellOwners.Computer);
                        return;
                    }
                }
                if (combination[2].CellOwner == CellOwners.Open)
                {
                    if (combination[0].CellOwner == CellOwners.Human &&
                        combination[1].CellOwner == CellOwners.Human)
                    {
                        AssignCellOwner(combination[2].RowID, combination[2].ColID, CellOwners.Computer);
                        return;
                    }
                }
            }


            foreach (var targetCell in _goodNextMove)
            {
                if (targetCell.CellOwner == CellOwners.Open)
                {
                    
                    AssignCellOwner(targetCell.RowID, targetCell.ColID, CellOwners.Computer);
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
