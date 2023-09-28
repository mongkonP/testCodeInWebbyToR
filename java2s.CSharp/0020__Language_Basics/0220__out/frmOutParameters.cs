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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/OutParameters.htm
    public partial  class frmOutParameters:Form
    {
        public frmOutParameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOutParameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOutParameters";
            this.Text = "frmOutParameters";
            this.Load += new System.EventHandler(this.frmOutParameters_Load);
            this.ResumeLayout(false);

        }

        private void frmOutParameters_Load(object sender, EventArgs e)
        {

        }
    }
}
