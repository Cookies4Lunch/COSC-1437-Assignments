namespace UI_Layer_CSharp
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCell00 = new System.Windows.Forms.Button();
            this.btnCell01 = new System.Windows.Forms.Button();
            this.btnCell02 = new System.Windows.Forms.Button();
            this.btnCell10 = new System.Windows.Forms.Button();
            this.btnCell11 = new System.Windows.Forms.Button();
            this.btnCell12 = new System.Windows.Forms.Button();
            this.btnCell20 = new System.Windows.Forms.Button();
            this.btnCell21 = new System.Windows.Forms.Button();
            this.btnCell22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(13, 43);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(115, 30);
            this.btnStartNewGame.TabIndex = 1;
            this.btnStartNewGame.Text = "Start New Game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(13, 81);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(115, 30);
            this.btnGoComputer.TabIndex = 2;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
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
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 323);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(130, 35);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About Tic Tac Toe";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCell00
            // 
            this.btnCell00.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell00.Location = new System.Drawing.Point(203, 81);
            this.btnCell00.Name = "btnCell00";
            this.btnCell00.Size = new System.Drawing.Size(85, 85);
            this.btnCell00.TabIndex = 5;
            this.btnCell00.Text = "?";
            this.btnCell00.UseVisualStyleBackColor = true;
            // 
            // btnCell01
            // 
            this.btnCell01.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell01.Location = new System.Drawing.Point(294, 81);
            this.btnCell01.Name = "btnCell01";
            this.btnCell01.Size = new System.Drawing.Size(85, 85);
            this.btnCell01.TabIndex = 5;
            this.btnCell01.Text = "?";
            this.btnCell01.UseVisualStyleBackColor = true;
            // 
            // btnCell02
            // 
            this.btnCell02.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell02.Location = new System.Drawing.Point(385, 81);
            this.btnCell02.Name = "btnCell02";
            this.btnCell02.Size = new System.Drawing.Size(85, 85);
            this.btnCell02.TabIndex = 5;
            this.btnCell02.Text = "?";
            this.btnCell02.UseVisualStyleBackColor = true;
            // 
            // btnCell10
            // 
            this.btnCell10.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell10.Location = new System.Drawing.Point(203, 172);
            this.btnCell10.Name = "btnCell10";
            this.btnCell10.Size = new System.Drawing.Size(85, 85);
            this.btnCell10.TabIndex = 5;
            this.btnCell10.Text = "?";
            this.btnCell10.UseVisualStyleBackColor = true;
            // 
            // btnCell11
            // 
            this.btnCell11.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell11.Location = new System.Drawing.Point(294, 172);
            this.btnCell11.Name = "btnCell11";
            this.btnCell11.Size = new System.Drawing.Size(85, 85);
            this.btnCell11.TabIndex = 5;
            this.btnCell11.Text = "?";
            this.btnCell11.UseVisualStyleBackColor = true;
            // 
            // btnCell12
            // 
            this.btnCell12.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell12.Location = new System.Drawing.Point(385, 172);
            this.btnCell12.Name = "btnCell12";
            this.btnCell12.Size = new System.Drawing.Size(85, 85);
            this.btnCell12.TabIndex = 5;
            this.btnCell12.Text = "?";
            this.btnCell12.UseVisualStyleBackColor = true;
            // 
            // btnCell20
            // 
            this.btnCell20.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell20.Location = new System.Drawing.Point(203, 263);
            this.btnCell20.Name = "btnCell20";
            this.btnCell20.Size = new System.Drawing.Size(85, 85);
            this.btnCell20.TabIndex = 5;
            this.btnCell20.Text = "?";
            this.btnCell20.UseVisualStyleBackColor = true;
            // 
            // btnCell21
            // 
            this.btnCell21.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell21.Location = new System.Drawing.Point(294, 263);
            this.btnCell21.Name = "btnCell21";
            this.btnCell21.Size = new System.Drawing.Size(85, 85);
            this.btnCell21.TabIndex = 5;
            this.btnCell21.Text = "?";
            this.btnCell21.UseVisualStyleBackColor = true;
            // 
            // btnCell22
            // 
            this.btnCell22.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell22.Location = new System.Drawing.Point(385, 263);
            this.btnCell22.Name = "btnCell22";
            this.btnCell22.Size = new System.Drawing.Size(85, 85);
            this.btnCell22.TabIndex = 5;
            this.btnCell22.Text = "?";
            this.btnCell22.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnCell22);
            this.Controls.Add(this.btnCell21);
            this.Controls.Add(this.btnCell20);
            this.Controls.Add(this.btnCell12);
            this.Controls.Add(this.btnCell11);
            this.Controls.Add(this.btnCell10);
            this.Controls.Add(this.btnCell02);
            this.Controls.Add(this.btnCell01);
            this.Controls.Add(this.btnCell00);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe CSharp Version - Spencer Johnson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCell00;
        private System.Windows.Forms.Button btnCell01;
        private System.Windows.Forms.Button btnCell02;
        private System.Windows.Forms.Button btnCell10;
        private System.Windows.Forms.Button btnCell11;
        private System.Windows.Forms.Button btnCell12;
        private System.Windows.Forms.Button btnCell20;
        private System.Windows.Forms.Button btnCell21;
        private System.Windows.Forms.Button btnCell22;
    }
}

