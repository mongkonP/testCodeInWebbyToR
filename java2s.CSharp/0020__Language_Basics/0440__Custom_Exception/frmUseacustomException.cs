using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0440__Custom_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UseacustomException.htm
    public partial  class frmUseacustomException:Form
    {
        public frmUseacustomException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseacustomException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseacustomException";
            this.Text = "frmUseacustomException";
            this.Load += new System.EventHandler(this.frmUseacustomException_Load);
            this.ResumeLayout(false);

        }

        private void frmUseacustomException_Load(object sender, EventArgs e)
        {

        }
    }
}
