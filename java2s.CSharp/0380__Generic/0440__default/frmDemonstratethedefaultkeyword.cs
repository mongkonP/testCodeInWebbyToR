using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0440__default
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Demonstratethedefaultkeyword.htm
    public partial  class frmDemonstratethedefaultkeyword:Form
    {
        public frmDemonstratethedefaultkeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratethedefaultkeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratethedefaultkeyword";
            this.Text = "frmDemonstratethedefaultkeyword";
            this.Load += new System.EventHandler(this.frmDemonstratethedefaultkeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratethedefaultkeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
