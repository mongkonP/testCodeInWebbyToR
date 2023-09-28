using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0820__IComparable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ImplementIComparable.htm
    public partial  class frmImplementIComparable:Form
    {
        public frmImplementIComparable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementIComparable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementIComparable";
            this.Text = "frmImplementIComparable";
            this.Load += new System.EventHandler(this.frmImplementIComparable_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementIComparable_Load(object sender, EventArgs e)
        {

        }
    }
}
