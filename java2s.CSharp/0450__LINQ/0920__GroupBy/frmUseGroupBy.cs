using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0920__GroupBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseGroupBy.htm
    public partial  class frmUseGroupBy:Form
    {
        public frmUseGroupBy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseGroupBy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseGroupBy";
            this.Text = "frmUseGroupBy";
            this.Load += new System.EventHandler(this.frmUseGroupBy_Load);
            this.ResumeLayout(false);

        }

        private void frmUseGroupBy_Load(object sender, EventArgs e)
        {

        }
    }
}
