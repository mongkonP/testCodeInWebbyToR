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
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/CPointerOperators.htm
    public partial  class frmCPointerOperators:Form
    {
        public frmCPointerOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCPointerOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCPointerOperators";
            this.Text = "frmCPointerOperators";
            this.Load += new System.EventHandler(this.frmCPointerOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmCPointerOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
