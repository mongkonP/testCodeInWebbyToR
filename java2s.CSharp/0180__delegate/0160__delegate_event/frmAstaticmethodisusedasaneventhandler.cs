using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Astaticmethodisusedasaneventhandler.htm
    public partial  class frmAstaticmethodisusedasaneventhandler:Form
    {
        public frmAstaticmethodisusedasaneventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAstaticmethodisusedasaneventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAstaticmethodisusedasaneventhandler";
            this.Text = "frmAstaticmethodisusedasaneventhandler";
            this.Load += new System.EventHandler(this.frmAstaticmethodisusedasaneventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmAstaticmethodisusedasaneventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
