using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0020__delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Delegatewithreferenceparamemters.htm
    public partial  class frmDelegatewithreferenceparamemters:Form
    {
        public frmDelegatewithreferenceparamemters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegatewithreferenceparamemters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegatewithreferenceparamemters";
            this.Text = "frmDelegatewithreferenceparamemters";
            this.Load += new System.EventHandler(this.frmDelegatewithreferenceparamemters_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegatewithreferenceparamemters_Load(object sender, EventArgs e)
        {

        }
    }
}
