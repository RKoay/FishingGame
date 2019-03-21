﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FishingGame
{
    public partial class AppearanceChange : UserControl
    {
        SoundPlayer click = new SoundPlayer(Properties.Resources.click); 
        public AppearanceChange()
        {
            InitializeComponent();
        }

        private void clickerOne_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.rodColor = Color.Pink;

            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            GameScreen screen2 = new GameScreen();
            f.Controls.Add(screen2);
            screen2.Focus();

            screen2.Location = new Point((f.Width - screen2.Width) / 2, (f.Height - screen2.Height) / 2);
        }

        private void ClickerTwo_Click(object sender, EventArgs e)
        {
            click.Play();
            Form1.rodColor = Color.Blue;

            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            GameScreen screen2 = new GameScreen();
            f.Controls.Add(screen2);
            screen2.Focus();

            screen2.Location = new Point((f.Width - screen2.Width) / 2, (f.Height - screen2.Height) / 2);
        }
    }
}
