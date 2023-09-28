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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UseIComparer.htm
    public partial  class frmUseIComparer:Form
    {
        public frmUseIComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseIComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseIComparer";
            this.Text = "frmUseIComparer";
            this.Load += new System.EventHandler(this.frmUseIComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmUseIComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
