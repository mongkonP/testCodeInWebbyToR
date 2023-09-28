using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0460__where
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericOperatorOverloading.htm
    public partial  class frmGenericOperatorOverloading:Form
    {
        public frmGenericOperatorOverloading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericOperatorOverloading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericOperatorOverloading";
            this.Text = "frmGenericOperatorOverloading";
            this.Load += new System.EventHandler(this.frmGenericOperatorOverloading_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericOperatorOverloading_Load(object sender, EventArgs e)
        {

        }
    }
}
