using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0440__RC2
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/UseRC2toencryptanddecrypttextfile.htm
    public partial  class frmUseRC2toencryptanddecrypttextfile:Form
    {
        public frmUseRC2toencryptanddecrypttextfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseRC2toencryptanddecrypttextfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseRC2toencryptanddecrypttextfile";
            this.Text = "frmUseRC2toencryptanddecrypttextfile";
            this.Load += new System.EventHandler(this.frmUseRC2toencryptanddecrypttextfile_Load);
            this.ResumeLayout(false);

        }

        private void frmUseRC2toencryptanddecrypttextfile_Load(object sender, EventArgs e)
        {

        }
    }
}
