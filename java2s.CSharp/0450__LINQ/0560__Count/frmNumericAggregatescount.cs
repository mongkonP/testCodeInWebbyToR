using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0560__Count
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NumericAggregatescount.htm
    public partial  class frmNumericAggregatescount:Form
    {
        public frmNumericAggregatescount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericAggregatescount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericAggregatescount";
            this.Text = "frmNumericAggregatescount";
            this.Load += new System.EventHandler(this.frmNumericAggregatescount_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericAggregatescount_Load(object sender, EventArgs e)
        {

        }
    }
}
