using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UsingSystemTimersTimer.htm
    public partial  class frmUsingSystemTimersTimer:Form
    {
        public frmUsingSystemTimersTimer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingSystemTimersTimer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingSystemTimersTimer";
            this.Text = "frmUsingSystemTimersTimer";
            this.Load += new System.EventHandler(this.frmUsingSystemTimersTimer_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingSystemTimersTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
