using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1380__Sum
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NumericAggregatesSum.htm
    public partial  class frmNumericAggregatesSum:Form
    {
        public frmNumericAggregatesSum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericAggregatesSum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericAggregatesSum";
            this.Text = "frmNumericAggregatesSum";
            this.Load += new System.EventHandler(this.frmNumericAggregatesSum_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericAggregatesSum_Load(object sender, EventArgs e)
        {

        }
    }
}
