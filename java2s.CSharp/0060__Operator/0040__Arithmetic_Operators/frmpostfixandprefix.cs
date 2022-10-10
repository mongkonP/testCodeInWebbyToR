using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0040__Arithmetic_Operators
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/postfixandprefix.htm
    public partial  class frmpostfixandprefix:Form
    {
        public frmpostfixandprefix()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmpostfixandprefix
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmpostfixandprefix";
            this.Text = "frmpostfixandprefix";
            this.Load += new System.EventHandler(this.frmpostfixandprefix_Load);
            this.ResumeLayout(false);

        }

        private void frmpostfixandprefix_Load(object sender, EventArgs e)
        {

        }
    }
}
