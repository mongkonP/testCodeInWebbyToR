using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0140__Stopwatch
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/UseStopwatchstartstopandreset.htm
    public partial  class frmUseStopwatchstartstopandreset:Form
    {
        public frmUseStopwatchstartstopandreset()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseStopwatchstartstopandreset
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseStopwatchstartstopandreset";
            this.Text = "frmUseStopwatchstartstopandreset";
            this.Load += new System.EventHandler(this.frmUseStopwatchstartstopandreset_Load);
            this.ResumeLayout(false);

        }

        private void frmUseStopwatchstartstopandreset_Load(object sender, EventArgs e)
        {

        }
    }
}
