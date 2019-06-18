using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1ILDGen
{
    public partial class frmSplash : Form
    {
        #region FIELDS

        Timer timer = new Timer();
        bool fadeIn = true;
        bool fadeOut = true;

        #endregion


        public frmSplash()
        {
            InitializeComponent();

            ExtraFormSettings();
            SetAndStartTimer();
        }

        private void SetAndStartTimer()
        {
            timer.Interval = 10;
            timer.Tick += new EventHandler(t_Tick);
            timer.Start();
        }

        private void ExtraFormSettings()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.7;
            //this.BackgroundImage = Properties.;
        }

        #region EVENTS

        void t_Tick(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.01;
                }
                else
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
            else if (fadeOut)
            {
                if (this.Opacity > 0.7)
                {
                    this.Opacity -= 0.01;
                }
                else
                {
                    fadeOut = false;
                }
            }

            if (!(fadeIn || fadeOut))
            {
                timer.Stop();
                this.Close();
            }
        }

        #endregion
    }
}
