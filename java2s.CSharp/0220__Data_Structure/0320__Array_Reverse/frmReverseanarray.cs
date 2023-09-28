using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0320__Array_Reverse
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Reverseanarray.htm
    public partial  class frmReverseanarray:Form
    {
        public frmReverseanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReverseanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReverseanarray";
            this.Text = "frmReverseanarray";
            this.Load += new System.EventHandler(this.frmReverseanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmReverseanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
