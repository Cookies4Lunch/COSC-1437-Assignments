using Middle_Tier;
using System;
using System.Windows.Forms;
using CoreLibrary.Extensions;
using System.Diagnostics;
using TicTacToe_Interfaces;
using TicTacToeGraphics;

//Spencer Johnson

namespace Presentation_Tier2
{
    public partial class MainForm : Form
    {
        




        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        
        public MainForm()
        {
            InitializeComponent();

            
        }

        /*
         * ProfReynolds
         * I rearranged the methods. Does not change the operation but makes it easier to follow:
         * 1) constructor (MainForm) and never put anything other than InitializeComponent in the method
         * 2) form events especially the load event
         * 3) control events especially the click events
         * 4) other event handlers such as the _ticTacToeGame.CellOwnerChanged
         * 5) misc necessary methods (since very, very little implementation belongs in the UI, this should be limited)
         */

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
             * ProfReynolds
             * I created this event method for you.
             * check out the section in Unit 9: Presentation_Tier.MainForm
             * this is where you need to connect the event from the _ticTacToe class to the CellOwnerChangedHandler
             */
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void btnAbout_Click(object sender, EventArgs e)
        //{
        //    var newForm = new AboutBox1();
        //    newForm.Show();
        //}

        private void txtPlayerName_TextChanges(object sender, EventArgs e)
        {
            /*
             * ProfReynolds
             * good programming standards say that method variabloes should
             * follow the camel case format: playerNameIsValid
             */
            bool playerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = playerNameIsValid;
            btnGoComputer.Enabled = playerNameIsValid;
            //btnCell00.Enabled = PlayerNameIsValid;
            //btnCell01.Enabled = PlayerNameIsValid;
            //btnCell02.Enabled = PlayerNameIsValid;
            //btnCell10.Enabled = PlayerNameIsValid;
            //btnCell11.Enabled = PlayerNameIsValid;
            //btnCell12.Enabled = PlayerNameIsValid;
            //btnCell20.Enabled = PlayerNameIsValid;
            //btnCell21.Enabled = PlayerNameIsValid;
            //btnCell22.Enabled = PlayerNameIsValid;
            


            // as the content changes. this event will trigger as each character changes
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered

            _ticTacToeGame.PlayerName = txtPlayerName.Text;
            /*
             * ProfReynolds
             * at this point, you need to assign the txtPlayerName.Text to the _ticTacToe.PlayerName
             */
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            // when button is clicked, this event is triggered, causing game to start over
            //MessageBox.Show("btnStartNewGame", "Button Click!");


            _ticTacToeGame.ResetGrid();
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is GameCell gameCell)
                {
                    gameCell.GameCellOwner = CellOwners.Open;
                }
            }

        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // when button is clicked, the computer takes its turn

            //MessageBox.Show("btnGoComputer", "Button Click!");

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("Computer", "The Winner!");
                // ProfReynolds - this would be better: MessageBox.Show("Computer","The Winner!");
            }
        }

        /*
         * ProfReynolds
         * this single event method services all 9 buttons
         */
        private void btnCellxx_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != TicTacToe_Interfaces.CellOwners.Open) return;

            var btn = sender as Button;

            // btnCellXY
            var rowID = btn.Name.Substring(7, 1).ToInt();

            var colID = btn.Name.Substring(8, 1).ToInt();

            Debug.WriteLine($"Button click: row={rowID} col={colID}");

            _ticTacToeGame.AssignCellOwner(rowID, colID, TicTacToe_Interfaces.CellOwners.Human);
            btn.Text = "X";

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show(_ticTacToeGame.PlayerName, "The Winner!");
                // ProfReynolds - this would be better: MessageBox.Show(_ticTacToeGame.PlayerName,"The Winner!");
            }
        }

        private void CellOwnerChangedHandler(object sender, Middle_Tier.TicTacToeGame.CellOwnerChangedArgs e)
        {
            System.Diagnostics.Debug.Print($"CellOwnerChangedHandler {e.RowID},{e.ColID}");

            foreach (var control in tableLayoutPanel1.Controls)
            {
                if (control is GameCell gameCell)
                {
                    if (gameCell.GameCellRow == e.RowID &&
                        gameCell.GameCellCol == e.ColID)
                    {
                        gameCell.GameCellOwner = e.CellOwner;
                    }
                }
            }
        }

        private void gameCell_CellOwnerChanged(object sender)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            var gameCell = sender as GameCell;

            _ticTacToeGame.AssignCellOwner(gameCell.GameCellRow, gameCell.GameCellCol, CellOwners.Human);

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner is the Human!");
            }
            
        }

        
    }
}
