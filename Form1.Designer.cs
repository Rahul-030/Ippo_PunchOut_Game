namespace Ippo_PunchOut_Game
{
    partial class Ippo_PunchOut_Game
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
            components = new System.ComponentModel.Container();
            BoxerHealthBar = new ProgressBar();
            PlayerHealthBar = new ProgressBar();
            Player = new PictureBox();
            Boxer = new PictureBox();
            BoxerAttackTimer = new System.Windows.Forms.Timer(components);
            BoxerMoveTimer = new System.Windows.Forms.Timer(components);
            BoxerWinCount = new Label();
            PlayerWinCount = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Boxer).BeginInit();
            SuspendLayout();
            // 
            // BoxerHealthBar
            // 
            BoxerHealthBar.Location = new Point(148, 94);
            BoxerHealthBar.Name = "BoxerHealthBar";
            BoxerHealthBar.Size = new Size(161, 23);
            BoxerHealthBar.TabIndex = 0;
            // 
            // PlayerHealthBar
            // 
            PlayerHealthBar.Location = new Point(473, 94);
            PlayerHealthBar.Name = "PlayerHealthBar";
            PlayerHealthBar.Size = new Size(161, 23);
            PlayerHealthBar.TabIndex = 1;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.boxer_stand;
            Player.Location = new Point(325, 354);
            Player.Name = "Player";
            Player.Size = new Size(61, 153);
            Player.SizeMode = PictureBoxSizeMode.AutoSize;
            Player.TabIndex = 2;
            Player.TabStop = false;
            // 
            // Boxer
            // 
            Boxer.AccessibleName = "";
            Boxer.BackColor = Color.Transparent;
            Boxer.Image = Properties.Resources.enemy_stand1;
            Boxer.Location = new Point(392, 276);
            Boxer.Name = "Boxer";
            Boxer.Size = new Size(77, 185);
            Boxer.SizeMode = PictureBoxSizeMode.AutoSize;
            Boxer.TabIndex = 3;
            Boxer.TabStop = false;
            // 
            // BoxerAttackTimer
            // 
            BoxerAttackTimer.Enabled = true;
            BoxerAttackTimer.Interval = 500;
            BoxerAttackTimer.Tick += BoxerAttackTimerEvent;
            // 
            // BoxerMoveTimer
            // 
            BoxerMoveTimer.Enabled = true;
            BoxerMoveTimer.Interval = 20;
            BoxerMoveTimer.Tick += BoxerMoveTimerEvent;
            // 
            // BoxerWinCount
            // 
            BoxerWinCount.AutoSize = true;
            BoxerWinCount.Location = new Point(129, 102);
            BoxerWinCount.Name = "BoxerWinCount";
            BoxerWinCount.Size = new Size(13, 15);
            BoxerWinCount.TabIndex = 4;
            BoxerWinCount.Text = "0";
            BoxerWinCount.Click += BoxerWinCount_Click;
            // 
            // PlayerWinCount
            // 
            PlayerWinCount.AutoSize = true;
            PlayerWinCount.Location = new Point(640, 102);
            PlayerWinCount.Name = "PlayerWinCount";
            PlayerWinCount.Size = new Size(13, 15);
            PlayerWinCount.TabIndex = 5;
            PlayerWinCount.Text = "0";
            // 
            // Ippo_PunchOut_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 561);
            Controls.Add(PlayerWinCount);
            Controls.Add(BoxerWinCount);
            Controls.Add(Player);
            Controls.Add(PlayerHealthBar);
            Controls.Add(BoxerHealthBar);
            Controls.Add(Boxer);
            DoubleBuffered = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Ippo_PunchOut_Game";
            Text = "Ippo_PunchOut_Game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Boxer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar BoxerHealthBar;
        private ProgressBar PlayerHealthBar;
        private PictureBox Player;
        private PictureBox Boxer;
        private System.Windows.Forms.Timer BoxerAttackTimer;
        private System.Windows.Forms.Timer BoxerMoveTimer;
        private Label BoxerWinCount;
        private Label PlayerWinCount;
    }
}