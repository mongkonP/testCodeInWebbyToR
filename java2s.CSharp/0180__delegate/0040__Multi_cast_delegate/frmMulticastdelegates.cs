using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0040__Multi_cast_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Multicastdelegates.htm
    public partial  class frmMulticastdelegates:Form
    {
        public frmMulticastdelegates()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMulticastdelegates
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMulticastdelegates";
            this.Text = "frmMulticastdelegates";
            this.Load += new System.EventHandler(this.frmMulticastdelegates_Load);
            this.ResumeLayout(false);

        }

        private void frmMulticastdelegates_Load(object sender, EventArgs e)
        {

        }
    }
}
