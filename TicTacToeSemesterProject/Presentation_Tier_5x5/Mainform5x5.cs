using Middle_Tier;
using System;
using System.Windows.Forms;
using CoreLibrary.Extensions;
using System.Diagnostics;
using TicTacToe_Interfaces;

//Spencer Johnson

namespace Presentation_Tier_5x5
{
    public partial class Mainform5x5 : Form
    {
        




        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        
        public Mainform5x5()
        {
            InitializeComponent();

            _ticTacToeGame.GridSize = 5;
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox1();
            newForm.Show();
        }

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
            panel1.Enabled = playerNameIsValid;


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
            btnGoComputer.Enabled = true;

            _ticTacToeGame.ResetGrid();
            foreach (var item in panel1.Controls)
            {
                if (item is Button btn)
                {
                    if (btn.Name != "btnWildCard")
                    {
                        btn.Text = "?";
                    }
                }
            }

        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != TicTacToe_Interfaces.CellOwners.Open) return;

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("Computer", "The Winner!");
                
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
            var buttonName = $"btnCell{e.RowID}{e.ColID}";
            foreach (var control in panel1.Controls)
            {
                if (control is Button button)
                {
                    if (button.Name == buttonName)
                    {
                        switch (e.CellOwner)
                        {
                            case CellOwners.Error:
                                button.Text = "#";
                                break;

                            case CellOwners.Open:
                                button.Text = "?";
                                break;

                            case CellOwners.Human:
                                button.Text = "X";
                                break;

                            case CellOwners.Computer:
                                button.Text = "O";
                                break;

                        }
                    }
                }
            }
        }

    }
}
