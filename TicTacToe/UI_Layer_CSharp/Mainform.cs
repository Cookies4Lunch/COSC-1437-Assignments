using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layer_CSharp
{
    public partial class MainForm : Form
    {
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
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // when button is clicked, the computer takes its turn
        }

        private void btnCell00_Click(object sender, EventArgs e)
        {

        }

        private void btnCell01_Click(object sender, EventArgs e)
        {

        }

        private void btnCell02_Click(object sender, EventArgs e)
        {

        }

        private void btnCell10_Click(object sender, EventArgs e)
        {

        }

        private void btnCell11_Click(object sender, EventArgs e)
        {

        }

        private void btnCell12_Click(object sender, EventArgs e)
        {

        }

        private void btnCell20_Click(object sender, EventArgs e)
        {

        }

        private void btnCell21_Click(object sender, EventArgs e)
        {

        }

        private void btnCell22_Click(object sender, EventArgs e)
        {

        }

        
    }
}
