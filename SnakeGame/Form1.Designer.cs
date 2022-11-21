
namespace SnakeGame
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.infos = new System.Windows.Forms.Label();
            this.pictureBox_win = new System.Windows.Forms.PictureBox();
            this.txtTimer = new System.Windows.Forms.Label();
            this.timerBarriera = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.goHomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.timerGoHome = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_win)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Transparent;
            this.picCanvas.BackgroundImage = global::SnakeGame.Properties.Resources.ozz;
            this.picCanvas.ErrorImage = null;
            this.picCanvas.Location = new System.Drawing.Point(12, 102);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1091, 460);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.SkyBlue;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtScore.Location = new System.Drawing.Point(831, 28);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(272, 36);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 70;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.BackColor = System.Drawing.Color.SkyBlue;
            this.lbl_gameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_gameOver.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_gameOver.Location = new System.Drawing.Point(283, 112);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(481, 57);
            this.lbl_gameOver.TabIndex = 3;
            this.lbl_gameOver.Text = "-G-A-M-E--O-V-E-R-";
            this.lbl_gameOver.Visible = false;
            // 
            // infos
            // 
            this.infos.AutoSize = true;
            this.infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infos.Location = new System.Drawing.Point(494, 148);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(0, 32);
            this.infos.TabIndex = 4;
            // 
            // pictureBox_win
            // 
            this.pictureBox_win.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_win.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_win.BackgroundImage")));
            this.pictureBox_win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_win.ErrorImage = null;
            this.pictureBox_win.Location = new System.Drawing.Point(198, 197);
            this.pictureBox_win.Name = "pictureBox_win";
            this.pictureBox_win.Size = new System.Drawing.Size(212, 215);
            this.pictureBox_win.TabIndex = 6;
            this.pictureBox_win.TabStop = false;
            this.pictureBox_win.Visible = false;
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimer.Location = new System.Drawing.Point(24, 28);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(256, 36);
            this.txtTimer.TabIndex = 7;
            this.txtTimer.Text = "Time : 0 sec";
            this.txtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTimer.Visible = false;
            // 
            // timerBarriera
            // 
            this.timerBarriera.Enabled = true;
            this.timerBarriera.Interval = 700;
            this.timerBarriera.Tick += new System.EventHandler(this.timerBarriera_Tick);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(320, 16);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 69);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // goHomeButton
            // 
            this.goHomeButton.BackColor = System.Drawing.Color.MistyRose;
            this.goHomeButton.Enabled = false;
            this.goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHomeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goHomeButton.Location = new System.Drawing.Point(522, 16);
            this.goHomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.goHomeButton.Name = "goHomeButton";
            this.goHomeButton.Size = new System.Drawing.Size(197, 69);
            this.goHomeButton.TabIndex = 11;
            this.goHomeButton.Text = "GO HOME";
            this.goHomeButton.UseVisualStyleBackColor = false;
            this.goHomeButton.Click += new System.EventHandler(this.goHomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // lbl_winner
            // 
            this.lbl_winner.BackColor = System.Drawing.Color.SkyBlue;
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_winner.Location = new System.Drawing.Point(417, 202);
            this.lbl_winner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(339, 210);
            this.lbl_winner.TabIndex = 13;
            this.lbl_winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_winner.Visible = false;
            this.lbl_winner.Click += new System.EventHandler(this.lbl_winner_Click);
            // 
            // timerGoHome
            // 
            this.timerGoHome.Interval = 2000;
            this.timerGoHome.Tick += new System.EventHandler(this.timerGoHome_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.ozz;
            this.ClientSize = new System.Drawing.Size(1155, 575);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goHomeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.infos);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.pictureBox_win);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1173, 622);
            this.MinimumSize = new System.Drawing.Size(1173, 622);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNAKE GAME";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.Label infos;
        private System.Windows.Forms.PictureBox pictureBox_win;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Timer timerBarriera;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button goHomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Timer timerGoHome;
    }
}

