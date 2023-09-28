using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0500__RSS
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectnodesinRSS.htm
    public partial  class frmSelectnodesinRSS:Form
    {
        public frmSelectnodesinRSS()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectnodesinRSS
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectnodesinRSS";
            this.Text = "frmSelectnodesinRSS";
            this.Load += new System.EventHandler(this.frmSelectnodesinRSS_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectnodesinRSS_Load(object sender, EventArgs e)
        {

        }
    }
}
