namespace Main_Application

//Written by Spencer Johnson


{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReadEncryptedFile = new System.Windows.Forms.Button();
            this.btnWriteEncryptedFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFileOutput = new System.Windows.Forms.ListBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(20, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 291);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnReadEncryptedFile);
            this.panel1.Controls.Add(this.btnWriteEncryptedFile);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 335);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Read from SQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open SQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReadEncryptedFile
            // 
            this.btnReadEncryptedFile.Location = new System.Drawing.Point(13, 158);
            this.btnReadEncryptedFile.Name = "btnReadEncryptedFile";
            this.btnReadEncryptedFile.Size = new System.Drawing.Size(145, 50);
            this.btnReadEncryptedFile.TabIndex = 2;
            this.btnReadEncryptedFile.Text = "Read Encrypted File";
            this.btnReadEncryptedFile.UseVisualStyleBackColor = true;
            this.btnReadEncryptedFile.Click += new System.EventHandler(this.btnReadEncryptedFile_Click);
            // 
            // btnWriteEncryptedFile
            // 
            this.btnWriteEncryptedFile.Location = new System.Drawing.Point(13, 100);
            this.btnWriteEncryptedFile.Name = "btnWriteEncryptedFile";
            this.btnWriteEncryptedFile.Size = new System.Drawing.Size(145, 51);
            this.btnWriteEncryptedFile.TabIndex = 1;
            this.btnWriteEncryptedFile.Text = "Write Encrypted File";
            this.btnWriteEncryptedFile.UseVisualStyleBackColor = true;
            this.btnWriteEncryptedFile.Click += new System.EventHandler(this.btnWriteEncryptedFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 44);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(145, 49);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open CSV File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbFileOutput);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 335);
            this.panel2.TabIndex = 5;
            // 
            // lbFileOutput
            // 
            this.lbFileOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileOutput.FormattingEnabled = true;
            this.lbFileOutput.ItemHeight = 15;
            this.lbFileOutput.Location = new System.Drawing.Point(0, 23);
            this.lbFileOutput.Name = "lbFileOutput";
            this.lbFileOutput.Size = new System.Drawing.Size(605, 312);
            this.lbFileOutput.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFileName.Location = new System.Drawing.Point(0, 0);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(605, 23);
            this.txtFileName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(529, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 335);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(780, 357);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Master Assignment - Spencer Johnson";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbFileOutput;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnWriteEncryptedFile;
        private System.Windows.Forms.Button btnReadEncryptedFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

