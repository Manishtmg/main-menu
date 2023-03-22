
namespace FlappyBirdGame
{
    partial class flappyBirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flappyBirdForm));
            this.scoreCounter = new System.Windows.Forms.Label();
            this.dragon = new System.Windows.Forms.PictureBox();
            this.tubeUp = new System.Windows.Forms.PictureBox();
            this.tubeDown = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.floor = new System.Windows.Forms.PictureBox();
            this.gameOverMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.howToPlay = new System.Windows.Forms.Label();
            this.soundButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.BackColor = System.Drawing.Color.Black;
            this.scoreCounter.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCounter.ForeColor = System.Drawing.Color.Transparent;
            this.scoreCounter.Location = new System.Drawing.Point(12, 536);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(66, 22);
            this.scoreCounter.TabIndex = 4;
            this.scoreCounter.Text = "Score: 0";
            // 
            // dragon
            // 
            this.dragon.BackColor = System.Drawing.Color.Transparent;
            this.dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dragon.Image = ((System.Drawing.Image)(resources.GetObject("dragon.Image")));
            this.dragon.Location = new System.Drawing.Point(42, 237);
            this.dragon.Name = "dragon";
            this.dragon.Size = new System.Drawing.Size(74, 61);
            this.dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragon.TabIndex = 3;
            this.dragon.TabStop = false;
            // 
            // tubeUp
            // 
            this.tubeUp.BackColor = System.Drawing.Color.Transparent;
            this.tubeUp.Image = ((System.Drawing.Image)(resources.GetObject("tubeUp.Image")));
            this.tubeUp.Location = new System.Drawing.Point(360, 374);
            this.tubeUp.Name = "tubeUp";
            this.tubeUp.Size = new System.Drawing.Size(86, 204);
            this.tubeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tubeUp.TabIndex = 1;
            this.tubeUp.TabStop = false;
            // 
            // tubeDown
            // 
            this.tubeDown.BackColor = System.Drawing.Color.Transparent;
            this.tubeDown.Image = ((System.Drawing.Image)(resources.GetObject("tubeDown.Image")));
            this.tubeDown.Location = new System.Drawing.Point(413, -38);
            this.tubeDown.Name = "tubeDown";
            this.tubeDown.Size = new System.Drawing.Size(82, 255);
            this.tubeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tubeDown.TabIndex = 0;
            this.tubeDown.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(452, 532);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(73, 30);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Restart";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // floor
            // 
            this.floor.Enabled = false;
            this.floor.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.floor.Location = new System.Drawing.Point(-34, 508);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(705, 79);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 6;
            this.floor.TabStop = false;
            // 
            // gameOverMessage
            // 
            this.gameOverMessage.AutoSize = true;
            this.gameOverMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverMessage.Location = new System.Drawing.Point(176, 259);
            this.gameOverMessage.Name = "gameOverMessage";
            this.gameOverMessage.Size = new System.Drawing.Size(0, 39);
            this.gameOverMessage.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(290, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(122, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(143, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(450, 259);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(373, 532);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(73, 30);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit Game";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(286, 139);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // howToPlay
            // 
            this.howToPlay.AutoSize = true;
            this.howToPlay.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlay.Location = new System.Drawing.Point(232, 259);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(0, 19);
            this.howToPlay.TabIndex = 15;
            // 
            // soundButton
            // 
            this.soundButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.soundButton.AutoSize = true;
            this.soundButton.BackColor = System.Drawing.Color.White;
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soundButton.Location = new System.Drawing.Point(306, 532);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(61, 28);
            this.soundButton.TabIndex = 16;
            this.soundButton.Text = "Sound";
            this.soundButton.UseVisualStyleBackColor = false;
            this.soundButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flappyBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 565);
            this.Controls.Add(this.soundButton);
            this.Controls.Add(this.gameOverMessage);
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dragon);
            this.Controls.Add(this.scoreCounter);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.tubeDown);
            this.Controls.Add(this.tubeUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "flappyBirdForm";
            this.Text = "FlappyDragon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flappyBirdForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flappyBirdForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tubeDown;
        private System.Windows.Forms.PictureBox tubeUp;
        private System.Windows.Forms.PictureBox dragon;
        private System.Windows.Forms.Label scoreCounter;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Label gameOverMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label howToPlay;
        private System.Windows.Forms.CheckBox soundButton;
    }
}

