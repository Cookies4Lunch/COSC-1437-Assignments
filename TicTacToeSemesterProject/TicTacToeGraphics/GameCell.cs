using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TicTacToe_Interfaces;

namespace TicTacToeGraphics
{
    public partial class GameCell : UserControl
    {
        
        public delegate void CellOwnerChangedHandler(object sender);
        public event CellOwnerChangedHandler CellOwnerChanged;

        public int GameCellRow { get; set; }
        public int GameCellCol { get; set; }
        private CellOwners _cellOwner = CellOwners.Error;
        public CellOwners GameCellOwner 
        {
            get { return _cellOwner; }
            set
            {
                _cellOwner = value;
                switch (value)
                {
                    case CellOwners.Error:
                        this.BackgroundImage = Properties.Resources.smiley;
                        break;
                    case CellOwners.Open:
                        this.BackgroundImage = Properties.Resources.OpenCell;
                        break;
                    case CellOwners.Human:
                        this.BackgroundImage = Properties.Resources.biden;
                        break;
                    case CellOwners.Computer:
                        this.BackgroundImage = Properties.Resources.trump;
                        break;
                    default:
                        this.BackgroundImage = Properties.Resources.smiley;
                        break;
                }
            } 
        }



        public GameCell()
        {
            InitializeComponent();
        }

        

        private void GameCell_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Print($"GameCell_Click {GameCellRow},{GameCellCol}");
            CellOwnerChanged?.Invoke(this);
        }
    }
}
