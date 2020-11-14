using Middle_Tier;
using System;
using System.Windows.Forms;
using CoreLibrary.Extensions;
using System.Diagnostics;

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        //private TicTacToeGame _ticTacToeGame = new TicTacToeGame();
        public MainForm()
        {
            InitializeComponent();

            txtPlayerName.Text = "Spencer";
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
            bool PlayerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = PlayerNameIsValid;
            btnGoComputer.Enabled = PlayerNameIsValid;
            //btnCell00.Enabled = PlayerNameIsValid;
            //btnCell01.Enabled = PlayerNameIsValid;
            //btnCell02.Enabled = PlayerNameIsValid;
            //btnCell10.Enabled = PlayerNameIsValid;
            //btnCell11.Enabled = PlayerNameIsValid;
            //btnCell12.Enabled = PlayerNameIsValid;
            //btnCell20.Enabled = PlayerNameIsValid;
            //btnCell21.Enabled = PlayerNameIsValid;
            //btnCell22.Enabled = PlayerNameIsValid;
            panel1.Enabled = PlayerNameIsValid;


            // as the content changes. this event will trigger as each character changes
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            // when button is clicked, this event is triggered, causing game to start over
            //MessageBox.Show("btnStartNewGame", "Button Click!");


            _ticTacToeGame.ResetGrid();
            foreach (var item in panel1.Controls)
            {
                if (item is Button btn)
                {
                    btn.Text = "?";
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
                MessageBox.Show("Winner!");
            }
        }

        private void btnCellxx_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != TicTacToe_Interfaces.CellOwners.Open) return;

            var btn = sender as Button;

            var rowID = btn.Name.Substring(7, 1).ToInt();

            var colID = btn.Name.Substring(7, 1).ToInt();

            Debug.WriteLine($"Button click: row={rowID} col={colID}");

            _ticTacToeGame.AssignCellOwner(rowID, colID, TicTacToe_Interfaces.CellOwners.Human);
            btn.Text = "X";

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }


    }
}
