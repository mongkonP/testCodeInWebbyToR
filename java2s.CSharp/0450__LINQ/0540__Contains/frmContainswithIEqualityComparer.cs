using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0540__Contains
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ContainswithIEqualityComparer.htm
    public partial  class frmContainswithIEqualityComparer:Form
    {
        public frmContainswithIEqualityComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContainswithIEqualityComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContainswithIEqualityComparer";
            this.Text = "frmContainswithIEqualityComparer";
            this.Load += new System.EventHandler(this.frmContainswithIEqualityComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmContainswithIEqualityComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
