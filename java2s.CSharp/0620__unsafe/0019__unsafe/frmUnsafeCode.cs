using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/UnsafeCode.htm
    public partial  class frmUnsafeCode:Form
    {
        public frmUnsafeCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnsafeCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnsafeCode";
            this.Text = "frmUnsafeCode";
            this.Load += new System.EventHandler(this.frmUnsafeCode_Load);
            this.ResumeLayout(false);

        }

        private void frmUnsafeCode_Load(object sender, EventArgs e)
        {

        }
    }
}
