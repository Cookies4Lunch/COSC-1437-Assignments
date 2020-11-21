using System;
using System.Collections.Generic;
using System.Text;

/*
 * ProfReynolds
 * did you forget something up here?
 */

namespace TicTacToe_Interfaces
{
    public interface ITicTacToeCell
    {
        /// <summary>
        /// Property indicating the row of the referenced square. (0-2)
        /// </summary>
        int RowID { get; set; }

        /// <summary>
        /// Property indicating the column of the referenced square. (0-2)
        /// </summary>
        int ColID { get; set; }

        /// <summary>
        /// Property indicating the owner of a square (human, computer, open, error)
        /// </summary>
        CellOwners CellOwner { get; set; }
    }
}
