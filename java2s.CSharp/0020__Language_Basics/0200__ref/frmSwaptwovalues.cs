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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Swaptwovalues.htm
    public partial  class frmSwaptwovalues:Form
    {
        public frmSwaptwovalues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSwaptwovalues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSwaptwovalues";
            this.Text = "frmSwaptwovalues";
            this.Load += new System.EventHandler(this.frmSwaptwovalues_Load);
            this.ResumeLayout(false);

        }

        private void frmSwaptwovalues_Load(object sender, EventArgs e)
        {

        }
    }
}
