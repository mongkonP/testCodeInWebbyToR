using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0120__delegate_parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Usingadelegatetochoosetherightfunctiontocall.htm
    public partial  class frmUsingadelegatetochoosetherightfunctiontocall:Form
    {
        public frmUsingadelegatetochoosetherightfunctiontocall()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingadelegatetochoosetherightfunctiontocall
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingadelegatetochoosetherightfunctiontocall";
            this.Text = "frmUsingadelegatetochoosetherightfunctiontocall";
            this.Load += new System.EventHandler(this.frmUsingadelegatetochoosetherightfunctiontocall_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingadelegatetochoosetherightfunctiontocall_Load(object sender, EventArgs e)
        {

        }
    }
}
