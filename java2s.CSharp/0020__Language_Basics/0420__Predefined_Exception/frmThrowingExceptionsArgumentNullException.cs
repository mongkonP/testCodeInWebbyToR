using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0420__Predefined_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/ThrowingExceptionsArgumentNullException.htm
    public partial  class frmThrowingExceptionsArgumentNullException:Form
    {
        public frmThrowingExceptionsArgumentNullException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowingExceptionsArgumentNullException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowingExceptionsArgumentNullException";
            this.Text = "frmThrowingExceptionsArgumentNullException";
            this.Load += new System.EventHandler(this.frmThrowingExceptionsArgumentNullException_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowingExceptionsArgumentNullException_Load(object sender, EventArgs e)
        {

        }
    }
}
