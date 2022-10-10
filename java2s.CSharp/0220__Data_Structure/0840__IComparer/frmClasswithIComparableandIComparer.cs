using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0840__IComparer
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ClasswithIComparableandIComparer.htm
    public partial  class frmClasswithIComparableandIComparer:Form
    {
        public frmClasswithIComparableandIComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClasswithIComparableandIComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClasswithIComparableandIComparer";
            this.Text = "frmClasswithIComparableandIComparer";
            this.Load += new System.EventHandler(this.frmClasswithIComparableandIComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmClasswithIComparableandIComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
