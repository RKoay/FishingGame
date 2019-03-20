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
        Boolean spaceDown, escDown;
        public EndScreen()
        {
            InitializeComponent();

            if (spaceDown == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(value: this);
                StartScreen screen1 = new StartScreen();
                f.Controls.Add(screen1);
                screen1.Focus();

                screen1.Location = new Point((f.Width - screen1.Width) / 2, (f.Height - screen1.Height) / 2);
            }
            
        }

        private void EndScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    Application.Exit();
                    break;
            }
        }
        

        private void EndScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }


    }
}
