using System;
using TicTacToe_Interfaces;



//Written by Spencer Johnson

namespace Middle_Tier
{
    public class TicTacToeCell : ITicTacToeCell
    {
        private const int MinimumRowId = 0;
        private const int MaximumRowId = 2;

        private const int MinimumColId = 0;
        private const int MaximumColId = 2;

        private int _rowId;
        public int RowID
        {
            get => _rowId;
            set
            {
                if ((value < MinimumRowId) || (value > MaximumRowId))
                {
                    throw new ArgumentOutOfRangeException();
                }

                _rowId = value;
            }
        }

        private int _colId;
        public int ColID
        {
            get => _colId;
            set
            {
                if ((value < MinimumColId) || (value > MaximumColId))
                {
                    throw new ArgumentOutOfRangeException();
                }

                _colId = value;
            }
        }

        public CellOwners CellOwner { get; set; } = CellOwners.Open;
    }
}
