using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0300__Aggregate
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AggregateandSum.htm
    public partial  class frmAggregateandSum:Form
    {
        public frmAggregateandSum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAggregateandSum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAggregateandSum";
            this.Text = "frmAggregateandSum";
            this.Load += new System.EventHandler(this.frmAggregateandSum_Load);
            this.ResumeLayout(false);

        }

        private void frmAggregateandSum_Load(object sender, EventArgs e)
        {

        }
    }
}
