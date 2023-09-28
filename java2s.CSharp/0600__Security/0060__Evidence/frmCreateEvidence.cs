using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0060__Evidence
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/CreateEvidence.htm
    public partial  class frmCreateEvidence:Form
    {
        public frmCreateEvidence()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateEvidence
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateEvidence";
            this.Text = "frmCreateEvidence";
            this.Load += new System.EventHandler(this.frmCreateEvidence_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateEvidence_Load(object sender, EventArgs e)
        {

        }
    }
}
