namespace FishingGame
{
    partial class GiftScreen
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
            this.gift = new System.Windows.Forms.Label();
            this.decoLabel = new System.Windows.Forms.Label();
            this.choiceOne = new System.Windows.Forms.Button();
            this.choiceTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gift
            // 
            this.gift.BackColor = System.Drawing.Color.MistyRose;
            this.gift.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gift.Location = new System.Drawing.Point(408, 127);
            this.gift.Name = "gift";
            this.gift.Size = new System.Drawing.Size(622, 162);
            this.gift.TabIndex = 0;
            this.gift.Text = "Gift Screen";
            // 
            // decoLabel
            // 
            this.decoLabel.BackColor = System.Drawing.Color.Lavender;
            this.decoLabel.Location = new System.Drawing.Point(3, 89);
            this.decoLabel.Name = "decoLabel";
            this.decoLabel.Size = new System.Drawing.Size(1434, 235);
            this.decoLabel.TabIndex = 1;
            // 
            // choiceOne
            // 
            this.choiceOne.BackColor = System.Drawing.Color.PaleTurquoise;
            this.choiceOne.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceOne.Location = new System.Drawing.Point(119, 481);
            this.choiceOne.Name = "choiceOne";
            this.choiceOne.Size = new System.Drawing.Size(486, 262);
            this.choiceOne.TabIndex = 2;
            this.choiceOne.Text = " Click For Choice 1: Up Speed ";
            this.choiceOne.UseVisualStyleBackColor = false;
            this.choiceOne.Click += new System.EventHandler(this.choiceOne_Click);
            // 
            // choiceTwo
            // 
            this.choiceTwo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.choiceTwo.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceTwo.Location = new System.Drawing.Point(810, 481);
            this.choiceTwo.Name = "choiceTwo";
            this.choiceTwo.Size = new System.Drawing.Size(486, 262);
            this.choiceTwo.TabIndex = 3;
            this.choiceTwo.Text = "Click For Choice 2: Rod Colours";
            this.choiceTwo.UseVisualStyleBackColor = false;
            this.choiceTwo.Click += new System.EventHandler(this.choiceTwo_Click);
            // 
            // GiftScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.choiceTwo);
            this.Controls.Add(this.choiceOne);
            this.Controls.Add(this.gift);
            this.Controls.Add(this.decoLabel);
            this.Name = "GiftScreen";
            this.Size = new System.Drawing.Size(1440, 962);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gift;
        private System.Windows.Forms.Label decoLabel;
        private System.Windows.Forms.Button choiceOne;
        private System.Windows.Forms.Button choiceTwo;
    }
}
