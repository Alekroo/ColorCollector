using System.Windows.Forms;

namespace Racing_Game
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
            this.startBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hpLabel = new System.Windows.Forms.Label();
            this.overLabel = new System.Windows.Forms.Label();
            this.redBox2 = new System.Windows.Forms.PictureBox();
            this.redBox1 = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(209, 405);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 50);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 33;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(237, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Green;
            this.greenBox.Location = new System.Drawing.Point(367, 12);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(30, 30);
            this.greenBox.TabIndex = 2;
            this.greenBox.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(34, 26);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(144, 37);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.AutoSize = true;
            this.backgroundPanel.Controls.Add(this.titleLabel);
            this.backgroundPanel.Controls.Add(this.exitBtn);
            this.backgroundPanel.Controls.Add(this.hpLabel);
            this.backgroundPanel.Controls.Add(this.overLabel);
            this.backgroundPanel.Controls.Add(this.redBox2);
            this.backgroundPanel.Controls.Add(this.scoreLabel);
            this.backgroundPanel.Controls.Add(this.redBox1);
            this.backgroundPanel.Controls.Add(this.startBtn);
            this.backgroundPanel.Controls.Add(this.blueBox);
            this.backgroundPanel.Controls.Add(this.greenBox);
            this.backgroundPanel.Controls.Add(this.pictureBox1);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(582, 555);
            this.backgroundPanel.TabIndex = 4;
            this.backgroundPanel.Click += new System.EventHandler(this.playerClick);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(209, 472);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(150, 50);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(456, 26);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(102, 37);
            this.hpLabel.TabIndex = 7;
            this.hpLabel.Text = "HP: 3";
            this.hpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // overLabel
            // 
            this.overLabel.AutoSize = true;
            this.overLabel.BackColor = System.Drawing.Color.Yellow;
            this.overLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overLabel.Location = new System.Drawing.Point(144, 188);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(272, 55);
            this.overLabel.TabIndex = 6;
            this.overLabel.Text = "Game Over";
            // 
            // redBox2
            // 
            this.redBox2.BackColor = System.Drawing.Color.Red;
            this.redBox2.Location = new System.Drawing.Point(255, 53);
            this.redBox2.Name = "redBox2";
            this.redBox2.Size = new System.Drawing.Size(30, 30);
            this.redBox2.TabIndex = 5;
            this.redBox2.TabStop = false;
            // 
            // redBox1
            // 
            this.redBox1.BackColor = System.Drawing.Color.Red;
            this.redBox1.Location = new System.Drawing.Point(60, 144);
            this.redBox1.Name = "redBox1";
            this.redBox1.Size = new System.Drawing.Size(30, 30);
            this.redBox1.TabIndex = 4;
            this.redBox1.TabStop = false;
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(540, 100);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(30, 30);
            this.blueBox.TabIndex = 3;
            this.blueBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Yellow;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(101, 188);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(350, 50);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Color Collector";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(582, 555);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Color Collector";
            this.Text = "Color Collector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.PictureBox blueBox;
        private PictureBox redBox2;
        private PictureBox redBox1;
        private Label overLabel;
        private Label hpLabel;
        private Button exitBtn;
        private Label titleLabel;
    }
}

