using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0020__IntPtr
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/IntPtrZero.htm
    public partial  class frmIntPtrZero:Form
    {
        public frmIntPtrZero()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntPtrZero
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntPtrZero";
            this.Text = "frmIntPtrZero";
            this.Load += new System.EventHandler(this.frmIntPtrZero_Load);
            this.ResumeLayout(false);

        }

        private void frmIntPtrZero_Load(object sender, EventArgs e)
        {

        }
    }
}
