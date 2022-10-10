using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0800__Evidence
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Evidence.htm
    public partial  class frmEvidence:Form
    {
        public frmEvidence()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEvidence
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEvidence";
            this.Text = "frmEvidence";
            this.Load += new System.EventHandler(this.frmEvidence_Load);
            this.ResumeLayout(false);

        }

        private void frmEvidence_Load(object sender, EventArgs e)
        {

        }
    }
}
