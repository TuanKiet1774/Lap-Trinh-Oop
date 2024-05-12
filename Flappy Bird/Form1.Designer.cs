namespace Flappy_Bird
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
            this.ScoreText = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Khaki;
            this.ScoreText.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(25, 563);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(88, 26);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-4, 494);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(798, 163);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.PipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(321, 352);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(100, 256);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 2;
            this.PipeBottom.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.FlappyBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(30, 226);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(90, 61);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(237, -107);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(87, 224);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.sky;
            this.ClientSize = new System.Drawing.Size(495, 630);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.PipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

