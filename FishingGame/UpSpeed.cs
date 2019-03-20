using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingGame
{
    public partial class UpSpeed : UserControl
    {
        public UpSpeed()
        {
            InitializeComponent();
        }

        private void clicker_Click(object sender, EventArgs e)
        {
            Form1.rodHSpeed = Form1.rodHSpeed + Form1.increments;
            Form1.rodVSpeed = Form1.rodVSpeed + Form1.increments;

            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            GameScreen screen2 = new GameScreen();
            f.Controls.Add(screen2);
            screen2.Focus();

            screen2.Location = new Point((f.Width - screen2.Width) / 2, (f.Height - screen2.Height) / 2);
        }
    }
}
