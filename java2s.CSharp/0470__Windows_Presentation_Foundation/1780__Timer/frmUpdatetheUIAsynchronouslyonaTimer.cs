using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1780__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UpdatetheUIAsynchronouslyonaTimer.htm
    public partial  class frmUpdatetheUIAsynchronouslyonaTimer:Form
    {
        public frmUpdatetheUIAsynchronouslyonaTimer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatetheUIAsynchronouslyonaTimer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatetheUIAsynchronouslyonaTimer";
            this.Text = "frmUpdatetheUIAsynchronouslyonaTimer";
            this.Load += new System.EventHandler(this.frmUpdatetheUIAsynchronouslyonaTimer_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatetheUIAsynchronouslyonaTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
