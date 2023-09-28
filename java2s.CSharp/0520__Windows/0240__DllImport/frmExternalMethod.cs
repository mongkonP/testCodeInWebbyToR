using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0240__DllImport
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/ExternalMethod.htm
    public partial  class frmExternalMethod:Form
    {
        public frmExternalMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExternalMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExternalMethod";
            this.Text = "frmExternalMethod";
            this.Load += new System.EventHandler(this.frmExternalMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmExternalMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
