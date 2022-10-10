using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0220__Anonymous
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ReturnFromAnonymousMethod.htm
    public partial  class frmReturnFromAnonymousMethod:Form
    {
        public frmReturnFromAnonymousMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturnFromAnonymousMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturnFromAnonymousMethod";
            this.Text = "frmReturnFromAnonymousMethod";
            this.Load += new System.EventHandler(this.frmReturnFromAnonymousMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmReturnFromAnonymousMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
