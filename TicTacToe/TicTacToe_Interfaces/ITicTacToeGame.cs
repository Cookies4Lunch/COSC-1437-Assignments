using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeGame
    {
        string PlayerName { get; set; }

        CellOwners IdentifyCellOwner(int CellRow, int CellCol);

        void SetCellOwner(int CellRow, int CellCol, CellOwners CellOwner);
    }
}
