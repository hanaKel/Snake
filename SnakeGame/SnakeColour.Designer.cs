
namespace SnakeGame
{
    partial class SnakeColor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblColorSnake = new System.Windows.Forms.Label();
            this.playButten = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.goldSnake = new System.Windows.Forms.Label();
            this.redSnake = new System.Windows.Forms.Label();
            this.royalBlueSnake = new System.Windows.Forms.Label();
            this.whiteSnake = new System.Windows.Forms.Label();
            this.paleGreenSnake = new System.Windows.Forms.Label();
            this.grenYellow = new System.Windows.Forms.Label();
            this.pinkSnake = new System.Windows.Forms.Label();
            this.purpleSnake = new System.Windows.Forms.Label();
            this.AquamarineSnake = new System.Windows.Forms.Label();
            this.moccasinSnake = new System.Windows.Forms.Label();
            this.oliveSnake = new System.Windows.Forms.Label();
            this.salmonSnake = new System.Windows.Forms.Label();
            this.goodJob = new System.Windows.Forms.Label();
            this.letsPlay = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letsPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SnakeGame.Properties.Resources.coloring;
            this.pictureBox1.Location = new System.Drawing.Point(131, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblColorSnake
            // 
            this.lblColorSnake.BackColor = System.Drawing.Color.SkyBlue;
            this.lblColorSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSnake.Location = new System.Drawing.Point(264, 37);
            this.lblColorSnake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorSnake.Name = "lblColorSnake";
            this.lblColorSnake.Size = new System.Drawing.Size(632, 31);
            this.lblColorSnake.TabIndex = 2;
            this.lblColorSnake.Text = "choose color ";
            this.lblColorSnake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButten
            // 
            this.playButten.BackColor = System.Drawing.Color.SkyBlue;
            this.playButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButten.Location = new System.Drawing.Point(341, 449);
            this.playButten.Margin = new System.Windows.Forms.Padding(4);
            this.playButten.Name = "playButten";
            this.playButten.Size = new System.Drawing.Size(152, 69);
            this.playButten.TabIndex = 5;
            this.playButten.Text = "PLAY";
            this.playButten.UseVisualStyleBackColor = true;
            this.playButten.Click += new System.EventHandler(this.playButten_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.SkyBlue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(744, 449);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(152, 69);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goldSnake
            // 
            this.goldSnake.BackColor = System.Drawing.Color.Gold;
            this.goldSnake.Location = new System.Drawing.Point(456, 164);
            this.goldSnake.Margin = new System.Windows.Forms.Padding(4);
            this.goldSnake.Name = "goldSnake";
            this.goldSnake.Size = new System.Drawing.Size(152, 69);
            this.goldSnake.TabIndex = 7;
            this.goldSnake.Click += new System.EventHandler(this.label1_Click);
            // 
            // redSnake
            // 
            this.redSnake.BackColor = System.Drawing.Color.Red;
            this.redSnake.Location = new System.Drawing.Point(456, 318);
            this.redSnake.Margin = new System.Windows.Forms.Padding(4);
            this.redSnake.Name = "redSnake";
            this.redSnake.Size = new System.Drawing.Size(152, 69);
            this.redSnake.TabIndex = 8;
            this.redSnake.Click += new System.EventHandler(this.redSnake_Click);
            // 
            // royalBlueSnake
            // 
            this.royalBlueSnake.BackColor = System.Drawing.Color.RoyalBlue;
            this.royalBlueSnake.Location = new System.Drawing.Point(456, 241);
            this.royalBlueSnake.Margin = new System.Windows.Forms.Padding(4);
            this.royalBlueSnake.Name = "royalBlueSnake";
            this.royalBlueSnake.Size = new System.Drawing.Size(152, 69);
            this.royalBlueSnake.TabIndex = 9;
            this.royalBlueSnake.Click += new System.EventHandler(this.royalBlueSnake_Click);
            // 
            // whiteSnake
            // 
            this.whiteSnake.BackColor = System.Drawing.Color.White;
            this.whiteSnake.Location = new System.Drawing.Point(607, 164);
            this.whiteSnake.Margin = new System.Windows.Forms.Padding(4);
            this.whiteSnake.Name = "whiteSnake";
            this.whiteSnake.Size = new System.Drawing.Size(152, 69);
            this.whiteSnake.TabIndex = 10;
            this.whiteSnake.Click += new System.EventHandler(this.whiteSnake_Click);
            // 
            // paleGreenSnake
            // 
            this.paleGreenSnake.BackColor = System.Drawing.Color.PaleGreen;
            this.paleGreenSnake.Location = new System.Drawing.Point(607, 241);
            this.paleGreenSnake.Margin = new System.Windows.Forms.Padding(4);
            this.paleGreenSnake.Name = "paleGreenSnake";
            this.paleGreenSnake.Size = new System.Drawing.Size(152, 69);
            this.paleGreenSnake.TabIndex = 11;
            this.paleGreenSnake.Click += new System.EventHandler(this.paleGreenSnake_Click);
            // 
            // grenYellow
            // 
            this.grenYellow.BackColor = System.Drawing.Color.GreenYellow;
            this.grenYellow.Location = new System.Drawing.Point(758, 164);
            this.grenYellow.Margin = new System.Windows.Forms.Padding(4);
            this.grenYellow.Name = "grenYellow";
            this.grenYellow.Size = new System.Drawing.Size(152, 69);
            this.grenYellow.TabIndex = 12;
            this.grenYellow.Click += new System.EventHandler(this.grenYellow_Click);
            // 
            // pinkSnake
            // 
            this.pinkSnake.BackColor = System.Drawing.Color.Pink;
            this.pinkSnake.Location = new System.Drawing.Point(758, 241);
            this.pinkSnake.Margin = new System.Windows.Forms.Padding(4);
            this.pinkSnake.Name = "pinkSnake";
            this.pinkSnake.Size = new System.Drawing.Size(152, 69);
            this.pinkSnake.TabIndex = 13;
            this.pinkSnake.Click += new System.EventHandler(this.pinkSnake_Click);
            // 
            // purpleSnake
            // 
            this.purpleSnake.BackColor = System.Drawing.Color.Purple;
            this.purpleSnake.Location = new System.Drawing.Point(908, 241);
            this.purpleSnake.Margin = new System.Windows.Forms.Padding(4);
            this.purpleSnake.Name = "purpleSnake";
            this.purpleSnake.Size = new System.Drawing.Size(152, 69);
            this.purpleSnake.TabIndex = 14;
            this.purpleSnake.Click += new System.EventHandler(this.purpleSnake_Click);
            // 
            // AquamarineSnake
            // 
            this.AquamarineSnake.BackColor = System.Drawing.Color.Aquamarine;
            this.AquamarineSnake.Location = new System.Drawing.Point(908, 164);
            this.AquamarineSnake.Margin = new System.Windows.Forms.Padding(4);
            this.AquamarineSnake.Name = "AquamarineSnake";
            this.AquamarineSnake.Size = new System.Drawing.Size(152, 69);
            this.AquamarineSnake.TabIndex = 15;
            this.AquamarineSnake.Click += new System.EventHandler(this.AquamarineSnake_Click);
            // 
            // moccasinSnake
            // 
            this.moccasinSnake.BackColor = System.Drawing.Color.Moccasin;
            this.moccasinSnake.Location = new System.Drawing.Point(607, 318);
            this.moccasinSnake.Margin = new System.Windows.Forms.Padding(4);
            this.moccasinSnake.Name = "moccasinSnake";
            this.moccasinSnake.Size = new System.Drawing.Size(152, 69);
            this.moccasinSnake.TabIndex = 16;
            this.moccasinSnake.Click += new System.EventHandler(this.moccasinSnake_Click);
            // 
            // oliveSnake
            // 
            this.oliveSnake.BackColor = System.Drawing.Color.Olive;
            this.oliveSnake.Location = new System.Drawing.Point(758, 318);
            this.oliveSnake.Margin = new System.Windows.Forms.Padding(4);
            this.oliveSnake.Name = "oliveSnake";
            this.oliveSnake.Size = new System.Drawing.Size(152, 69);
            this.oliveSnake.TabIndex = 17;
            this.oliveSnake.Click += new System.EventHandler(this.oliveSnake_Click);
            // 
            // salmonSnake
            // 
            this.salmonSnake.BackColor = System.Drawing.Color.Salmon;
            this.salmonSnake.Location = new System.Drawing.Point(908, 318);
            this.salmonSnake.Margin = new System.Windows.Forms.Padding(4);
            this.salmonSnake.Name = "salmonSnake";
            this.salmonSnake.Size = new System.Drawing.Size(152, 69);
            this.salmonSnake.TabIndex = 18;
            this.salmonSnake.Click += new System.EventHandler(this.salmonSnake_Click);
            // 
            // goodJob
            // 
            this.goodJob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.goodJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goodJob.Location = new System.Drawing.Point(544, 211);
            this.goodJob.Name = "goodJob";
            this.goodJob.Size = new System.Drawing.Size(448, 116);
            this.goodJob.TabIndex = 19;
            this.goodJob.Text = "good job\r\nyou chose color of the snake";
            this.goodJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goodJob.Visible = false;
            // 
            // letsPlay
            // 
            this.letsPlay.BackColor = System.Drawing.Color.Transparent;
            this.letsPlay.Image = global::SnakeGame.Properties.Resources.letsPlayGame;
            this.letsPlay.Location = new System.Drawing.Point(122, 131);
            this.letsPlay.Name = "letsPlay";
            this.letsPlay.Size = new System.Drawing.Size(964, 289);
            this.letsPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.letsPlay.TabIndex = 20;
            this.letsPlay.TabStop = false;
            this.letsPlay.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 700;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SnakeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.ozadje;
            this.ClientSize = new System.Drawing.Size(1155, 575);
            this.Controls.Add(this.letsPlay);
            this.Controls.Add(this.goodJob);
            this.Controls.Add(this.salmonSnake);
            this.Controls.Add(this.oliveSnake);
            this.Controls.Add(this.moccasinSnake);
            this.Controls.Add(this.AquamarineSnake);
            this.Controls.Add(this.purpleSnake);
            this.Controls.Add(this.pinkSnake);
            this.Controls.Add(this.grenYellow);
            this.Controls.Add(this.paleGreenSnake);
            this.Controls.Add(this.whiteSnake);
            this.Controls.Add(this.royalBlueSnake);
            this.Controls.Add(this.redSnake);
            this.Controls.Add(this.goldSnake);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playButten);
            this.Controls.Add(this.lblColorSnake);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1173, 622);
            this.MinimumSize = new System.Drawing.Size(1173, 622);
            this.Name = "SnakeColor";
            this.Text = "SNAKE COLOR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letsPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblColorSnake;
        private System.Windows.Forms.Button playButten;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label goldSnake;
        private System.Windows.Forms.Label redSnake;
        private System.Windows.Forms.Label royalBlueSnake;
        private System.Windows.Forms.Label whiteSnake;
        private System.Windows.Forms.Label paleGreenSnake;
        private System.Windows.Forms.Label grenYellow;
        private System.Windows.Forms.Label pinkSnake;
        private System.Windows.Forms.Label purpleSnake;
        private System.Windows.Forms.Label AquamarineSnake;
        private System.Windows.Forms.Label moccasinSnake;
        private System.Windows.Forms.Label oliveSnake;
        private System.Windows.Forms.Label salmonSnake;
        private System.Windows.Forms.Label goodJob;
        private System.Windows.Forms.PictureBox letsPlay;
        private System.Windows.Forms.Timer timer;
    }
}