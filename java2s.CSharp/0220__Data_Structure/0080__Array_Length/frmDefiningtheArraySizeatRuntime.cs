using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0080__Array_Length
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DefiningtheArraySizeatRuntime.htm
    public partial  class frmDefiningtheArraySizeatRuntime:Form
    {
        public frmDefiningtheArraySizeatRuntime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefiningtheArraySizeatRuntime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefiningtheArraySizeatRuntime";
            this.Text = "frmDefiningtheArraySizeatRuntime";
            this.Load += new System.EventHandler(this.frmDefiningtheArraySizeatRuntime_Load);
            this.ResumeLayout(false);

        }

        private void frmDefiningtheArraySizeatRuntime_Load(object sender, EventArgs e)
        {

        }
    }
}
