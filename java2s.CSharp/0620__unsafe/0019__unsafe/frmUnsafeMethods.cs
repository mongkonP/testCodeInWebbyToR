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
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/UnsafeMethods.htm
    public partial  class frmUnsafeMethods:Form
    {
        public frmUnsafeMethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnsafeMethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnsafeMethods";
            this.Text = "frmUnsafeMethods";
            this.Load += new System.EventHandler(this.frmUnsafeMethods_Load);
            this.ResumeLayout(false);

        }

        private void frmUnsafeMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
