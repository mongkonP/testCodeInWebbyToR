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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseAggregateonanarray.htm
    public partial  class frmUseAggregateonanarray:Form
    {
        public frmUseAggregateonanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseAggregateonanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseAggregateonanarray";
            this.Text = "frmUseAggregateonanarray";
            this.Load += new System.EventHandler(this.frmUseAggregateonanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmUseAggregateonanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
