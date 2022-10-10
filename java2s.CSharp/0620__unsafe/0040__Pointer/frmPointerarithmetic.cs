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
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Pointerarithmetic.htm
    public partial  class frmPointerarithmetic:Form
    {
        public frmPointerarithmetic()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPointerarithmetic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPointerarithmetic";
            this.Text = "frmPointerarithmetic";
            this.Load += new System.EventHandler(this.frmPointerarithmetic_Load);
            this.ResumeLayout(false);

        }

        private void frmPointerarithmetic_Load(object sender, EventArgs e)
        {

        }
    }
}
