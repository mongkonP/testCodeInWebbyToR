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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/RangeReversal.htm
    public partial  class frmRangeReversal:Form
    {
        public frmRangeReversal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRangeReversal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRangeReversal";
            this.Text = "frmRangeReversal";
            this.Load += new System.EventHandler(this.frmRangeReversal_Load);
            this.ResumeLayout(false);

        }

        private void frmRangeReversal_Load(object sender, EventArgs e)
        {

        }
    }
}
