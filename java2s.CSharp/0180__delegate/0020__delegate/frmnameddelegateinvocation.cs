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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/nameddelegateinvocation.htm
    public partial  class frmnameddelegateinvocation:Form
    {
        public frmnameddelegateinvocation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnameddelegateinvocation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnameddelegateinvocation";
            this.Text = "frmnameddelegateinvocation";
            this.Load += new System.EventHandler(this.frmnameddelegateinvocation_Load);
            this.ResumeLayout(false);

        }

        private void frmnameddelegateinvocation_Load(object sender, EventArgs e)
        {

        }
    }
}
