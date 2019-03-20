namespace FishingGame
{
    partial class UpSpeed
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
            this.introLabel = new System.Windows.Forms.Label();
            this.clicker = new System.Windows.Forms.Button();
            this.decoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.introLabel.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(443, 104);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(536, 179);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Up Speed";
            // 
            // clicker
            // 
            this.clicker.BackColor = System.Drawing.Color.DarkSalmon;
            this.clicker.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicker.Location = new System.Drawing.Point(284, 425);
            this.clicker.Name = "clicker";
            this.clicker.Size = new System.Drawing.Size(869, 392);
            this.clicker.TabIndex = 1;
            this.clicker.Text = "Click This to Play with An Increased Speed ";
            this.clicker.UseVisualStyleBackColor = false;
            this.clicker.Click += new System.EventHandler(this.clicker_Click);
            // 
            // decoLabel
            // 
            this.decoLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.decoLabel.Location = new System.Drawing.Point(0, 48);
            this.decoLabel.Name = "decoLabel";
            this.decoLabel.Size = new System.Drawing.Size(1440, 302);
            this.decoLabel.TabIndex = 2;
            // 
            // UpSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.decoLabel);
            this.Controls.Add(this.clicker);
            this.Name = "UpSpeed";
            this.Size = new System.Drawing.Size(1440, 962);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button clicker;
        private System.Windows.Forms.Label decoLabel;
    }
}
