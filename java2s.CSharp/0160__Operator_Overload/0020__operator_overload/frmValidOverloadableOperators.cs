using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0020__operator_overload
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/ValidOverloadableOperators.htm
    public partial  class frmValidOverloadableOperators:Form
    {
        public frmValidOverloadableOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValidOverloadableOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValidOverloadableOperators";
            this.Text = "frmValidOverloadableOperators";
            this.Load += new System.EventHandler(this.frmValidOverloadableOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmValidOverloadableOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
