using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0400__Exception_Throw
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/ThrowExceptionfromafunction.htm
    public partial  class frmThrowExceptionfromafunction:Form
    {
        public frmThrowExceptionfromafunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowExceptionfromafunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowExceptionfromafunction";
            this.Text = "frmThrowExceptionfromafunction";
            this.Load += new System.EventHandler(this.frmThrowExceptionfromafunction_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowExceptionfromafunction_Load(object sender, EventArgs e)
        {

        }
    }
}
