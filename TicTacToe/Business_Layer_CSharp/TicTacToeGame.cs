﻿using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe_Interfaces;

//Written by Spencer Johnson

namespace Business_Layer_CSharp
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public string PlayerName { get; set; } = "The Human";

        public CellOwners IdentifyCellOwners(int CellRow, int CellCol)
        {
            throw new NotImplementedException();
        }

        public void SetCellOwner(int CellRow, int CellCol, CellOwners CellOwner)
        {
            throw new NotImplementedException();
        }
    }
}
