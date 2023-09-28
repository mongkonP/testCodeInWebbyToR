using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1160__Range
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/RangeOrdering.htm
    public partial  class frmRangeOrdering:Form
    {
        public frmRangeOrdering()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRangeOrdering
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRangeOrdering";
            this.Text = "frmRangeOrdering";
            this.Load += new System.EventHandler(this.frmRangeOrdering_Load);
            this.ResumeLayout(false);

        }

        private void frmRangeOrdering_Load(object sender, EventArgs e)
        {

        }
    }
}
