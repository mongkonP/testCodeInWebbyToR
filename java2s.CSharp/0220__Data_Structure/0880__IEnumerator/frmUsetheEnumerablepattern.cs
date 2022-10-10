using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0880__IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UsetheEnumerablepattern.htm
    public partial  class frmUsetheEnumerablepattern:Form
    {
        public frmUsetheEnumerablepattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheEnumerablepattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheEnumerablepattern";
            this.Text = "frmUsetheEnumerablepattern";
            this.Load += new System.EventHandler(this.frmUsetheEnumerablepattern_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheEnumerablepattern_Load(object sender, EventArgs e)
        {

        }
    }
}
