namespace FishingGame
{
    partial class EndScreen
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
            this.decoLabel = new System.Windows.Forms.Label();
            this.gift = new System.Windows.Forms.Label();
            this.clicker = new System.Windows.Forms.Button();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decoLabel
            // 
            this.decoLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.decoLabel.Location = new System.Drawing.Point(3, 57);
            this.decoLabel.Name = "decoLabel";
            this.decoLabel.Size = new System.Drawing.Size(1434, 235);
            this.decoLabel.TabIndex = 2;
            // 
            // gift
            // 
            this.gift.BackColor = System.Drawing.Color.Tan;
            this.gift.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gift.Location = new System.Drawing.Point(423, 96);
            this.gift.Name = "gift";
            this.gift.Size = new System.Drawing.Size(650, 162);
            this.gift.TabIndex = 3;
            this.gift.Text = "End Screen";
            // 
            // clicker
            // 
            this.clicker.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.clicker.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.clicker.Location = new System.Drawing.Point(309, 402);
            this.clicker.Name = "clicker";
            this.clicker.Size = new System.Drawing.Size(869, 257);
            this.clicker.TabIndex = 4;
            this.clicker.Text = "If you are here, then it means one of two things. You either have failed the game" +
    " with a score less than zero or you have chosen to exit the current game.\r\n\r\n\r\n\r" +
    "\n";
            this.clicker.UseVisualStyleBackColor = false;
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 766);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 128);
            this.button1.TabIndex = 5;
            this.button1.Text = "Press to End Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(880, 766);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 128);
            this.button2.TabIndex = 6;
            this.button2.Text = "Press to Restart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clicker);
            this.Controls.Add(this.gift);
            this.Controls.Add(this.decoLabel);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1440, 965);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label decoLabel;
        private System.Windows.Forms.Label gift;
        private System.Windows.Forms.Button clicker;
        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
