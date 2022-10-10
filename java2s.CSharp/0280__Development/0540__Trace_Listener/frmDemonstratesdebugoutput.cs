using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0540__Trace_Listener
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Demonstratesdebugoutput.htm
    public partial  class frmDemonstratesdebugoutput:Form
    {
        public frmDemonstratesdebugoutput()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratesdebugoutput
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratesdebugoutput";
            this.Text = "frmDemonstratesdebugoutput";
            this.Load += new System.EventHandler(this.frmDemonstratesdebugoutput_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratesdebugoutput_Load(object sender, EventArgs e)
        {

        }
    }
}
