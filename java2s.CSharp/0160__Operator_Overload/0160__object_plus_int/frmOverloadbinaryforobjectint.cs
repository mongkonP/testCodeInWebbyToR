using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0160__object_plus_int
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/Overloadbinaryforobjectint.htm
    public partial  class frmOverloadbinaryforobjectint:Form
    {
        public frmOverloadbinaryforobjectint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadbinaryforobjectint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadbinaryforobjectint";
            this.Text = "frmOverloadbinaryforobjectint";
            this.Load += new System.EventHandler(this.frmOverloadbinaryforobjectint_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadbinaryforobjectint_Load(object sender, EventArgs e)
        {

        }
    }
}
