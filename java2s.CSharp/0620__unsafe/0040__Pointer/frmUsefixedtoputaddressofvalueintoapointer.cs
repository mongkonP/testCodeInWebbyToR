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
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Usefixedtoputaddressofvalueintoapointer.htm
    public partial  class frmUsefixedtoputaddressofvalueintoapointer:Form
    {
        public frmUsefixedtoputaddressofvalueintoapointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsefixedtoputaddressofvalueintoapointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsefixedtoputaddressofvalueintoapointer";
            this.Text = "frmUsefixedtoputaddressofvalueintoapointer";
            this.Load += new System.EventHandler(this.frmUsefixedtoputaddressofvalueintoapointer_Load);
            this.ResumeLayout(false);

        }

        private void frmUsefixedtoputaddressofvalueintoapointer_Load(object sender, EventArgs e)
        {

        }
    }
}
