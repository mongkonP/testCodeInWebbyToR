using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/IntPtrsandunsafebittwiddling.htm
    public partial  class frmIntPtrsandunsafebittwiddling:Form
    {
        public frmIntPtrsandunsafebittwiddling()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntPtrsandunsafebittwiddling
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntPtrsandunsafebittwiddling";
            this.Text = "frmIntPtrsandunsafebittwiddling";
            this.Load += new System.EventHandler(this.frmIntPtrsandunsafebittwiddling_Load);
            this.ResumeLayout(false);

        }

        private void frmIntPtrsandunsafebittwiddling_Load(object sender, EventArgs e)
        {

        }
    }
}
