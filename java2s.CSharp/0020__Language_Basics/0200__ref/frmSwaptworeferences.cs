using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0200__ref
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Swaptworeferences.htm
    public partial  class frmSwaptworeferences:Form
    {
        public frmSwaptworeferences()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSwaptworeferences
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSwaptworeferences";
            this.Text = "frmSwaptworeferences";
            this.Load += new System.EventHandler(this.frmSwaptworeferences_Load);
            this.ResumeLayout(false);

        }

        private void frmSwaptworeferences_Load(object sender, EventArgs e)
        {

        }
    }
}
