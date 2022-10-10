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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/RefandOutParameters.htm
    public partial  class frmRefandOutParameters:Form
    {
        public frmRefandOutParameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRefandOutParameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRefandOutParameters";
            this.Text = "frmRefandOutParameters";
            this.Load += new System.EventHandler(this.frmRefandOutParameters_Load);
            this.ResumeLayout(false);

        }

        private void frmRefandOutParameters_Load(object sender, EventArgs e)
        {

        }
    }
}
