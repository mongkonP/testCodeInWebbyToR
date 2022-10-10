using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0100__Array_Bound
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArrayGetLowerBoundGetUpperBound.htm
    public partial  class frmArrayGetLowerBoundGetUpperBound:Form
    {
        public frmArrayGetLowerBoundGetUpperBound()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayGetLowerBoundGetUpperBound
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayGetLowerBoundGetUpperBound";
            this.Text = "frmArrayGetLowerBoundGetUpperBound";
            this.Load += new System.EventHandler(this.frmArrayGetLowerBoundGetUpperBound_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayGetLowerBoundGetUpperBound_Load(object sender, EventArgs e)
        {

        }
    }
}
