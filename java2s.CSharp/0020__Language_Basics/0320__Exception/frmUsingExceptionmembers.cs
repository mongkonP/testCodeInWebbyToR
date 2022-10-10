using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0320__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UsingExceptionmembers.htm
    public partial  class frmUsingExceptionmembers:Form
    {
        public frmUsingExceptionmembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingExceptionmembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingExceptionmembers";
            this.Text = "frmUsingExceptionmembers";
            this.Load += new System.EventHandler(this.frmUsingExceptionmembers_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingExceptionmembers_Load(object sender, EventArgs e)
        {

        }
    }
}
