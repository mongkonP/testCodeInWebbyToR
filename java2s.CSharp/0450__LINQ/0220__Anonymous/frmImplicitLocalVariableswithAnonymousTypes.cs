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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ImplicitLocalVariableswithAnonymousTypes.htm
    public partial  class frmImplicitLocalVariableswithAnonymousTypes:Form
    {
        public frmImplicitLocalVariableswithAnonymousTypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplicitLocalVariableswithAnonymousTypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplicitLocalVariableswithAnonymousTypes";
            this.Text = "frmImplicitLocalVariableswithAnonymousTypes";
            this.Load += new System.EventHandler(this.frmImplicitLocalVariableswithAnonymousTypes_Load);
            this.ResumeLayout(false);

        }

        private void frmImplicitLocalVariableswithAnonymousTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
