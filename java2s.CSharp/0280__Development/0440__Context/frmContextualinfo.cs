using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0440__Context
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Contextualinfo.htm
    public partial  class frmContextualinfo:Form
    {
        public frmContextualinfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContextualinfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContextualinfo";
            this.Text = "frmContextualinfo";
            this.Load += new System.EventHandler(this.frmContextualinfo_Load);
            this.ResumeLayout(false);

        }

        private void frmContextualinfo_Load(object sender, EventArgs e)
        {

        }
    }
}
