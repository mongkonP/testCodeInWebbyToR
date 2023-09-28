using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0320__Generic_Hiearchy
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Overridingavirtualmethodinagenericclass.htm
    public partial  class frmOverridingavirtualmethodinagenericclass:Form
    {
        public frmOverridingavirtualmethodinagenericclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverridingavirtualmethodinagenericclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverridingavirtualmethodinagenericclass";
            this.Text = "frmOverridingavirtualmethodinagenericclass";
            this.Load += new System.EventHandler(this.frmOverridingavirtualmethodinagenericclass_Load);
            this.ResumeLayout(false);

        }

        private void frmOverridingavirtualmethodinagenericclass_Load(object sender, EventArgs e)
        {

        }
    }
}
