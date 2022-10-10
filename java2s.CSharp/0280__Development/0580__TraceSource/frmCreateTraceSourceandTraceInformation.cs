using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0580__TraceSource
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CreateTraceSourceandTraceInformation.htm
    public partial  class frmCreateTraceSourceandTraceInformation:Form
    {
        public frmCreateTraceSourceandTraceInformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateTraceSourceandTraceInformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateTraceSourceandTraceInformation";
            this.Text = "frmCreateTraceSourceandTraceInformation";
            this.Load += new System.EventHandler(this.frmCreateTraceSourceandTraceInformation_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateTraceSourceandTraceInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
