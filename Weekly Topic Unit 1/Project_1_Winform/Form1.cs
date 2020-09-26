using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Spencer M Johnson
 */

namespace Project_1_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMessageBoxPopup_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This is a message box", 
                "This is the title bar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
