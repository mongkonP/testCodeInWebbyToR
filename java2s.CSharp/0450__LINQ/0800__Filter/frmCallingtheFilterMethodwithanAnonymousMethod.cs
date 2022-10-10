using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0800__Filter
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CallingtheFilterMethodwithanAnonymousMethod.htm
    public partial  class frmCallingtheFilterMethodwithanAnonymousMethod:Form
    {
        public frmCallingtheFilterMethodwithanAnonymousMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallingtheFilterMethodwithanAnonymousMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallingtheFilterMethodwithanAnonymousMethod";
            this.Text = "frmCallingtheFilterMethodwithanAnonymousMethod";
            this.Load += new System.EventHandler(this.frmCallingtheFilterMethodwithanAnonymousMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmCallingtheFilterMethodwithanAnonymousMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
