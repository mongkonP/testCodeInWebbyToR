using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0180__Variable_Scope
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Blockscope.htm
    public partial  class frmBlockscope:Form
    {
        public frmBlockscope()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBlockscope
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBlockscope";
            this.Text = "frmBlockscope";
            this.Load += new System.EventHandler(this.frmBlockscope_Load);
            this.ResumeLayout(false);

        }

        private void frmBlockscope_Load(object sender, EventArgs e)
        {

        }
    }
}
