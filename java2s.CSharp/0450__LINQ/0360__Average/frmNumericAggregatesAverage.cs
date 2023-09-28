using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0360__Average
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NumericAggregatesAverage.htm
    public partial  class frmNumericAggregatesAverage:Form
    {
        public frmNumericAggregatesAverage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericAggregatesAverage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericAggregatesAverage";
            this.Text = "frmNumericAggregatesAverage";
            this.Load += new System.EventHandler(this.frmNumericAggregatesAverage_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericAggregatesAverage_Load(object sender, EventArgs e)
        {

        }
    }
}
