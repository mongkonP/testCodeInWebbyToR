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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Postdeploymenttracing.htm
    public partial  class frmPostdeploymenttracing:Form
    {
        public frmPostdeploymenttracing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPostdeploymenttracing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPostdeploymenttracing";
            this.Text = "frmPostdeploymenttracing";
            this.Load += new System.EventHandler(this.frmPostdeploymenttracing_Load);
            this.ResumeLayout(false);

        }

        private void frmPostdeploymenttracing_Load(object sender, EventArgs e)
        {

        }
    }
}
