using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0480__Debug
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/DebugAssert.htm
    public partial  class frmDebugAssert:Form
    {
        public frmDebugAssert()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDebugAssert
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDebugAssert";
            this.Text = "frmDebugAssert";
            this.Load += new System.EventHandler(this.frmDebugAssert_Load);
            this.ResumeLayout(false);

        }

        private void frmDebugAssert_Load(object sender, EventArgs e)
        {

        }
    }
}
