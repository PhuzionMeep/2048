namespace _2048
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUP = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.txtBestScore = new System.Windows.Forms.TextBox();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lbl2048 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUP
            // 
            this.btnUP.AllowDrop = true;
            this.btnUP.Location = new System.Drawing.Point(536, 383);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(47, 32);
            this.btnUP.TabIndex = 2;
            this.btnUP.Text = "Up";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(490, 413);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(47, 32);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(536, 442);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(47, 32);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(581, 413);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(47, 32);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(517, 562);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(83, 36);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoSize = true;
            this.pnlBoard.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBoard.Location = new System.Drawing.Point(10, 162);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(395, 388);
            this.pnlBoard.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(373, 7);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 30);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "SCORE:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(376, 34);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(76, 40);
            this.txtScore.TabIndex = 9;
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.Location = new System.Drawing.Point(487, 7);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(135, 24);
            this.lblBestScore.TabIndex = 10;
            this.lblBestScore.Text = "BEST SCORE:";
            // 
            // txtBestScore
            // 
            this.txtBestScore.Location = new System.Drawing.Point(508, 34);
            this.txtBestScore.Multiline = true;
            this.txtBestScore.Name = "txtBestScore";
            this.txtBestScore.ReadOnly = true;
            this.txtBestScore.Size = new System.Drawing.Size(76, 40);
            this.txtBestScore.TabIndex = 11;
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(508, 85);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(74, 45);
            this.btnResetGame.TabIndex = 13;
            this.btnResetGame.Text = "Reset  Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(410, 177);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(276, 140);
            this.lblInstruction.TabIndex = 14;
            this.lblInstruction.Text = "Instruction: \r\nClick in any direction to move\r\nthe tile. If the tile matched, It " +
    "will \r\nmerge into a single tile. \r\nFor example, 2+2=4. \r\nTo win the game, Reach " +
    "2048.\r\nGOOD LUCK!";
            // 
            // lbl2048
            // 
            this.lbl2048.AutoSize = true;
            this.lbl2048.Font = new System.Drawing.Font("Franklin Gothic Medium", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2048.Location = new System.Drawing.Point(35, 19);
            this.lbl2048.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2048.Name = "lbl2048";
            this.lbl2048.Size = new System.Drawing.Size(278, 120);
            this.lbl2048.TabIndex = 15;
            this.lbl2048.Text = "2048";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnQuit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 596);
            this.Controls.Add(this.lbl2048);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.txtBestScore);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUP);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.TextBox txtBestScore;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lbl2048;
    }
}

