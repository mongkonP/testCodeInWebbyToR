using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0220__out
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Useout.htm
    public partial  class frmUseout:Form
    {
        public frmUseout()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseout
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseout";
            this.Text = "frmUseout";
            this.Load += new System.EventHandler(this.frmUseout_Load);
            this.ResumeLayout(false);

        }

        private void frmUseout_Load(object sender, EventArgs e)
        {

        }
    }
}
