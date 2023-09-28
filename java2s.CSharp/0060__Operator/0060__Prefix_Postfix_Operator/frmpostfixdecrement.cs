using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0060__Prefix_Postfix_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/postfixdecrement.htm
    public partial  class frmpostfixdecrement:Form
    {
        public frmpostfixdecrement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmpostfixdecrement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmpostfixdecrement";
            this.Text = "frmpostfixdecrement";
            this.Load += new System.EventHandler(this.frmpostfixdecrement_Load);
            this.ResumeLayout(false);

        }

        private void frmpostfixdecrement_Load(object sender, EventArgs e)
        {

        }
    }
}
