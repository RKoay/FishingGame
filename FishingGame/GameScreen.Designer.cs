namespace FishingGame
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.fishNumber = new System.Windows.Forms.Label();
            this.fishScore = new System.Windows.Forms.Label();
            this.paddleCount = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.giftScreen = new System.Windows.Forms.Button();
            this.endScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 20;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // fishNumber
            // 
            this.fishNumber.AutoSize = true;
            this.fishNumber.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishNumber.Location = new System.Drawing.Point(907, 26);
            this.fishNumber.Name = "fishNumber";
            this.fishNumber.Size = new System.Drawing.Size(276, 88);
            this.fishNumber.TabIndex = 0;
            this.fishNumber.Text = "Amount of Fish ";
            // 
            // fishScore
            // 
            this.fishScore.AutoSize = true;
            this.fishScore.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishScore.Location = new System.Drawing.Point(1189, 26);
            this.fishScore.Name = "fishScore";
            this.fishScore.Size = new System.Drawing.Size(248, 88);
            this.fishScore.TabIndex = 1;
            this.fishScore.Text = "Fish Captured";
            // 
            // paddleCount
            // 
            this.paddleCount.AutoSize = true;
            this.paddleCount.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddleCount.Location = new System.Drawing.Point(625, 26);
            this.paddleCount.Name = "paddleCount";
            this.paddleCount.Size = new System.Drawing.Size(250, 88);
            this.paddleCount.TabIndex = 2;
            this.paddleCount.Text = "Hit by Paddles";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(17, 861);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(204, 88);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total Score:";
            // 
            // giftScreen
            // 
            this.giftScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.giftScreen.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giftScreen.Location = new System.Drawing.Point(0, -3);
            this.giftScreen.Name = "giftScreen";
            this.giftScreen.Size = new System.Drawing.Size(1440, 965);
            this.giftScreen.TabIndex = 4;
            this.giftScreen.Text = "Click to go to Gift Screen";
            this.giftScreen.UseVisualStyleBackColor = false;
            this.giftScreen.Visible = false;
            this.giftScreen.Click += new System.EventHandler(this.giftScreen_Click);
            // 
            // endScreen
            // 
            this.endScreen.BackColor = System.Drawing.Color.Black;
            this.endScreen.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endScreen.Location = new System.Drawing.Point(0, -1);
            this.endScreen.Name = "endScreen";
            this.endScreen.Size = new System.Drawing.Size(1440, 965);
            this.endScreen.TabIndex = 5;
            this.endScreen.Text = "Click to go to End Screen";
            this.endScreen.UseVisualStyleBackColor = false;
            this.endScreen.Visible = false;
            this.endScreen.Click += new System.EventHandler(this.endScreen_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.endScreen);
            this.Controls.Add(this.giftScreen);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.paddleCount);
            this.Controls.Add(this.fishScore);
            this.Controls.Add(this.fishNumber);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1440, 962);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Label fishNumber;
        private System.Windows.Forms.Label fishScore;
        private System.Windows.Forms.Label paddleCount;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button giftScreen;
        private System.Windows.Forms.Button endScreen;
    }
}
