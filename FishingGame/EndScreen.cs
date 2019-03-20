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
    public partial class EndScreen : UserControl
    {
        //Global values

        public EndScreen()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.increments = 4;
            Form1.rodHSpeed = 8;
            Form1.rodVSpeed = 6;
            Form1.rodColor = Color.DarkRed;

            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            StartScreen screen1 = new StartScreen();
            f.Controls.Add(screen1);
            screen1.Focus();

            screen1.Location = new Point((f.Width - screen1.Width) / 2, (f.Height - screen1.Height) / 2);
        }
    }
    
    
}


