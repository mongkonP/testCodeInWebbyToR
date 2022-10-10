using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0160__Evidence
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/MyEvidenceViewer.htm
    public partial  class frmMyEvidenceViewer:Form
    {
        public frmMyEvidenceViewer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMyEvidenceViewer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMyEvidenceViewer";
            this.Text = "frmMyEvidenceViewer";
            this.Load += new System.EventHandler(this.frmMyEvidenceViewer_Load);
            this.ResumeLayout(false);

        }

        private void frmMyEvidenceViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
