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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AnonymousMethod.htm
    public partial  class frmAnonymousMethod:Form
    {
        public frmAnonymousMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousMethod";
            this.Text = "frmAnonymousMethod";
            this.Load += new System.EventHandler(this.frmAnonymousMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
