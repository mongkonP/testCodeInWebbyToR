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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/RangeCartesianJoin.htm
    public partial  class frmRangeCartesianJoin:Form
    {
        public frmRangeCartesianJoin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRangeCartesianJoin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRangeCartesianJoin";
            this.Text = "frmRangeCartesianJoin";
            this.Load += new System.EventHandler(this.frmRangeCartesianJoin_Load);
            this.ResumeLayout(false);

        }

        private void frmRangeCartesianJoin_Load(object sender, EventArgs e)
        {

        }
    }
}
