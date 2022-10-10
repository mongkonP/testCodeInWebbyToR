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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ProcessRSS.htm
    public partial  class frmProcessRSS:Form
    {
        public frmProcessRSS()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProcessRSS
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProcessRSS";
            this.Text = "frmProcessRSS";
            this.Load += new System.EventHandler(this.frmProcessRSS_Load);
            this.ResumeLayout(false);

        }

        private void frmProcessRSS_Load(object sender, EventArgs e)
        {

        }
    }
}
