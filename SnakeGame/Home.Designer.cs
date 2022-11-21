
namespace SnakeGame
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playSnakeGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSnakeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snakeColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playSnakeGameToolStripMenuItem1,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(230, 233);
            this.menuStrip1.MdiWindowListItem = this.menuToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(494, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playSnakeGameToolStripMenuItem1
            // 
            this.playSnakeGameToolStripMenuItem1.BackColor = System.Drawing.Color.SkyBlue;
            this.playSnakeGameToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playSnakeGameToolStripMenuItem1.Name = "playSnakeGameToolStripMenuItem1";
            this.playSnakeGameToolStripMenuItem1.Size = new System.Drawing.Size(260, 84);
            this.playSnakeGameToolStripMenuItem1.Text = "Play Snake Game";
            this.playSnakeGameToolStripMenuItem1.Click += new System.EventHandler(this.playSnakeGameToolStripMenuItem1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoSize = false;
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playSnakeGameToolStripMenuItem,
            this.snakeColourToolStripMenuItem,
            this.howTToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(152, 65);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // playSnakeGameToolStripMenuItem
            // 
            this.playSnakeGameToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.playSnakeGameToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playSnakeGameToolStripMenuItem.Name = "playSnakeGameToolStripMenuItem";
            this.playSnakeGameToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.playSnakeGameToolStripMenuItem.Text = "How to play";
            this.playSnakeGameToolStripMenuItem.Click += new System.EventHandler(this.playSnakeGameToolStripMenuItem_Click);
            // 
            // snakeColourToolStripMenuItem
            // 
            this.snakeColourToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.snakeColourToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeColourToolStripMenuItem.Name = "snakeColourToolStripMenuItem";
            this.snakeColourToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.snakeColourToolStripMenuItem.Text = "Snake Colour";
            this.snakeColourToolStripMenuItem.Click += new System.EventHandler(this.snakeColourToolStripMenuItem_Click);
            // 
            // howTToolStripMenuItem
            // 
            this.howTToolStripMenuItem.AutoToolTip = true;
            this.howTToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.howTToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howTToolStripMenuItem.Name = "howTToolStripMenuItem";
            this.howTToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.howTToolStripMenuItem.Text = "How to win";
            this.howTToolStripMenuItem.Click += new System.EventHandler(this.howTToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 220);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1155, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1173, 622);
            this.MinimumSize = new System.Drawing.Size(1173, 622);
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSnakeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snakeColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSnakeGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem howTToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}