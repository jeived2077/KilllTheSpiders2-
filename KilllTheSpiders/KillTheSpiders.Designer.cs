namespace KilllTheSpiders
{
    partial class KillTheSpiders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KillTheSpiders));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.ScoreNumber = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.spider4 = new System.Windows.Forms.PictureBox();
            this.spider3 = new System.Windows.Forms.PictureBox();
            this.spider2 = new System.Windows.Forms.PictureBox();
            this.spider1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(25, 20);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(58, 21);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score:";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer.Location = new System.Drawing.Point(904, 9);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(28, 21);
            this.Timer.TabIndex = 1;
            this.Timer.Text = "60";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // ScoreNumber
            // 
            this.ScoreNumber.AutoSize = true;
            this.ScoreNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreNumber.Location = new System.Drawing.Point(89, 20);
            this.ScoreNumber.Name = "ScoreNumber";
            this.ScoreNumber.Size = new System.Drawing.Size(19, 21);
            this.ScoreNumber.TabIndex = 2;
            this.ScoreNumber.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(629, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Время прохождения в секундах:";
            // 
            // spider4
            // 
            this.spider4.Image = ((System.Drawing.Image)(resources.GetObject("spider4.Image")));
            this.spider4.Location = new System.Drawing.Point(492, 219);
            this.spider4.Name = "spider4";
            this.spider4.Size = new System.Drawing.Size(32, 32);
            this.spider4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spider4.TabIndex = 7;
            this.spider4.TabStop = false;
            this.spider4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // spider3
            // 
            this.spider3.Image = ((System.Drawing.Image)(resources.GetObject("spider3.Image")));
            this.spider3.Location = new System.Drawing.Point(444, 83);
            this.spider3.Name = "spider3";
            this.spider3.Size = new System.Drawing.Size(32, 32);
            this.spider3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spider3.TabIndex = 6;
            this.spider3.TabStop = false;
            this.spider3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // spider2
            // 
            this.spider2.Image = ((System.Drawing.Image)(resources.GetObject("spider2.Image")));
            this.spider2.Location = new System.Drawing.Point(350, 177);
            this.spider2.Name = "spider2";
            this.spider2.Size = new System.Drawing.Size(32, 32);
            this.spider2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spider2.TabIndex = 5;
            this.spider2.TabStop = false;
            this.spider2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // spider1
            // 
            this.spider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spider1.Image = ((System.Drawing.Image)(resources.GetObject("spider1.Image")));
            this.spider1.Location = new System.Drawing.Point(229, 153);
            this.spider1.Name = "spider1";
            this.spider1.Size = new System.Drawing.Size(32, 32);
            this.spider1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spider1.TabIndex = 4;
            this.spider1.TabStop = false;
            this.spider1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KillTheSpiders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(944, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spider4);
            this.Controls.Add(this.spider3);
            this.Controls.Add(this.spider2);
            this.Controls.Add(this.spider1);
            this.Controls.Add(this.ScoreNumber);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KillTheSpiders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIll the spiders!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KillTheSpiders_FormClosed);
            this.Load += new System.EventHandler(this.KillTheSpiders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label ScoreNumber;
        private System.Windows.Forms.PictureBox spider1;
        private System.Windows.Forms.PictureBox spider2;
        private System.Windows.Forms.PictureBox spider3;
        private System.Windows.Forms.PictureBox spider4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}