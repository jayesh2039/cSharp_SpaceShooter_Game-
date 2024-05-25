namespace SpaceShooter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Movebgtimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMuitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMotionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.replaybtn = new System.Windows.Forms.Button();
            this.exitebtn = new System.Windows.Forms.Button();
            this.scorelable = new System.Windows.Forms.Label();
            this.levellable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Movebgtimer
            // 
            this.Movebgtimer.Enabled = true;
            this.Movebgtimer.Interval = 10;
            this.Movebgtimer.Tick += new System.EventHandler(this.Movebgtimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(359, 501);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // MoveMuitionTimer
            // 
            this.MoveMuitionTimer.Enabled = true;
            this.MoveMuitionTimer.Interval = 20;
            this.MoveMuitionTimer.Tick += new System.EventHandler(this.MoveMuitionTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMotionTimer
            // 
            this.EnemiesMotionTimer.Enabled = true;
            this.EnemiesMotionTimer.Interval = 20;
            this.EnemiesMotionTimer.Tick += new System.EventHandler(this.EnemiesMotionTimer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Pristina", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 140);
            this.label1.TabIndex = 1;
            this.label1.Text = "Space Shooter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // replaybtn
            // 
            this.replaybtn.BackColor = System.Drawing.Color.MistyRose;
            this.replaybtn.Location = new System.Drawing.Point(259, 264);
            this.replaybtn.Name = "replaybtn";
            this.replaybtn.Size = new System.Drawing.Size(243, 67);
            this.replaybtn.TabIndex = 2;
            this.replaybtn.Text = "Replay";
            this.replaybtn.UseVisualStyleBackColor = false;
            this.replaybtn.Visible = false;
            this.replaybtn.Click += new System.EventHandler(this.replaybtn_Click);
            // 
            // exitebtn
            // 
            this.exitebtn.BackColor = System.Drawing.Color.MistyRose;
            this.exitebtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitebtn.Location = new System.Drawing.Point(259, 348);
            this.exitebtn.Name = "exitebtn";
            this.exitebtn.Size = new System.Drawing.Size(243, 60);
            this.exitebtn.TabIndex = 3;
            this.exitebtn.Text = "Exit";
            this.exitebtn.UseVisualStyleBackColor = false;
            this.exitebtn.Visible = false;
            this.exitebtn.Click += new System.EventHandler(this.exitebtn_Click);
            // 
            // scorelable
            // 
            this.scorelable.AutoSize = true;
            this.scorelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelable.ForeColor = System.Drawing.Color.LemonChiffon;
            this.scorelable.Location = new System.Drawing.Point(96, 2);
            this.scorelable.Name = "scorelable";
            this.scorelable.Size = new System.Drawing.Size(24, 26);
            this.scorelable.TabIndex = 4;
            this.scorelable.Text = "0";
            // 
            // levellable
            // 
            this.levellable.AutoSize = true;
            this.levellable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellable.ForeColor = System.Drawing.Color.LemonChiffon;
            this.levellable.Location = new System.Drawing.Point(747, -1);
            this.levellable.Name = "levellable";
            this.levellable.Size = new System.Drawing.Size(24, 26);
            this.levellable.TabIndex = 5;
            this.levellable.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "SCORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(651, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "LEVElS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levellable);
            this.Controls.Add(this.scorelable);
            this.Controls.Add(this.exitebtn);
            this.Controls.Add(this.replaybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Movebgtimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveMuitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMotionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replaybtn;
        private System.Windows.Forms.Button exitebtn;
        private System.Windows.Forms.Label scorelable;
        private System.Windows.Forms.Label levellable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

