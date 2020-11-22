namespace Game_Caro
{
    partial class CaroWithYourFrends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaroWithYourFrends));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.pictureGame = new System.Windows.Forms.PictureBox();
            this.picIn4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.picMarkPlayer = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarkPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlChessBoard.Location = new System.Drawing.Point(2, 27);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(646, 555);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlInfor
            // 
            this.pnlInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlInfor.Controls.Add(this.pictureGame);
            this.pnlInfor.Controls.Add(this.picIn4);
            this.pnlInfor.Controls.Add(this.label2);
            this.pnlInfor.Controls.Add(this.button1);
            this.pnlInfor.Controls.Add(this.label1);
            this.pnlInfor.Controls.Add(this.txtIP);
            this.pnlInfor.Controls.Add(this.txtNamePlayer);
            this.pnlInfor.Controls.Add(this.picMarkPlayer);
            this.pnlInfor.Location = new System.Drawing.Point(654, 12);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(179, 548);
            this.pnlInfor.TabIndex = 2;
            // 
            // pictureGame
            // 
            this.pictureGame.BackgroundImage = global::Game_Caro.Properties.Resources.imageGame;
            this.pictureGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureGame.Location = new System.Drawing.Point(5, 3);
            this.pictureGame.Name = "pictureGame";
            this.pictureGame.Size = new System.Drawing.Size(167, 159);
            this.pictureGame.TabIndex = 7;
            this.pictureGame.TabStop = false;
            // 
            // picIn4
            // 
            this.picIn4.BackgroundImage = global::Game_Caro.Properties.Resources.maker;
            this.picIn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIn4.Location = new System.Drawing.Point(5, 372);
            this.picIn4.Name = "picIn4";
            this.picIn4.Size = new System.Drawing.Size(167, 167);
            this.picIn4.TabIndex = 6;
            this.picIn4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP LAN";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(9, 323);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(166, 20);
            this.txtIP.TabIndex = 2;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Location = new System.Drawing.Point(7, 284);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(167, 20);
            this.txtNamePlayer.TabIndex = 1;
            // 
            // picMarkPlayer
            // 
            this.picMarkPlayer.Location = new System.Drawing.Point(26, 168);
            this.picMarkPlayer.Name = "picMarkPlayer";
            this.picMarkPlayer.Size = new System.Drawing.Size(132, 90);
            this.picMarkPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMarkPlayer.TabIndex = 0;
            this.picMarkPlayer.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu ";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitGameToolStripMenuItem.Text = "Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.QuitGameToolStripMenuItem_Click);
            // 
            // CaroWithYourFrends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 563);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaroWithYourFrends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro With Your Frends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.CaroWithYourFrends_Shown);
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarkPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.PictureBox picIn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.PictureBox picMarkPlayer;
        private System.Windows.Forms.PictureBox pictureGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
    }
}

