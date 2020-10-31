using System;
using System.Windows.Forms;

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame ticTacToeGame = new Middle_Tier.TicTacToeGame();
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

            var btn = item as Button; 
            if (btn != null) 
            { 
                btn.Text = "?"; 
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

        private void btnCell00_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell00", "Button Click!");
        }

        private void btnCell01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell01", "Button Click!");
        }

        private void btnCell02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell02", "Button Click!");
        }

        private void btnCell10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell10", "Button Click!");
        }

        private void btnCell11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell11", "Button Click!");
        }

        private void btnCell12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell12", "Button Click!");
        }

        private void btnCell20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell20", "Button Click!");
        }

        private void btnCell21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell21", "Button Click!");
        }

        private void btnCell22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell22", "Button Click!");
        }

        
    }
}
