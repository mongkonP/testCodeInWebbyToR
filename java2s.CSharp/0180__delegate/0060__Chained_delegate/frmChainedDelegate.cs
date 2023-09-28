using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0060__Chained_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/ChainedDelegate.htm
    public partial  class frmChainedDelegate:Form
    {
        public frmChainedDelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChainedDelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChainedDelegate";
            this.Text = "frmChainedDelegate";
            this.Load += new System.EventHandler(this.frmChainedDelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmChainedDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
