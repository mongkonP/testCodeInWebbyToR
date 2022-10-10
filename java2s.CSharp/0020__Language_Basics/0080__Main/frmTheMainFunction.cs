using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0080__Main
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/TheMainFunction.htm
    public partial  class frmTheMainFunction:Form
    {
        public frmTheMainFunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheMainFunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheMainFunction";
            this.Text = "frmTheMainFunction";
            this.Load += new System.EventHandler(this.frmTheMainFunction_Load);
            this.ResumeLayout(false);

        }

        private void frmTheMainFunction_Load(object sender, EventArgs e)
        {

        }
    }
}
