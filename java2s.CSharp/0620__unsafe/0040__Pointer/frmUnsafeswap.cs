using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Unsafeswap.htm
    public partial  class frmUnsafeswap:Form
    {
        public frmUnsafeswap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnsafeswap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnsafeswap";
            this.Text = "frmUnsafeswap";
            this.Load += new System.EventHandler(this.frmUnsafeswap_Load);
            this.ResumeLayout(false);

        }

        private void frmUnsafeswap_Load(object sender, EventArgs e)
        {

        }
    }
}
