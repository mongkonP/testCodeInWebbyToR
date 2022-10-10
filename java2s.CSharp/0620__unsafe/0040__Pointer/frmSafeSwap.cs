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
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/SafeSwap.htm
    public partial  class frmSafeSwap:Form
    {
        public frmSafeSwap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSafeSwap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSafeSwap";
            this.Text = "frmSafeSwap";
            this.Load += new System.EventHandler(this.frmSafeSwap_Load);
            this.ResumeLayout(false);

        }

        private void frmSafeSwap_Load(object sender, EventArgs e)
        {

        }
    }
}
