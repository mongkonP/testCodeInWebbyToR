using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0020__var
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ExplicitRangeVariable.htm
    public partial  class frmExplicitRangeVariable:Form
    {
        public frmExplicitRangeVariable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExplicitRangeVariable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExplicitRangeVariable";
            this.Text = "frmExplicitRangeVariable";
            this.Load += new System.EventHandler(this.frmExplicitRangeVariable_Load);
            this.ResumeLayout(false);

        }

        private void frmExplicitRangeVariable_Load(object sender, EventArgs e)
        {

        }
    }
}
