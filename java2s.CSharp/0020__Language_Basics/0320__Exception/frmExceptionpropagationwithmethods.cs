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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Exceptionpropagationwithmethods.htm
    public partial  class frmExceptionpropagationwithmethods:Form
    {
        public frmExceptionpropagationwithmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExceptionpropagationwithmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExceptionpropagationwithmethods";
            this.Text = "frmExceptionpropagationwithmethods";
            this.Load += new System.EventHandler(this.frmExceptionpropagationwithmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmExceptionpropagationwithmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
