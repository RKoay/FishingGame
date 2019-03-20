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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.decoLabel = new System.Windows.Forms.Label();
            this.gift = new System.Windows.Forms.Label();
            this.clicker = new System.Windows.Forms.Button();
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
            this.clicker.Location = new System.Drawing.Point(298, 409);
            this.clicker.Name = "clicker";
            this.clicker.Size = new System.Drawing.Size(869, 338);
            this.clicker.TabIndex = 4;
            this.clicker.Text = resources.GetString("clicker.Text");
            this.clicker.UseVisualStyleBackColor = false;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.clicker);
            this.Controls.Add(this.gift);
            this.Controls.Add(this.decoLabel);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1440, 965);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EndScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label decoLabel;
        private System.Windows.Forms.Label gift;
        private System.Windows.Forms.Button clicker;
    }
}
