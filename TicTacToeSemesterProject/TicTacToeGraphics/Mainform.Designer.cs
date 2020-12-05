namespace Presentation_Tier2
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameCell9 = new TicTacToeGraphics.GameCell();
            this.gameCell8 = new TicTacToeGraphics.GameCell();
            this.gameCell7 = new TicTacToeGraphics.GameCell();
            this.gameCell6 = new TicTacToeGraphics.GameCell();
            this.gameCell5 = new TicTacToeGraphics.GameCell();
            this.gameCell4 = new TicTacToeGraphics.GameCell();
            this.gameCell3 = new TicTacToeGraphics.GameCell();
            this.gameCell2 = new TicTacToeGraphics.GameCell();
            this.gameCell1 = new TicTacToeGraphics.GameCell();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(13, 13);
            this.txtPlayerName.MaxLength = 25;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(223, 23);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.Text = "Spencer";
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanges);
            this.txtPlayerName.VisibleChanged += new System.EventHandler(this.txtPlayerName_Validated);
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(13, 43);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(115, 30);
            this.btnStartNewGame.TabIndex = 1;
            this.btnStartNewGame.Text = "Start New Game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(13, 81);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(115, 30);
            this.btnGoComputer.TabIndex = 2;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Tic Tac Toe";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.gameCell9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 366);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // gameCell9
            // 
            this.gameCell9.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell9.BackgroundImage")));
            this.gameCell9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell9.GameCellCol = 2;
            this.gameCell9.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell9.GameCellRow = 2;
            this.gameCell9.Location = new System.Drawing.Point(275, 247);
            this.gameCell9.Name = "gameCell9";
            this.gameCell9.Size = new System.Drawing.Size(129, 116);
            this.gameCell9.TabIndex = 0;
            this.gameCell9.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell8
            // 
            this.gameCell8.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell8.BackgroundImage")));
            this.gameCell8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell8.GameCellCol = 1;
            this.gameCell8.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell8.GameCellRow = 2;
            this.gameCell8.Location = new System.Drawing.Point(137, 247);
            this.gameCell8.Name = "gameCell8";
            this.gameCell8.Size = new System.Drawing.Size(132, 116);
            this.gameCell8.TabIndex = 0;
            this.gameCell8.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell7
            // 
            this.gameCell7.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell7.BackgroundImage")));
            this.gameCell7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell7.GameCellCol = 0;
            this.gameCell7.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell7.GameCellRow = 2;
            this.gameCell7.Location = new System.Drawing.Point(3, 247);
            this.gameCell7.Name = "gameCell7";
            this.gameCell7.Size = new System.Drawing.Size(128, 116);
            this.gameCell7.TabIndex = 0;
            this.gameCell7.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell6
            // 
            this.gameCell6.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell6.BackgroundImage")));
            this.gameCell6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell6.GameCellCol = 2;
            this.gameCell6.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell6.GameCellRow = 1;
            this.gameCell6.Location = new System.Drawing.Point(275, 123);
            this.gameCell6.Name = "gameCell6";
            this.gameCell6.Size = new System.Drawing.Size(129, 118);
            this.gameCell6.TabIndex = 0;
            this.gameCell6.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell5
            // 
            this.gameCell5.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell5.BackgroundImage")));
            this.gameCell5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell5.GameCellCol = 1;
            this.gameCell5.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell5.GameCellRow = 1;
            this.gameCell5.Location = new System.Drawing.Point(137, 123);
            this.gameCell5.Name = "gameCell5";
            this.gameCell5.Size = new System.Drawing.Size(132, 118);
            this.gameCell5.TabIndex = 0;
            this.gameCell5.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell4
            // 
            this.gameCell4.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell4.BackgroundImage")));
            this.gameCell4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell4.GameCellCol = 0;
            this.gameCell4.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell4.GameCellRow = 1;
            this.gameCell4.Location = new System.Drawing.Point(3, 123);
            this.gameCell4.Name = "gameCell4";
            this.gameCell4.Size = new System.Drawing.Size(128, 118);
            this.gameCell4.TabIndex = 0;
            this.gameCell4.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell3
            // 
            this.gameCell3.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell3.BackgroundImage")));
            this.gameCell3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell3.GameCellCol = 2;
            this.gameCell3.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell3.GameCellRow = 0;
            this.gameCell3.Location = new System.Drawing.Point(275, 3);
            this.gameCell3.Name = "gameCell3";
            this.gameCell3.Size = new System.Drawing.Size(129, 114);
            this.gameCell3.TabIndex = 0;
            this.gameCell3.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell2
            // 
            this.gameCell2.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell2.BackgroundImage")));
            this.gameCell2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell2.GameCellCol = 1;
            this.gameCell2.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell2.GameCellRow = 0;
            this.gameCell2.Location = new System.Drawing.Point(137, 3);
            this.gameCell2.Name = "gameCell2";
            this.gameCell2.Size = new System.Drawing.Size(132, 114);
            this.gameCell2.TabIndex = 0;
            this.gameCell2.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell1
            // 
            this.gameCell1.BackColor = System.Drawing.Color.LightYellow;
            this.gameCell1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell1.BackgroundImage")));
            this.gameCell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell1.GameCellCol = 0;
            this.gameCell1.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell1.GameCellRow = 0;
            this.gameCell1.Location = new System.Drawing.Point(3, 3);
            this.gameCell1.Name = "gameCell1";
            this.gameCell1.Size = new System.Drawing.Size(128, 114);
            this.gameCell1.TabIndex = 0;
            this.gameCell1.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(793, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.txtPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe with UserControls - Spencer Johnson";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TicTacToeGraphics.GameCell gameCell9;
        private TicTacToeGraphics.GameCell gameCell8;
        private TicTacToeGraphics.GameCell gameCell7;
        private TicTacToeGraphics.GameCell gameCell6;
        private TicTacToeGraphics.GameCell gameCell5;
        private TicTacToeGraphics.GameCell gameCell4;
        private TicTacToeGraphics.GameCell gameCell3;
        private TicTacToeGraphics.GameCell gameCell2;
        private TicTacToeGraphics.GameCell gameCell1;
    }
}

