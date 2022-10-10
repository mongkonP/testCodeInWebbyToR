using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1080__Min
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NumericAggregatesMin.htm
    public partial  class frmNumericAggregatesMin:Form
    {
        public frmNumericAggregatesMin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericAggregatesMin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericAggregatesMin";
            this.Text = "frmNumericAggregatesMin";
            this.Load += new System.EventHandler(this.frmNumericAggregatesMin_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericAggregatesMin_Load(object sender, EventArgs e)
        {

        }
    }
}
