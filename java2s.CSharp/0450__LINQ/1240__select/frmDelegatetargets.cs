using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Delegatetargets.htm
    public partial  class frmDelegatetargets:Form
    {
        public frmDelegatetargets()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegatetargets
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegatetargets";
            this.Text = "frmDelegatetargets";
            this.Load += new System.EventHandler(this.frmDelegatetargets_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegatetargets_Load(object sender, EventArgs e)
        {

        }
    }
}
