namespace FishingGame
{
    partial class AppearanceChange
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
            this.decoLabel = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.clickerOne = new System.Windows.Forms.Button();
            this.ClickerTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decoLabel
            // 
            this.decoLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.decoLabel.Location = new System.Drawing.Point(0, 45);
            this.decoLabel.Name = "decoLabel";
            this.decoLabel.Size = new System.Drawing.Size(1440, 302);
            this.decoLabel.TabIndex = 3;
            // 
            // introLabel
            // 
            this.introLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.introLabel.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(230, 106);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(945, 179);
            this.introLabel.TabIndex = 4;
            this.introLabel.Text = "Changing the Rod";
            // 
            // clickerOne
            // 
            this.clickerOne.BackColor = System.Drawing.Color.DarkSalmon;
            this.clickerOne.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickerOne.Location = new System.Drawing.Point(48, 460);
            this.clickerOne.Name = "clickerOne";
            this.clickerOne.Size = new System.Drawing.Size(624, 392);
            this.clickerOne.TabIndex = 5;
            this.clickerOne.Text = "Click This To Play With The Pink Rod\r\n\r\n\r\n\r\n\r\n";
            this.clickerOne.UseVisualStyleBackColor = false;
            this.clickerOne.Click += new System.EventHandler(this.clickerOne_Click);
            // 
            // ClickerTwo
            // 
            this.ClickerTwo.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClickerTwo.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickerTwo.Location = new System.Drawing.Point(763, 460);
            this.ClickerTwo.Name = "ClickerTwo";
            this.ClickerTwo.Size = new System.Drawing.Size(624, 392);
            this.ClickerTwo.TabIndex = 6;
            this.ClickerTwo.Text = "Click This To Play With The Blue Rod\r\n\r\n\r\n\r\n\r\n";
            this.ClickerTwo.UseVisualStyleBackColor = false;
            this.ClickerTwo.Click += new System.EventHandler(this.ClickerTwo_Click);
            // 
            // AppearanceChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.ClickerTwo);
            this.Controls.Add(this.clickerOne);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.decoLabel);
            this.Name = "AppearanceChange";
            this.Size = new System.Drawing.Size(1440, 962);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label decoLabel;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button clickerOne;
        private System.Windows.Forms.Button ClickerTwo;
    }
}
