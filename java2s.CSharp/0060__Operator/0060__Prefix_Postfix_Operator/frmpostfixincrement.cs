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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/postfixincrement.htm
    public partial  class frmpostfixincrement:Form
    {
        public frmpostfixincrement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmpostfixincrement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmpostfixincrement";
            this.Text = "frmpostfixincrement";
            this.Load += new System.EventHandler(this.frmpostfixincrement_Load);
            this.ResumeLayout(false);

        }

        private void frmpostfixincrement_Load(object sender, EventArgs e)
        {

        }
    }
}
