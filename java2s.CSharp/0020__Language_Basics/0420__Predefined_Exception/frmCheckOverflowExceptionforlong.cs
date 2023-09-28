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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/CheckOverflowExceptionforlong.htm
    public partial  class frmCheckOverflowExceptionforlong:Form
    {
        public frmCheckOverflowExceptionforlong()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckOverflowExceptionforlong
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckOverflowExceptionforlong";
            this.Text = "frmCheckOverflowExceptionforlong";
            this.Load += new System.EventHandler(this.frmCheckOverflowExceptionforlong_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckOverflowExceptionforlong_Load(object sender, EventArgs e)
        {

        }
    }
}
