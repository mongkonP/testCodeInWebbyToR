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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Aggregatethreevalues.htm
    public partial  class frmAggregatethreevalues:Form
    {
        public frmAggregatethreevalues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAggregatethreevalues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAggregatethreevalues";
            this.Text = "frmAggregatethreevalues";
            this.Load += new System.EventHandler(this.frmAggregatethreevalues_Load);
            this.ResumeLayout(false);

        }

        private void frmAggregatethreevalues_Load(object sender, EventArgs e)
        {

        }
    }
}
