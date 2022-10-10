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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/RemovedelegatefromMulticast.htm
    public partial  class frmRemovedelegatefromMulticast:Form
    {
        public frmRemovedelegatefromMulticast()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemovedelegatefromMulticast
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemovedelegatefromMulticast";
            this.Text = "frmRemovedelegatefromMulticast";
            this.Load += new System.EventHandler(this.frmRemovedelegatefromMulticast_Load);
            this.ResumeLayout(false);

        }

        private void frmRemovedelegatefromMulticast_Load(object sender, EventArgs e)
        {

        }
    }
}
