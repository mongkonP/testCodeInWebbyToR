using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/RedirectingProcessOutput.htm
    public partial  class frmRedirectingProcessOutput:Form
    {
        public frmRedirectingProcessOutput()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRedirectingProcessOutput
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRedirectingProcessOutput";
            this.Text = "frmRedirectingProcessOutput";
            this.Load += new System.EventHandler(this.frmRedirectingProcessOutput_Load);
            this.ResumeLayout(false);

        }

        private void frmRedirectingProcessOutput_Load(object sender, EventArgs e)
        {

        }
    }
}
