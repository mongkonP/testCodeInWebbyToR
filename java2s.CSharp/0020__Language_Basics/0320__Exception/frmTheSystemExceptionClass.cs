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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/TheSystemExceptionClass.htm
    public partial  class frmTheSystemExceptionClass:Form
    {
        public frmTheSystemExceptionClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheSystemExceptionClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheSystemExceptionClass";
            this.Text = "frmTheSystemExceptionClass";
            this.Load += new System.EventHandler(this.frmTheSystemExceptionClass_Load);
            this.ResumeLayout(false);

        }

        private void frmTheSystemExceptionClass_Load(object sender, EventArgs e)
        {

        }
    }
}
