using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_Interfaces;

//Written by Spencer Johnson

namespace Business_Layer_CSharp
{
    public class TicTacToeCell : ITicTacToeCell
    {
        
        public int RowID { get; set; }

        
        public int ColID { get; set; }

        
        public CellOwners CellOwner { get; set; } = CellOwners.Open;
    }
}
