using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingGame
{
    public partial class Form1 : Form
    {
        public static int increments = 4;
        public static int rodHSpeed = 8;
        public static int rodVSpeed = 6;

        public static Color rodColor = Color.DarkRed;

        public Form1()
        {
            InitializeComponent();
            //Direct to a Start Screen
            StartScreen screen1 = new StartScreen();
            this.Controls.Add(screen1);

            screen1.Location = new Point((this.Width - screen1.Width) / 2, (this.Height - screen1.Height) / 2);
        }
    }
}
