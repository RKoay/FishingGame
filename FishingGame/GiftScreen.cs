using System;
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
    public partial class GiftScreen : UserControl
    {
        SoundPlayer click = new SoundPlayer(Properties.Resources.click);
        public GiftScreen()
        {
            InitializeComponent();
        }

        private void choiceOne_Click(object sender, EventArgs e)
        {
            click.Play();
            //Going to Game Screen
            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            UpSpeed screen4 = new UpSpeed();
            f.Controls.Add(screen4);
            screen4.Focus();

            screen4.Location = new Point((f.Width - screen4.Width) / 2, (f.Height - screen4.Height) / 2);
        }

        private void choiceTwo_Click(object sender, EventArgs e)
        {
            click.Play();
            //Going to Game Screen
            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            AppearanceChange screen5 = new AppearanceChange();
            f.Controls.Add(screen5);
            screen5.Focus();

            screen5.Location = new Point((f.Width - screen5.Width) / 2, (f.Height - screen5.Height) / 2);
        }
    }
}
