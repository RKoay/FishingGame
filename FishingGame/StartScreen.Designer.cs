namespace FishingGame
{
    partial class StartScreen
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
            this.title = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.decolabel1 = new System.Windows.Forms.Label();
            this.decolabel2 = new System.Windows.Forms.Label();
            this.decolabel3 = new System.Windows.Forms.Label();
            this.decolabel4 = new System.Windows.Forms.Label();
            this.intro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Peru;
            this.title.Font = new System.Drawing.Font("Segoe Print", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(201, 191);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1069, 247);
            this.title.TabIndex = 0;
            this.title.Text = "Fisher Delight";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.LightSalmon;
            this.b1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(369, 511);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(716, 219);
            this.b1.TabIndex = 1;
            this.b1.Text = "Click This To Start: Your goal is to achieve score #25";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // decolabel1
            // 
            this.decolabel1.BackColor = System.Drawing.Color.OldLace;
            this.decolabel1.Location = new System.Drawing.Point(1373, 0);
            this.decolabel1.Name = "decolabel1";
            this.decolabel1.Size = new System.Drawing.Size(100, 1064);
            this.decolabel1.TabIndex = 2;
            // 
            // decolabel2
            // 
            this.decolabel2.BackColor = System.Drawing.Color.OldLace;
            this.decolabel2.Location = new System.Drawing.Point(3, 0);
            this.decolabel2.Name = "decolabel2";
            this.decolabel2.Size = new System.Drawing.Size(100, 1064);
            this.decolabel2.TabIndex = 3;
            // 
            // decolabel3
            // 
            this.decolabel3.BackColor = System.Drawing.Color.OldLace;
            this.decolabel3.Location = new System.Drawing.Point(0, 862);
            this.decolabel3.Name = "decolabel3";
            this.decolabel3.Size = new System.Drawing.Size(1437, 100);
            this.decolabel3.TabIndex = 4;
            // 
            // decolabel4
            // 
            this.decolabel4.BackColor = System.Drawing.Color.OldLace;
            this.decolabel4.Location = new System.Drawing.Point(3, 0);
            this.decolabel4.Name = "decolabel4";
            this.decolabel4.Size = new System.Drawing.Size(1437, 100);
            this.decolabel4.TabIndex = 5;
            // 
            // intro
            // 
            this.intro.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro.Location = new System.Drawing.Point(369, 766);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(716, 96);
            this.intro.TabIndex = 6;
            this.intro.Text = "At any point if the user want to exit the game, simply press the Escape button on" +
    " keyboard";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Controls.Add(this.intro);
            this.Controls.Add(this.decolabel4);
            this.Controls.Add(this.decolabel3);
            this.Controls.Add(this.decolabel2);
            this.Controls.Add(this.decolabel1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.title);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(1440, 962);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label decolabel1;
        private System.Windows.Forms.Label decolabel2;
        private System.Windows.Forms.Label decolabel3;
        private System.Windows.Forms.Label decolabel4;
        private System.Windows.Forms.Label intro;
    }
}
